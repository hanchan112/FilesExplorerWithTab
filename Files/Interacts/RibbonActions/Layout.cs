using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Files.Interacts.Layout
{
    public class LayoutItemsState : INotifyPropertyChanged
    {
        public bool _isEnabled;
        public bool isEnabled
        {
            get
            {
                return _isEnabled;
            }

            set
            {
                if (value != _isEnabled)
                {
                    _isEnabled = value;
                    NotifyPropertyChanged("isEnabled");
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}