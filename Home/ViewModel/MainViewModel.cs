using System;
using GalaSoft.MvvmLight;
using Home.Model.Entity;

namespace Home.ViewModel
{
  
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            AddToDatabase();

        }

        private void AddToDatabase()
        {
            using (EconomyContext context = new EconomyContext())
            {
                Bill bill = new Bill() { id = 2, date = DateTime.Now, money = 733, name = "market", quantity = 2 };
                context.Bills.Add(bill);
                context.SaveChanges();
            }
        }
    }
}