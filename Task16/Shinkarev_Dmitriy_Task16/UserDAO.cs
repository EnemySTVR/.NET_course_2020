using Entities;
using System;
using System.Collections.ObjectModel;

namespace DAL
{
    public class UserDAO
    {
        public ReadOnlyCollection<UserVO> GetDataSource()
        {
            return new ReadOnlyCollection<UserVO>(Repository.GetAllUsers());
        }

        public void AddAndSetId(UserVO user)
        {
            Repository.AddUserAndSetID(user);
        }

        public void Remove(UserVO user)
        {
            Repository.RemoveUser(user.Id);
        }

        public void ChangeUser(UserVO changedUser, string firstName, string lastName, DateTime birthDate)
        {
            var user = new UserVO(changedUser.Id, firstName, lastName, birthDate, changedUser.Prizes);
            Repository.ChangeUser(user);
        }

        public void AddRevard(UserVO user, PrizeVO prize)
        {
            Repository.AddUserPrize(user, prize);
        }

        public void RemoveRevardLink(UserVO user, PrizeVO prize)
        {
            Repository.RemoveUserPrize(user, prize);
        }
    }
}
