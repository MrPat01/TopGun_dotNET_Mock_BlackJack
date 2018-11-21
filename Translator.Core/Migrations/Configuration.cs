namespace Translator.Core.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Translator.Core.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Translator.Core.TranslatorContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Translator.Core.TranslatorContext context)
        {
            if (context.ConfigPath.Count() == 0)
            {
                context.ConfigPath.Add(new ConfigPath
                {
                    Name = "VN2JPInput",
                    Path = @"C:\Translator\VN to JP\Input",
                });
                context.ConfigPath.Add(new ConfigPath
                {
                    Name = "VN2JPOutput",
                    Path = @"C:\Translator\VN to JP\Output",
                });
                context.ConfigPath.Add(new ConfigPath
                {
                    Name = "VN2JPBackUp",
                    Path = @"C:\Translator\VN to JP\BackUp",
                });
                context.ConfigPath.Add(new ConfigPath
                {
                    Name = "VN2JPError",
                    Path = @"C:\Translator\VN to JP\Error",
                });


                context.ConfigPath.Add(new ConfigPath
                {
                    Name = "JP2VNInput",
                    Path = @"C:\Translator\JP to VN\Input",
                });
                context.ConfigPath.Add(new ConfigPath
                {
                    Name = "JP2VNOutput",
                    Path = @"C:\Translator\JP to VN\Output",
                });
                context.ConfigPath.Add(new ConfigPath
                {
                    Name = "JP2VNBackUp",
                    Path = @"C:\Translator\JP to VN\BackUp",
                });
                context.ConfigPath.Add(new ConfigPath
                {
                    Name = "JP2VNError",
                    Path = @"C:\Translator\JP to VN\Error",
                });

                context.SaveChanges();
            }
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
