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

namespace WpfDepApp
{
    /// <summary>
    /// RouteEventControl.xaml 的交互逻辑
    /// </summary>
    public partial class RouteEventControl : UserControl
    {
        public RouteEventControl()
        {
            InitializeComponent();
            //this.gridRoot.AddHandler(Button.ClickEvent, new RoutedEventHandler(this.ButtonClicked));
        }

        public void ButtonClicked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show((e.OriginalSource as FrameworkElement)?.Name);
        }

        private void gridRoot_ReportTime(object sender, ReportTimeEventArgs e)
        {
            var element = sender as FrameworkElement;

            MessageBox.Show($"{element?.Name}, {e.ClickTime}");

            if (element == this.gridRoot)
            {
                e.Handled = true;
            }
        }
    }
}
