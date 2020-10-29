using Shinkarev_Dmitriy_Task19.Data.interfaces;
using Shinkarev_Dmitriy_Task19.Data.Models;
using Shinkarev_Dmitriy_Task19.Data.Repository;
using System.Collections.Generic;
using System.Linq;

namespace Shinkarev_Dmitriy_Task19.Data.mocks
{
    public class AllRewardsImplementation : IAllRewards
    {
        readonly RewardDAO rewardDAO;
        readonly UserRewardsDAO userRewardsDAO;

        public AllRewardsImplementation()
        {
            rewardDAO = new RewardDAO();
            userRewardsDAO = new UserRewardsDAO();
        }
        List<Reward> IAllRewards.AllRewards 
        {
            get
            {
                return rewardDAO.AllRewards;
            }
        }
        public Reward GetRewardById(int rewardId)
        {
            return rewardDAO.AllRewards
                .Where(x => x.Id == rewardId)
                .FirstOrDefault();
        }

        public void AddRewardAndSetId(string name, string description)
        {
            var reward = new Reward()
            {
                Name = name,
                Description = description
            };
            rewardDAO.AddRewardAndSetID(reward);
        }

        public void ChangeReward(int rewardId, string newName, string newDescription)
        {
            var reward = rewardDAO.AllRewards
                .Where(x => x.Id == rewardId)
                .FirstOrDefault();
            reward.Name = newName;
            reward.Description = newDescription;
            rewardDAO.ChangeReward(reward);
        }

        public void RemoveReward(int rewardId)
        {
            var users = userRewardsDAO.GetUsersForConcretReward(rewardId);
            foreach (var user in users)
            {
                userRewardsDAO.RemoveUserReward(user.Id, rewardId);
            }
            rewardDAO.RemoveReward(rewardId);
        }
    }
}
