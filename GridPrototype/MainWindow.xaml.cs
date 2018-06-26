using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using GridPrototype.Annotations;

namespace GridPrototype
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public TestViewModel ViewModel { get; set; } = new TestViewModel();
    }

    public class TestViewModel : INotifyPropertyChanged
    {
        private double _value = 100;
        private string _stringValue = "Alberto";
        public event PropertyChangedEventHandler PropertyChanged;

        public double Value
        {
            get => _value;
            set
            {
                if (value.Equals(_value))
                {
                    return;
                }

                _value = value;
                OnPropertyChanged();
            }
        }

        public string StringValue
        {
            get => _stringValue;
            set
            {
                if (value == _stringValue) return;
                _stringValue = value;
                OnPropertyChanged();
            }
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
