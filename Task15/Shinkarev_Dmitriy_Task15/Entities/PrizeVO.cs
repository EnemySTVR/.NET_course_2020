using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Entities
{
    public class PrizeVO : INotifyPropertyChanged
    {
        private int _id;
        private string _name;
        private string _description;

        public event PropertyChangedEventHandler PropertyChanged;

        public int Id { get => _id; }
        public string Name { get => _name; }
        public string Description { get => _description; }

        public PrizeVO(int id, string name, string description)
        {
            _id = id;
            _name = name;
            _description = description;
        }

        public void ChangeName(string name)
        {
            _name = name;
            OnPropertyChanged("Name");
        }

        public void ChangeDescription(string description)
        {
            _description = description;
            OnPropertyChanged("Description");
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

        private void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
