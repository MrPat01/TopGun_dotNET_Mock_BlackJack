using Translator.Core.Common;

namespace Translator.Core.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TranslatorContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TranslatorContext context)
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

            if (context.Field.Count() == 0)
            {
                context.Field.Add(new Field { Name = "Jp", Type = EnumType.String});
                context.Field.Add(new Field { Name = "Vn", Type = EnumType.String });
                context.Field.Add(new Field { Name = "JpLength", Type = EnumType.Int });
                context.Field.Add(new Field { Name = "VnLength", Type = EnumType.Int });
                context.Field.Add(new Field { Name = "CategoryId", Type = EnumType.Int });
                context.Field.Add(new Field { Name = "Priority", Type = EnumType.Int });
                context.Field.Add(new Field { Name = "TypeId", Type = EnumType.Int });
                context.Field.Add(new Field { Name = "DictionaryTypeId", Type = EnumType.Int });
                context.Field.Add(new Field { Name = "Date", Type = EnumType.Date });
                context.Field.Add(new Field { Name = "Inputer", Type = EnumType.String });

                context.SaveChanges();
            }

            if (context.Category.Count() == 0)
            {
                context.Category.Add(new Category { Name = "Common" });
                context.Category.Add(new Category { Name = "Kanji" });
                context.SaveChanges();
            }

            if (context.Type.Count() == 0)
            {
                context.Type.Add(new Type { Name = "JP -> VN" });
                context.Type.Add(new Type { Name = "VN -> JP" });
            }
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
