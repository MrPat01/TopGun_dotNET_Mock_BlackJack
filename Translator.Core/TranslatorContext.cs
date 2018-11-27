namespace Translator.Core
{
    using System.Data.Entity;
    using Models;

    public class TranslatorContext : DbContext
    {
        public TranslatorContext()
            : base("name=TranslatorContext")
        {

        }

        public virtual DbSet<ConfigPath> ConfigPath { get; set; }
        public virtual DbSet<Dictionary> Dictionary { get; set; }
        public virtual DbSet<Field> Field { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Type> Type { get; set; }
        public virtual DbSet<TranslateFail> TranslateFail { get; set; }
    }
}