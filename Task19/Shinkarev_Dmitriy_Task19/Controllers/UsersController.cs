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
        public ViewResult Index()
        {
            ViewBag.Title = "Page with users";
            return View(_allUsers.AllUsers);
        }

        [HttpGet]
        public ViewResult RemoveUser(int selectedUserId)
        {
            ViewBag.Title = "Page with users";
            _allUsers.RemoveUser(selectedUserId);
            return View("Index", _allUsers.AllUsers);
        }

        [HttpGet]
        public ViewResult AddUser()
        {
            ViewBag.Title = "Add new user";
            return View(_allRewards.AllRewards);
        }

        [HttpPost]
        public ViewResult AddUser(string newUserFirstName, string newUserLastName, DateTime newUserBirthDate, int[] prizesId)
        {
            ViewBag.Title = "Page with users";
            var rewards = _allRewards.AllRewards
                .Where(x => prizesId.Contains(x.Id))
                .ToList();
            _allUsers.AddUserAndSetId(newUserFirstName, newUserLastName, newUserBirthDate, rewards);
            return View("Index", _allUsers.AllUsers);
        }

        [HttpGet]
        public ViewResult ChangeUser(int selectedUserId)
        {
            ViewBag.Title = "Change user";
            var user = _allUsers.GetUserById(selectedUserId);
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
            var model = (user, rewardChecker);

            return View(model);
        }

        [HttpPost]
        public ViewResult ChangeUser(int userId, string newUserFirstName, string newUserLastName, DateTime newUserBirthDate, int[] prizesId)
        {
            var checkedRewards = _allRewards.AllRewards
                .Where(x => prizesId.Contains(x.Id))
                .ToList();

            ViewBag.Title = "Page with users";
            _allUsers.ChangeUser(userId, newUserFirstName, newUserLastName, newUserBirthDate, checkedRewards);
            return View("Index", _allUsers.AllUsers);
        }

        [HttpGet]
        public ViewResult RewardUser(int selectedUserId)
        {
            ViewBag.Title = "Reward user";
            var user = _allUsers.GetUserById(selectedUserId);
            List<Reward> availableRewards = _allRewards.AllRewards
                .Where(x => !user.Rewards.Contains(x))
                .ToList();

            var model = new KeyValuePair<User, List<Reward>>(user, availableRewards);
            return View(model);

        }

        [HttpPost]
        public ViewResult RewardUser(int userId, int rewardId)
        {
            ViewBag.Title = "Page with users";
            _allUsers.RewardUser(userId, rewardId);
            return View("Index", _allUsers.AllUsers);
        }
    }
}
