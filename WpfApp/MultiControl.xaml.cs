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
    /// MultiControl.xaml 的交互逻辑
    /// </summary>
    public partial class MultiControl : UserControl
    {
        public MultiControl()
        {
            InitializeComponent();
            SetMultiBiding();
        }

        private void SetMultiBiding()
        {
            Binding b1 = new Binding("Text") { Source = txb1 };
            Binding b2 = new Binding("Text") { Source = txb2 };
            Binding b3 = new Binding("Text") { Source = txb3 };
            Binding b4 = new Binding("Text") { Source = txb4 };

            MultiBinding multi = new MultiBinding() { Mode = BindingMode.OneWay };
            multi.Bindings.Add(b1);
            multi.Bindings.Add(b2);
            multi.Bindings.Add(b3);
            multi.Bindings.Add(b4);

            multi.Converter = new LogonMultiBindingConverter();
            this.btn.SetBinding(Button.IsEnabledProperty, multi);
        }
    }
}
