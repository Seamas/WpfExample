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

namespace WpfResApp
{
    /// <summary>
    /// DyControl.xaml 的交互逻辑
    /// </summary>
    public partial class DyControl : UserControl
    {
        public DyControl()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["res1"] = new TextBlock() { Text = "Hello" };
            this.Resources["res2"] = new TextBlock() { Text = "World" };
        }
    }
}
