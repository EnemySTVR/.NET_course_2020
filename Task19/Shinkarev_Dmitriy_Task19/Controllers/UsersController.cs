using Microsoft.AspNetCore.Mvc;
using Shinkarev_Dmitriy_Task19.Data.interfaces;
using Shinkarev_Dmitriy_Task19.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shinkarev_Dmitriy_Task19.Controllers
{
    public class UsersController : Controller
    {
        
        private readonly IAllUsers _allUsers;
        private readonly IAllRewards _allRewards;

        public UsersController(IAllUsers iAllUsers, IAllRewards iAllRewards)
        {
            _allUsers = iAllUsers;
            _allRewards = iAllRewards;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Title = "Page with users";
            return View(_allUsers.AllUsers);
        }

        [HttpGet]
        public IActionResult RemoveUser(int selectedUserId)
        {
            if (selectedUserId != 0)
            {
                _allUsers.RemoveUser(selectedUserId);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddUser()
        {
            ViewBag.Title = "Add new user";
            ViewBag.RewardChecker = GetRewardChecker();
            return View();
        }

        [HttpPost]
        public IActionResult AddUser(User model, int[] chekedRewardsId)
        {
            
            if (ModelState.IsValid)
            {
                var rewards = _allRewards.AllRewards
                .Where(x => chekedRewardsId.Contains(x.Id))
                .ToList();
                _allUsers.AddUserAndSetId(model);
                _allUsers.RewardUser(model.Id, rewards);

                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.RewardChecker = GetRewardChecker(chekedRewardsId);
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult ChangeUser(int selectedUserId)
        {
            if (selectedUserId == 0)
            {
                return RedirectToAction("Index");
            }
            ViewBag.Title = "Change user";
            var user = _allUsers.GetUserById(selectedUserId);
            ViewBag.RewardChecker = GetRewardChecker(user);

            return View(user);
        }

        [HttpPost]
        public IActionResult ChangeUser(User user, int[] chekedRewardsId)
        {
            if (ModelState.IsValid)
            {
                user.Rewards = _allRewards.GetRewardsForConcretUser(user.Id);
                var checkedRewards = _allRewards.AllRewards
                .Where(x => chekedRewardsId.Contains(x.Id))
                .ToList();

                foreach (var reward in checkedRewards)
                {
                    if (!user.Rewards.Contains(reward))
                    {
                        _allUsers.RewardUser(user.Id, reward.Id);
                    }
                }
                foreach (var reward in user.Rewards)
                {
                    if (!checkedRewards.Contains(reward))
                    {
                        _allUsers.RemoveRevardFromUser(user.Id, reward.Id);
                    }
                }

                _allUsers.ChangeUser(user);

                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.RewardChecker = GetRewardChecker(chekedRewardsId);
                return View(user);
            }
        }

        [HttpGet]
        public IActionResult RewardUser(int selectedUserId)
        {
            if (selectedUserId == 0)
            {
                return RedirectToAction("Index");
            }
            ViewBag.Title = "Reward user";
            var user = _allUsers.GetUserById(selectedUserId);
            List<Reward> availableRewards = _allRewards.AllRewards
                .Where(x => !user.Rewards.Contains(x))
                .ToList();
            ViewBag.AvailableRewards = availableRewards;
            return View(user);

        }

        [HttpPost]
        public IActionResult RewardUser(User user, int rewardId)
        {
            _allUsers.RewardUser(user.Id, rewardId);
            return RedirectToAction("Index");
        }

        private Dictionary<Reward, bool> GetRewardChecker(User user)
        {
            var rewardChecker = new Dictionary<Reward, bool>();
            foreach (var reward in _allRewards.AllRewards)
            {
                bool checker;
                if (user.Rewards.Contains(reward))
                {
                    checker = true;
                }
                else
                {
                    checker = false;
                }
                rewardChecker.Add(reward, checker);
            }
            return rewardChecker;
        }

        private Dictionary<Reward, bool> GetRewardChecker(int[] chekedRewardsId)
        {
            var rewardChecker = new Dictionary<Reward, bool>();
            foreach (var reward in _allRewards.AllRewards)
            {
                bool checker;
                if (chekedRewardsId.Contains(reward.Id))
                {
                    checker = true;
                }
                else
                {
                    checker = false;
                }
                rewardChecker.Add(reward, checker);
            }
            return rewardChecker;
        }

        private Dictionary<Reward, bool> GetRewardChecker()
        {
            var rewardChecker = new Dictionary<Reward, bool>();
            foreach (var reward in _allRewards.AllRewards)
            {
                rewardChecker.Add(reward, false);
            }
            return rewardChecker;
        }
    }
}
