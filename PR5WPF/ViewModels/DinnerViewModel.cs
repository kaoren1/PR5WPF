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
    internal class DinnerViewModel : BindingHelper
    {
        private Dinner selected = new Dinner();
        #region Команды
        public DinnerHelper AddComand { get; set; }
        #endregion

        public Dinner Selected
        {
            get { return selected; }
            set
            {
                selected = value;
                OnPropertyChanged();
            }
        }
        private ObservableCollection<Dinner> dinner;
        public ObservableCollection<Dinner> Dinner
        {
            get { return dinner; }
            set
            {
                dinner = value;
                OnPropertyChanged();
            }
        }
        public DinnerViewModel()
        {
            Dinner = new ObservableCollection<Dinner>()
            {
                new Dinner("Борщ", "Тархун", "Винигрет"),
                new Dinner("Пюре", "Дюшес", "Цезарь")
            };
            AddComand = new DinnerHelper(_ => AddD());
        }
        public void AddD()
        {
            Dinner.Add(new Dinner(Selected.MainCourse, Selected.Drink, Selected.Desert));
        }
    }
}
