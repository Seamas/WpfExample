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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitialCarLsit();
        }

        private void InitialCarLsit()
        {
            var carList = new List<Car>
            {
                new Car { Automaker="Lamborghini", Name="Diablo", Year="1990", TopSpeed="340" },
                new Car { Automaker="Lamborghini", Name="Gallardo", Year="2003", TopSpeed="325" }
            };

            carList.ForEach(item =>
            {
                var view = new CarListView
                {
                    Car = item
                };
                this.listBoxCars.Items.Add(view);
            });
        }


        private void listBoxCars_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var view = e.AddedItems[0] as CarListView;
            this.detailView.Car = view?.Car;
        }
    }
}
