using Microsoft.AspNetCore.Mvc;
using Shinkarev_Dmitriy_Task19.Data.interfaces;
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
        public ViewResult Index()
        {
            ViewBag.Title = "Page with rewards";
            return View(_iAllRewards.AllRewards);
        }

        [HttpGet]
        public ViewResult RemoveReward(int rewardId)
        {
            ViewBag.Title = "Page with rewards";
            _iAllRewards.RemoveReward(rewardId);
            return View("Index", _iAllRewards.AllRewards);
        }

        [HttpGet]
        public ViewResult AddReward()
        {
            ViewBag.Title = "Add new reward";
            return View();
        }

        [HttpPost]
        public ViewResult AddReward(string newRewardName, string newRewardDescription)
        {
            ViewBag.Title = "Page with rewards";
            _iAllRewards.AddRewardAndSetId(newRewardName, newRewardDescription);
            return View("Index", _iAllRewards.AllRewards);
        }

        [HttpGet]
        public ViewResult ChangeReward(int rewardId)
        {
            ViewBag.Title = "Change reward";
            var reward = _iAllRewards.AllRewards
                .Where(x => x.Id == rewardId)
                .FirstOrDefault();
            return View(reward);
        }

        [HttpPost]
        public ViewResult ChangeReward(int rewardId, string newRewardName, string newRewardDescription)
        {
            ViewBag.Title = "Page with rewards";
            _iAllRewards.ChangeReward(rewardId, newRewardName, newRewardDescription);
            return View("Index", _iAllRewards.AllRewards);
        }
    }
}
