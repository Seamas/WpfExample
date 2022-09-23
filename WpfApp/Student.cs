using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp
{
    public class Student: INotifyPropertyChanged
    {
        private string name;
        private int age;

        public string Name 
        { 
            get { return name; }
            set 
            {
                name = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            } 
        }
        public int Age 
        {
            get { return age; } 
            set 
            { 
                age = value; 
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Age")); 
            } 
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public override string ToString()
        {
            return $"{{Name: { Name}, Age: {Age} }}";
        }
    }
}
