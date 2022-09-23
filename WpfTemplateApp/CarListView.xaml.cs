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
    /// CarListView.xaml 的交互逻辑
    /// </summary>
    public partial class CarListView : UserControl
    {
        public CarListView()
        {
            InitializeComponent();
        }

        private Car car;

        public Car Car
        {
            get => car;
            set
            {
                car = value;
                this.txblockName.Text = car?.Name;
                this.txblockYear.Text = car?.Year;
                string uri = string.Format(@"Resources/Logo/{0}.jpg", Car.Automaker);
                var img = new BitmapImage(new Uri(uri, UriKind.Relative));
                this.imageLogo.Source = img;
            }
        }
    }
}
