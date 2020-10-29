using Shinkarev_Dmitriy_Task19.Data.Models;
using System;
using System.Collections.Generic;

namespace Shinkarev_Dmitriy_Task19.Data.interfaces
{
    public interface IAllUsers
    {
        List<User> AllUsers { get; }
        User GetUserById(int userId);
        void AddUserAndSetId(string firstName, string lastName, DateTime birthDate, List<Reward> rewards);
        void ChangeUser(int id, string newFirstName, string newLastName, DateTime newBirthDate, List<Reward> rewards);
        void RemoveUser(int userId);
        void RewardUser(int userId, int rewardId);
        void RewardUser(int userId, List<Reward> rewards);
        void RemoveRevardFromUser(int userId, int rewardId);
    }
}
