using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR5WPF.Models
{
    public class Breakfast
    {
        public string MainCourse {  get; set; }
        public string Drink { get; set; }

        public Breakfast(string main, string drink)
        {
            MainCourse = main;
            Drink = drink;
        }
        public Breakfast()
        {
            
        }
    }
}
