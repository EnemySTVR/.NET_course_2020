using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Entities
{
    public class UserVO : INotifyPropertyChanged
    {
        private int _id;
        private string _firstName;
        private string _lastName;
        private DateTime _birthDate;
        private BindingList<PrizeVO> _userPrizes;

        public event PropertyChangedEventHandler PropertyChanged;

        public int Id { get => _id; }
        public string FirstName { get => _firstName; }
        public string LastName { get => _lastName; }
        public DateTime BirthDate { get => _birthDate.Date; }
        public BindingList<PrizeVO> Prizes { get => _userPrizes; }
        public int Age
        {
            get
            {
                if (DateTime.Now.DayOfYear < _birthDate.DayOfYear)
                {
                    return DateTime.Now.Year - _birthDate.Year - 1;
                }
                else
                {
                    return DateTime.Now.Year - _birthDate.Year;
                }
            }
        }

        public UserVO(int id, string firstName, string lastName, DateTime birthDate, IList<PrizeVO> prizes)
        {
            _id = id;
            _firstName = firstName;
            _lastName = lastName;
            _birthDate = birthDate;
            _userPrizes = new BindingList<PrizeVO>(prizes);
        }

        public UserVO(int id, string firstName, string lastName, DateTime birthDate)
        {
            _id = id;
            _firstName = firstName;
            _lastName = lastName;
            _birthDate = birthDate;
            _userPrizes = new BindingList<PrizeVO>();
        }

        public UserVO(string firstName, string lastName, DateTime birthDate, IList<PrizeVO> prizes)
        {
            _firstName = firstName;
            _lastName = lastName;
            _birthDate = birthDate;
            _userPrizes = new BindingList<PrizeVO>(prizes);
        }

        public void SetId(int id)
        {
            if (_id == default)
            {
                _id = id;
            }
        }

        public void AddPrize(PrizeVO prize)
        {
            if (!_userPrizes.Contains(prize))
            {
                _userPrizes.Add(prize);
                OnPropertyChanged("Prizes");
            }
        }

        public void RemovePrize(PrizeVO prize)
        {
            if (_userPrizes.Contains(prize))
            {
                _userPrizes.Remove(prize);
                OnPropertyChanged("Prizes");
            }
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_id, _firstName, _lastName, _birthDate);
        }

        public override bool Equals(object obj)
        {
            if (GetHashCode() != obj.GetHashCode())
            {
                return false;
            }

            UserVO objectToCompare = (UserVO)obj;

            if (objectToCompare == null)
            {
                return false;
            }

            if (_id == objectToCompare.Id &&
                FirstName.Equals(objectToCompare.FirstName) &&
                LastName.Equals(objectToCompare.LastName) &&
                BirthDate.Equals(objectToCompare.BirthDate) &&
                Prizes.Equals(objectToCompare.Prizes) &&
                Age == objectToCompare.Age)
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
