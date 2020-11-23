using Shinkarev_Dmitriy_Task19.Data.Interfaces;
using Shinkarev_Dmitriy_Task19.Data.Models;
using Shinkarev_Dmitriy_Task19.Data.Repository;
using System.Collections.Generic;
using System.Linq;

namespace Shinkarev_Dmitriy_Task19.Data.mocks
{
    public class AllUsersImplementation : IAllUsers
    {
        readonly UserDAO userDAO;
        readonly UserRewardsDAO userRewardsDAO;
        public AllUsersImplementation()
        {
            userDAO = new UserDAO();
            userRewardsDAO = new UserRewardsDAO();
        }
        public IEnumerable<User> AllUsers
        {
            get
            {
                var result = userDAO.GetAllUsers();
                foreach (var user in result)
                {
                    user.Rewards = userRewardsDAO.GetRewardsForConcretUser(user.Id);
                }
                return result;
            }        
        }

        public User GetUserById(int userId)
        {
            var user = userDAO.GetAllUsers()
                .Where(x => x.Id == userId)
                .FirstOrDefault();
            user.Rewards = userRewardsDAO.GetRewardsForConcretUser(userId);
            return user;
        }

        public void AddUserAndSetId(User user)
        {
            userDAO.AddUserAndSetID(user);
        }

        public void ChangeUser(User user)
        {
            
            userDAO.ChangeUser(user);
        }

        public void RemoveUser(int userId)
        {
            var rewards = userRewardsDAO.GetRewardsForConcretUser(userId);
            foreach (var reward in rewards)
            {
                userRewardsDAO.RemoveUserReward(userId, reward.Id);
            }
            userDAO.RemoveUser(userId);
        }

        public void RemoveRevardFromUser(int userId, int rewardId)
        {
            userRewardsDAO.RemoveUserReward(userId, rewardId);
        }     

        public void RewardUser(int userId, int rewardId)
        {
            userRewardsDAO.AddUserReward(userId, rewardId);
        }

        public void RewardUser(int userId, List<Reward> rewards)
        {
            foreach (var reward in rewards)
            {
                userRewardsDAO.AddUserReward(userId, reward.Id);
            }
        }
    }
}
