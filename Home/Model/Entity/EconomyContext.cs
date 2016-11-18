namespace Home.Model.Entity
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class EconomyContext : DbContext
    {
       
        public EconomyContext()
            : base("name=EconomyContext")
        {
        }

       

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

}