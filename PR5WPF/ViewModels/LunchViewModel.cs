using PR5WPF.Models;
using PR5WPF.ViewModels.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR5WPF.ViewModels
{
    internal class LunchViewModel : BindingHelper
    {
        private Lunch selected;

        #region Команды
        public LunchHelper AddComand { get; set; }
        #endregion
        public Lunch Selected
        {
            get { return selected; }
            set
            {
                selected = value;
                OnPropertyChanged();
            }
        }
        private ObservableCollection<Lunch> lunch;
        public ObservableCollection<Lunch> Lunch
        {
            get { return lunch; }
            set
            {
                lunch = value;
                OnPropertyChanged();
            }
        }
        public LunchViewModel()
        {
            Lunch = new ObservableCollection<Lunch>()
            {
                new Lunch("Макароны", "Что-то", "да", "нет")
            };
            AddComand = new LunchHelper(_ => AddL());
        }
        public void AddL()
        {
            Lunch.Add(new Lunch(Selected.MainCourse, Selected.SubCourse, Selected.Salad, Selected.Drink));
        }
    }
}
