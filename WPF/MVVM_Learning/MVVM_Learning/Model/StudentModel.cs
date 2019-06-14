using System.ComponentModel;

namespace MVVM_Learning.Model
{
    public class Student : INotifyPropertyChanged
    {
        
        private string _FirstName;
        private string _LastName;
        public string FirstName
        {
            get
            {
                return _FirstName;
            }

            set
            {
                if (_FirstName != value)
                {
                    _FirstName = value;
                    RaisePropertyChanged("FirstName");
                    RaisePropertyChanged("FullName");
                }
            }
        }

        public string LastName
        {
            get { return _LastName; }

            set
            {
                if (_LastName != value)
                {
                    _LastName = value;
                    RaisePropertyChanged("LastName");
                    RaisePropertyChanged("FullName");
                }
            }
        }

        public string FullName
        {
            get
            {
                return _FirstName + " " + _LastName;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
