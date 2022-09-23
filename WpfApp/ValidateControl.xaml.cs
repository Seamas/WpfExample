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
    /// ValidateControl.xaml 的交互逻辑
    /// </summary>
    public partial class ValidateControl : UserControl
    {
        public ValidateControl()
        {
            InitializeComponent();

            this.txb.AddHandler(Validation.ErrorEvent, new RoutedEventHandler(this.ValidationError));
        }

        void ValidationError(object sender, RoutedEventArgs e)
        {
            if (Validation.GetErrors(this.txb).Count > 0)
            {
                this.txb.ToolTip = Validation.GetErrors(this.txb)[0].ErrorContent.ToString();
            }
        }
    }
}
