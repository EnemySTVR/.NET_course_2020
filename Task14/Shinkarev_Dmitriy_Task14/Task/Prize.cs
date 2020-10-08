using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Task
{
    public class Prize : INotifyPropertyChanged
    {
        private static int _idGenerator = 0;
        private int _id;
        private string _name;
        private string _description;

        public event PropertyChangedEventHandler PropertyChanged;

        public int Id { get => _id; }
        public string Name { get => _name; }
        public string Description { get => _description; }

        public Prize(string name, string description)
        {
            _idGenerator++;
            _id = _idGenerator;
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
            return GetHashCode() == obj.GetHashCode();
        }

        private void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
