using System.Windows;
using System.Windows.Controls;

namespace GridPrototype
{
    public class SonovaItemsControl : ItemsControl
    {
        public Orientation Orientation
        {
            get => (Orientation)GetValue(OrientationProperty);
            set => SetValue(OrientationProperty, value);
        }

        // Using a DependencyProperty as the backing store for Orientation.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OrientationProperty = DependencyProperty.Register("Orientation", typeof(Orientation), typeof(SonovaItemsControl), new PropertyMetadata(Orientation.Horizontal));
    }
}