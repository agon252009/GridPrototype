using System.Windows;
using System.Windows.Controls;

namespace GridPrototype
{
    
    public class SonovaGridCell : Control
    {
        public ControlTemplate SonovaGridCellTemplate
        {
            get => (ControlTemplate)GetValue(SonovaGridCellTemplateProperty);
            set => SetValue(SonovaGridCellTemplateProperty, value);
        }

        // Using a DependencyProperty as the backing store for CellTemplate.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SonovaGridCellTemplateProperty = DependencyProperty.Register("SonovaGridCellTemplate", typeof(ControlTemplate), typeof(SonovaGridCell), new PropertyMetadata(null));
        
        static SonovaGridCell()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SonovaGridCell), new FrameworkPropertyMetadata(typeof(SonovaGridCell)));
        }
    }
}
