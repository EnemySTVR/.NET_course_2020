using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Task1
{
    public class User : INotifyPropertyChanged
    {
        private static int _idGenerator = 0;
        private int _id;
        private string _firstName;
        private string _lastName;
        private DateTime _birthDate;
        private BindingList<Prize> _userPrizes = new BindingList<Prize>();

        public event PropertyChangedEventHandler PropertyChanged;

        public string Id { get => _id.ToString(); }
        public string FirstName { get => _firstName; }
        public string LastName { get => _lastName; }
        public DateTime BirthDate { get => _birthDate.Date; }
        public BindingList<Prize> Prizes { get => _userPrizes; }
        public string Age
        {
            get
            {
                if (DateTime.Now.DayOfYear < _birthDate.DayOfYear)
                {
                    return ( DateTime.Now.Year - _birthDate.Year - 1).ToString() + " years old";
                }
                else 
                {
                    return (DateTime.Now.Year - _birthDate.Year).ToString() + " years old";
                }
            }
        }

        public User(string firstName, string lastName, DateTime birthDate)
        {
            _idGenerator++;
            _id = _idGenerator;
            _firstName = firstName;
            _lastName = lastName;
            _birthDate = birthDate;
        }

        public void ChangeFirstName(string firstName)
        {
            _firstName = firstName;
            OnPropertyChanged("FirstName");
        }

        public void ChangeLastName(string lastName)
        {
            _lastName = lastName;
            OnPropertyChanged("LasttName");
        }

        public void ChangeBirthDate(DateTime birthDate)
        {
            _birthDate = birthDate;
            OnPropertyChanged("BirthDate");
        }

        public void AddPrize(Prize prize)
        {
            if (!_userPrizes.Contains(prize))
            {
                _userPrizes.Add(prize);
                OnPropertyChanged("Prizes");
            }
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_id, _firstName, _lastName, _birthDate);
        }

        public override bool Equals(object obj)
        {
            return GetHashCode() == obj.GetHashCode();
        }

        private void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
