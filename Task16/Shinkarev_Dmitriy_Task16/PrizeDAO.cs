using Entities;
using System.Collections.ObjectModel;

namespace DAL
{
    public class PrizeDAO
    {
        public ReadOnlyCollection<PrizeVO> GetDataSource()
        {
            return new ReadOnlyCollection<PrizeVO>(Repository.GetAllPrizes());
        }

        public void AddAndSetId(PrizeVO prize)
        {
            Repository.AddPrizeAndSetID(prize);
        }

        public void Remove(PrizeVO prize)
        {
            Repository.RemovePrize(prize.Id);
        }

        public void ChangePrize(PrizeVO changedPrize, string name, string description)
        {
            var prize = new PrizeVO(changedPrize.Id, name, description);
            Repository.ChangePrize(prize);
        }
    }
}
