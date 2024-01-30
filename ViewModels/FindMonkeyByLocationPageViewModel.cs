using MonkeysMVVM.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
namespace MonkeysMVVM.ViewModels
{
    public class FindMonkeyByLocationPageViewModel:ViewModel
    {
        private string country;
        private int count;
        public int Count { get { return count; } set { count = value; OnPropertyChanged(); ((Command)SearchByCountryCommand).ChangeCanExecute(); } }
        public string Country { get { return country; } set {  country = value; OnPropertyChanged(); } }

        public ICommand SearchByCountryCommand { get; set; }
        private Monkey monkey;
        public string Name { get { return monkey.Name; }  }

        public string ImageUrl { get { return monkey.ImageUrl; } }

        public FindMonkeyByLocationPageViewModel()
        {
            monkey = new Monkey() { Name="אין קופים כרגע"};
            SearchByCountryCommand = new Command(FindMonkeys,()=>Country!=null);
        }
        
        private void FindMonkeys()
        {

        }

        
    }
}
