using System;

namespace Entities
{
    public class PrizeVO
    {
        private int _id;
        private string _name;
        private string _description;

        public int Id { get => _id; }
        public string Name { get => _name; }
        public string Description { get => _description; }

        public PrizeVO(int id, string name, string description)
        {
            _id = id;
            _name = name;
            _description = description;
        }

        public PrizeVO(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public void SetId(int id)
        {
            if (_id == default)
            {
                _id = id;
            }
        }
        public override string ToString()
        {
            return _name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_id, _name, _description);
        }

        public override bool Equals(object obj)
        {
            if (GetHashCode() != obj.GetHashCode())
            {
                return false;
            }

            PrizeVO objectToCompare = (PrizeVO)obj;

            if (objectToCompare == null)
            {
                return false;
            }

            if (_id == objectToCompare.Id &&
                _name.Equals(objectToCompare.Name) &&
                _description.Equals(objectToCompare.Description))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
