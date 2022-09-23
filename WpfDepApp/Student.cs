using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace WpfDepApp
{
    public class Student :DependencyObject
    {
        #region 依赖属性
        public string Name
        {
            get { return (string)GetValue(NameProperty); }
            set { SetValue(NameProperty, value); }
        }


        public static readonly DependencyProperty NameProperty = DependencyProperty.Register(nameof(Name), typeof(string), typeof(Student));

        #endregion

        public BindingExpressionBase SetBinding(DependencyProperty dp, BindingBase bindingBase)
        {
            return BindingOperations.SetBinding(this, dp, bindingBase);
        }


        #region 附属属性
        public static int GetGrade(DependencyObject obj)
        {
            return (int)obj.GetValue(GradeProperty);
        }

        public static void SetGrade(DependencyObject obj, int value)
        {
            obj.SetValue(GradeProperty, value);
        }

        public static readonly DependencyProperty GradeProperty = DependencyProperty.RegisterAttached("Grade", typeof(int), typeof(Student), new UIPropertyMetadata());
        #endregion
    }
}
