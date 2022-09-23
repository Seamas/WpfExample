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
    /// MyControl.xaml 的交互逻辑
    /// </summary>
    public partial class MyControl : UserControl
    {
        public MyControl()
        {
            InitializeComponent();
            this.Loaded+=MyControl_Loaded;
        }

        private void MyControl_Loaded(object sender, RoutedEventArgs e)
        {
            // 不能在xml里面直接引用window的资源,
            // 因为控件在初始化之前不能确定在哪个window里面,获取不到对应的key值,
            // 但可以在Loaded事件中去查找window的资源
            var s = (string)FindResource("wStr");
            tb2.Text = s;
        }
    }
}
