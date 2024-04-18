using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR5WPF.Models
{
    public class Dinner
    {
        public string MainCourse {  get; set; }
        public string Drink { get; set; }
        public string Desert { get; set; }

        public Dinner(string main, string drink, string desert)
        {
            MainCourse = main;
            Drink = drink;
            Desert = desert;
        }
        public Dinner()
        {
            
        }
    }
}
