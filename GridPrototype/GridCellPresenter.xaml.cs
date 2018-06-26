using System.Collections.ObjectModel;
using System.Windows;

namespace GridPrototype
{
    /// <summary>
    /// Interaction logic for GridCellPresenter.xaml
    /// </summary>
    public partial class GridCellPresenter
    {
        public ObservableCollection<SonovaGridCell> Cells
        {
            get => (ObservableCollection<SonovaGridCell>)GetValue(MyPropertyProperty);
            set => SetValue(MyPropertyProperty, value);
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyPropertyProperty = DependencyProperty.Register("MyProperty", typeof(ObservableCollection<SonovaGridCell>), typeof(GridCellPresenter), new PropertyMetadata(new ObservableCollection<SonovaGridCell>()));

        public GridCellPresenter()
        {
            InitializeComponent();
        }
    }
}
