using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp
{
    public class Calculator
    {
        public string Add(string s1, string s2)
        {
            if (int.TryParse(s1, out int a) && int.TryParse(s2, out int b))
            {
                return (a + b).ToString();
            }
            return "Input Error";
        }
    }
}
