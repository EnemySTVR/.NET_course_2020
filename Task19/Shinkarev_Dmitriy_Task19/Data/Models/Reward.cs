using System.Collections.Generic;

namespace Shinkarev_Dmitriy_Task19.Data.Models
{
    public class Reward
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<User> Users { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            return ((Reward)obj).Id == Id;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
