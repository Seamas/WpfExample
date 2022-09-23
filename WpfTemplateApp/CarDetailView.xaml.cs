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
    /// CarDetailView.xaml 的交互逻辑
    /// </summary>
    public partial class CarDetailView : UserControl
    {
        public CarDetailView()
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
                this.txblockAutomaker.Text = car?.Automaker;
                this.txblockTopSpeed.Text = car?.TopSpeed;
                
                var img = GetImage(Car.Name);
                this.imagePhoto.Source = img;
            }
        }

        private Dictionary<string, BitmapImage> dict = new Dictionary<string, BitmapImage>();
        private BitmapImage GetImage(string name)
        {
            if (!dict.ContainsKey(name))
            {
                string uri = string.Format(@"Resources/Images/{0}.jpg", name);
                var img = new BitmapImage(new Uri(uri, UriKind.Relative));
                dict[name] = img;
            }
            return dict[name];
        }
    }
}
