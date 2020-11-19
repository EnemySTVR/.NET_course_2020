using Microsoft.AspNetCore.Mvc;
using Shinkarev_Dmitriy_Task19.Data.interfaces;
using Shinkarev_Dmitriy_Task19.Data.Models;
using System;
using System.Linq;

namespace Shinkarev_Dmitriy_Task19.Controllers
{
    public class RewardsController : Controller
    {
        private readonly IAllRewards _iAllRewards;

        public RewardsController(IAllRewards iAllPrizes)
        {
            _iAllRewards = iAllPrizes;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Title = "Page with rewards";
            return View(_iAllRewards.AllRewards);
        }

        [HttpGet]
        public IActionResult RemoveReward(int selectedRewardId)
        {
            ViewBag.Title = "Page with rewards";
            _iAllRewards.RemoveReward(selectedRewardId);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddReward()
        {
            ViewBag.Title = "Add new reward";
            return View();
        }

        [HttpPost]
        public IActionResult AddReward(Reward model)
        {
            _iAllRewards.AddRewardAndSetId(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult ChangeReward(int selectedRewardId)
        {
            if (selectedRewardId == 0)
            {
                return RedirectToAction("Index");
            }
            ViewBag.Title = "Change reward";
            var reward = _iAllRewards.AllRewards
                .Where(x => x.Id == selectedRewardId)
                .FirstOrDefault();
            return View(reward);
        }

        [HttpPost]
        public IActionResult ChangeReward(Reward reward)
        {
            _iAllRewards.ChangeReward(reward);
            return RedirectToAction("Index");
        }
    }
}
