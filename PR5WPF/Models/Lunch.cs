using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR5WPF.Models
{
    public class Lunch
    {
        public string MainCourse {  get; set; }
        public string SubCourse { get; set; }
        public string Salad { get; set; }
        public string Drink { get; set; }

        public Lunch(string main, string sub, string salad, string drink)
        {
            MainCourse = main;
            SubCourse = sub;
            Salad = salad;
            Drink = drink;
        }
        public Lunch()
        {
            
        }
    }
}
