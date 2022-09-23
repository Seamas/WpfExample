using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfTemplateApp
{
    /// <summary>
    /// PathButton.xaml 的交互逻辑
    /// </summary>
    public partial class PathButton : Button
    {
        public Geometry PathData
        {
            get { return (Geometry)GetValue(PathDataProperty); }
            set { SetValue(PathDataProperty, value); }
        }

        public static readonly DependencyProperty PathDataProperty =
             DependencyProperty.Register("PathData", typeof(Geometry), typeof(PathButton), new PropertyMetadata(new PathGeometry()));

        public Brush DefaultFillBrush
        {
            get { return (Brush)GetValue(DefaultFillBrushProperty); }
            set { SetValue(DefaultFillBrushProperty, value); }
        }

        public static readonly DependencyProperty DefaultFillBrushProperty =
             DependencyProperty.Register("DefaultFillBrush", typeof(Brush), typeof(PathButton), new PropertyMetadata(Brushes.DarkGray));

        public Brush MouseOverBrush
        {
            get { return (Brush)GetValue(MouseOverBrushProperty); }
            set { SetValue(MouseOverBrushProperty, value); }
        }

        public static readonly DependencyProperty MouseOverBrushProperty =
             DependencyProperty.Register("MouseOverBrush", typeof(Brush), typeof(PathButton), new PropertyMetadata(Brushes.DeepSkyBlue));

        public Brush IsPressedBrush
        {
            get { return (Brush)GetValue(IsPressedBrushProperty); }
            set { SetValue(IsPressedBrushProperty, value); }
        }

        public static readonly DependencyProperty IsPressedBrushProperty =
             DependencyProperty.Register("IsPressedBrush", typeof(Brush), typeof(PathButton), new PropertyMetadata(Brushes.DodgerBlue));

        public Brush IsEnabledBrush
        {
            get { return (Brush)GetValue(IsEnabledBrushProperty); }
            set { SetValue(IsEnabledBrushProperty, value); }
        }

        public static readonly DependencyProperty IsEnabledBrushProperty =
             DependencyProperty.Register("IsEnabledBrush", typeof(Brush), typeof(PathButton), new PropertyMetadata(Brushes.LightGray));

        public PathButton()
        {
            InitializeComponent();
            DataContext = this;
        }
    }
}
