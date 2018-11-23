using Translator.Core.Common;

namespace Translator.Core
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using Translator.Core.Models;

    public class TranslatorContext : DbContext
    {
        // Your context has been configured to use a 'TranslatorContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Translator.Core.TranslatorContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'TranslatorContext' 
        // connection string in the application configuration file.
        //public TranslatorContext()
        //    : base(Utility.GetConnectionString())
        //{
        //    //this.Database.Connection.ConnectionString = ;
        //}

        public TranslatorContext()
            : base("name=TranslatorContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<ConfigPath> ConfigPath { get; set; }
        public virtual DbSet<Dictionary> Dictionary { get; set; }
        public virtual DbSet<Field> Field { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Models.Type> Type { get; set; }
        


    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}