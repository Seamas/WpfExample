using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfDepApp
{
    public class Person
    {

        public static readonly RoutedEvent NameChangedEvent = EventManager.RegisterRoutedEvent("NameChanged", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(Person));

        public static void AddNameChangedHandler(DependencyObject dp, RoutedEventHandler handler)
        {
            var e = dp as UIElement;
            if (e != null)
            {
                e.AddHandler(Person.NameChangedEvent, handler);
            }
        }

        public static void RemoveNameChangedHandler(DependencyObject dp, RoutedEventHandler handler)
        {
            var e = dp as UIElement;
            if (e != null)
            {
                e.RemoveHandler(Person.NameChangedEvent, handler);
            }
        }


        public string Name { get; set; }
        public int Id { get;set; }
    }
}
