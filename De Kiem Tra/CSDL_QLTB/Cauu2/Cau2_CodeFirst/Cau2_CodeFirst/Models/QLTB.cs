namespace Cau2_CodeFirst.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class QLTB : DbContext
    {
        // Your context has been configured to use a 'QLTB' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Cau2_CodeFirst.Models.QLTB' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'QLTB' 
        // connection string in the application configuration file.
        public QLTB()
            : base("name=QLTB")
        {
        }
        public DbSet<Loaithietbi> loai { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}