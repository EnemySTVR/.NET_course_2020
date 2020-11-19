using Shinkarev_Dmitriy_Task19.Data.Models;
using System.Collections.Generic;

namespace Shinkarev_Dmitriy_Task19.Data.Interfaces
{
    public interface IAllRewards
    {
        List<Reward> AllRewards { get; }
        Reward GetRewardById(int rewardId);
        void AddRewardAndSetId(Reward reward);
        void ChangeReward(Reward reward);
        void RemoveReward(int id);
        List<Reward> GetRewardsForConcretUser(int userId);
    }
}
