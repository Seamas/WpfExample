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
using System.Xml;

namespace WpfApp
{
    /// <summary>
    /// XmlControl.xaml 的交互逻辑
    /// </summary>
    public partial class XmlControl : UserControl
    {
        public XmlControl()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("./Student.xml");

            XmlDataProvider xdp = new XmlDataProvider();
            xdp.Document = doc;
            // 可以不使用 Document, 直接使用 Source
            //xdp.Source = new Uri("/Student.xml");

            xdp.XPath = "/StudentList/Student";

            this.listView.DataContext = xdp;
            this.listView.SetBinding(ListView.ItemsSourceProperty, new Binding());
        }
    }
}
