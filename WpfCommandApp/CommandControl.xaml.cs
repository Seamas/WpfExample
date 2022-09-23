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

namespace WpfCommandApp
{
    /// <summary>
    /// CommandControl.xaml 的交互逻辑
    /// </summary>
    public partial class CommandControl : UserControl
    {
        public CommandControl()
        {
            InitializeComponent();
            InitializeCommand();
        }

        private RoutedCommand clearCmd = new RoutedCommand("Clear", typeof(CommandControl));

        private void InitializeCommand()
        {
            btn1.Command = clearCmd;
            clearCmd.InputGestures.Add(new KeyGesture(Key.C, ModifierKeys.Alt));

            btn1.CommandTarget = txb1;

            CommandBinding cb = new CommandBinding();
            cb.Command = this.clearCmd;
            cb.CanExecute += Cb_CanExecute;
            cb.Executed +=Cb_Executed;

            this.stackPanel.CommandBindings.Add(cb);
        }

        private void Cb_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.txb1.Clear();
            e.Handled = true;
        }

        private void Cb_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb1.Text))
            {
                e.CanExecute = false;
            } 
            else
            {
                e.CanExecute = true;
            }
            e.Handled = true;
        }

        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                e.CanExecute = false;
            }
            else
            {
                e.CanExecute = true;
            }
            e.Handled = true;
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var name = nameTextBox.Text;
            if (e.Parameter.ToString() == "Teacher")
            {
                this.listBoxItems.Items.Add($"New Teacher: {name}");
            }
            else if (e.Parameter.ToString() == "Student")
            {
                this.listBoxItems.Items.Add($"New Student: {name}");
            }

            e.Handled = true;
        }
    }
}
