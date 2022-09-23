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
    /// DataProviderControl.xaml 的交互逻辑
    /// </summary>
    public partial class DataProviderControl : UserControl
    {
        public DataProviderControl()
        {
            InitializeComponent();
            this.SetBinding();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            //ObjectDataProvider provider = new ObjectDataProvider();
            //provider.ObjectInstance = new Calculator();

            //provider.MethodName = "Add";
            //provider.MethodParameters.Add(s1.Text);
            //provider.MethodParameters.Add(s2.Text);

            //result.Text = provider.Data.ToString();
        }

        private void SetBinding()
        {
            ObjectDataProvider provider = new ObjectDataProvider();
            provider.ObjectInstance = new Calculator();

            provider.MethodName = "Add";
            provider.MethodParameters.Add("0");
            provider.MethodParameters.Add("1");

            Binding binding1 = new Binding("MethodParameters[0]")
            {
                Source = provider,
                BindsDirectlyToSource = true,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
            };

            Binding binding2 = new Binding("MethodParameters[1]")
            {
                Source = provider,
                BindsDirectlyToSource = true,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
            };

            Binding result = new Binding(".") { Source = provider };
            s1.SetBinding(TextBox.TextProperty, binding1);
            s2.SetBinding(TextBox.TextProperty, binding2);
            this.result.SetBinding(TextBox.TextProperty, result);
            
        }
    }
}
