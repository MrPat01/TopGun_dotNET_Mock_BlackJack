using System.Data.Entity;
using System.IO;
using System.Linq;

namespace Translator.Core
{
    public class TranslatorInitializer : DropCreateDatabaseIfModelChanges<TranslatorContext>
    {
        protected override void Seed(TranslatorContext context)
        {
            var sampleDataFolder = new DirectoryInfo(Directory.GetCurrentDirectory()).Parent?.Parent?.Parent?.FullName +
                                   @"\Translator.Core\Data\";

            var categoriesFile = sampleDataFolder + "Categories.sql";
            var configPathsFile = sampleDataFolder + "ConfigPaths.sql";
            var dictionariesFile = sampleDataFolder + "Dictionaries.sql";
            var fieldsFile = sampleDataFolder + "Fields.sql";
            var typesFile = sampleDataFolder + "Types.sql";

            if (!context.Category.Any() && File.Exists(categoriesFile))
                context.Database.ExecuteSqlCommand(File.ReadAllText(categoriesFile));

            if (!context.ConfigPath.Any() && File.Exists(configPathsFile))
                context.Database.ExecuteSqlCommand(File.ReadAllText(configPathsFile));
            
            if (!context.Field.Any() && File.Exists(fieldsFile))
                context.Database.ExecuteSqlCommand(File.ReadAllText(fieldsFile));

            if (!context.Type.Any() && File.Exists(typesFile))
                context.Database.ExecuteSqlCommand(File.ReadAllText(typesFile));

            if (!context.Dictionary.Any() && File.Exists(dictionariesFile))
                context.Database.ExecuteSqlCommand(File.ReadAllText(dictionariesFile));

            base.Seed(context);
        }
    }
}