using Shinkarev_Dmitriy_Task19.Data.Models;
using System.Collections.Generic;

namespace Shinkarev_Dmitriy_Task19.Data.interfaces
{
    public interface IAllRewards
    {
        List<Reward> AllRewards { get; }
        Reward GetRewardById(int rewardId);
        void AddRewardAndSetId(string name, string description);
        void ChangeReward(int id, string newName, string newDescription);
        void RemoveReward(int id);
    }
}
