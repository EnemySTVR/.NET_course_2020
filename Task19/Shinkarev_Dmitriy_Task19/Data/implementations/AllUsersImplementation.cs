using Shinkarev_Dmitriy_Task19.Data.interfaces;
using Shinkarev_Dmitriy_Task19.Data.Models;
using Shinkarev_Dmitriy_Task19.Data.Repository;
using System;
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
        public List<User> AllUsers
        {
            get
            {
                var result = userDAO.AllUsers;
                foreach (var user in result)
                {
                    user.Rewards = userRewardsDAO.GetRewardsForConcretUser(user.Id);
                }
                return result;
            }        
        }

        public User GetUserById(int userId)
        {
            var user = userDAO.AllUsers
                .Where(x => x.Id == userId)
                .FirstOrDefault();
            user.Rewards = userRewardsDAO.GetRewardsForConcretUser(userId);
            return user;
        }

        public void AddUserAndSetId(string firstName, string lastName, DateTime birthDate, List<Reward> rewards)
        {
            var user = new User()
            {
                FirstName = firstName,
                LastName = lastName,
                BirthDate = birthDate
            };
            userDAO.AddUserAndSetID(user);
            RewardUser(user.Id, rewards);
        }

        public void ChangeUser(int id, string newFirstName, string newLastName, DateTime newBirthDate, List<Reward> rewards)
        {
            var user = userDAO.AllUsers
                .Where(x => x.Id == id)
                .FirstOrDefault();
            user.FirstName = newFirstName;
            user.LastName = newLastName;
            user.BirthDate = newBirthDate;
            user.Rewards = userRewardsDAO.GetRewardsForConcretUser(id);

            foreach (var reward in rewards)
            {
                if (!user.Rewards.Contains(reward))
                {
                    userRewardsDAO.AddUserReward(user.Id, reward.Id);
                }
            }
            foreach (var prize in user.Rewards)
            {
                if (!rewards.Contains(prize))
                {
                    userRewardsDAO.RemoveUserReward(user.Id, prize.Id);
                }
            }
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
