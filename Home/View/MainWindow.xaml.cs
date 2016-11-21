using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Home.Model.Entity;

namespace Home
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            using (EconomyContext context = new EconomyContext())
            {
                Bill bill = new Bill() { id = 1, date = DateTime.Now, money = 733, name = "market", quantity = 2 };
                context.Bills.Add(bill);
                context.SaveChanges();
            }
            InitializeComponent();
        }
    }
}
