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
    /// HumanControl.xaml 的交互逻辑
    /// </summary>
    public partial class HumanControl : UserControl
    {
        public HumanControl()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var human = new Human();
            Student.SetGrade(human, 3);

            var grade = Student.GetGrade(human);
            MessageBox.Show(grade.ToString());
        }
    }
}
