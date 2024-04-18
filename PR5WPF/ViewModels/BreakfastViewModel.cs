using PR5WPF.Models;
using PR5WPF.ViewModels.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace PR5WPF.ViewModels
{
    internal class BreakfastViewModel : BindingHelper
    {
        private Breakfast selected;

        #region Команды
        public BreakfastHelper AddComand { get; set; }
        #endregion
        public Breakfast Selected
        {
            get { return selected; }
            set
            {
                selected = value;
                OnPropertyChanged();
            }
        }
        private ObservableCollection<Breakfast> breakfasts; 
        public ObservableCollection<Breakfast> Breakfasts
        {
            get { return breakfasts; }
            set
            {
                breakfasts = value;
                OnPropertyChanged();
            }
        }
        public BreakfastViewModel()
        {
            Breakfasts = new ObservableCollection<Breakfast>()
            {
                new Breakfast("Яичница", "Чай"),
                new Breakfast("Бутер", "Чай")
            };
            AddComand = new BreakfastHelper(_ => AddB());
        }
        public void AddB()
        {
            if (Selected != null)
            {
                Breakfasts.Add(new Breakfast(Selected.MainCourse, Selected.Drink));
            }
        }

    }
}
