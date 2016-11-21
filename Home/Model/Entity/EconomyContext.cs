namespace Home.Model.Entity
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class EconomyContext : DbContext
    {
       
        public EconomyContext()
            : base(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\zavia\Desktop\C#Projects\Wpf\Home\Model\Database\HomeEconomy.mdf;Integrated Security=True")
        {
        }

       

       public virtual DbSet<Bill> Bills { get; set; }
    }

}