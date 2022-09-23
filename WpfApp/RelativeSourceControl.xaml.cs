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

namespace WpfApp
{
    /// <summary>
    /// RelativeSourceControl.xaml 的交互逻辑
    /// </summary>
    public partial class RelativeSourceControl : UserControl
    {
        public RelativeSourceControl()
        {
            InitializeComponent();

            //RelativeSource relativeSource = new RelativeSource(RelativeSourceMode.FindAncestor);
            //relativeSource.AncestorLevel = 1;
            //relativeSource.AncestorType = typeof(Grid);

            //Binding binding = new Binding("Name") { RelativeSource = relativeSource };
            //this.textBox1.SetBinding(TextBox.TextProperty, binding);
        }
    }
}
