using SimpleInjector;
using System;
using System.Windows.Forms;
using Translator.Core;
using Translator.Core.IServices;
using Translator.Core.Services;

namespace Translator.Admin
{
    static class Program
    {
        public static Container Container;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainForm());
            Bootstrap();
            Application.Run(Container.GetInstance<MainForm>());
        }
        private static void Bootstrap()
        {
            // Create the container as usual.
            Container = new Container();

            // Register your types, for instance:
            Container.Register<TranslatorContext>(Lifestyle.Singleton);
            Container.Register(typeof(IRepository<>), typeof(Repository<>), Lifestyle.Singleton);
            Container.Register<ICategoryService, CategoryService>(Lifestyle.Singleton);
            Container.Register<ITranslateFailService, TranslateFailService>(Lifestyle.Singleton);
            Container.Register<IDictionaryService, DictionaryService>(Lifestyle.Singleton);
            Container.Register<IFieldService, FieldService>(Lifestyle.Singleton);
            Container.Register<ITypeService, TypeService>(Lifestyle.Singleton);
            Container.Register<IExcelService, ExcelService>(Lifestyle.Singleton);
            Container.Register<ITxtService, TxtService>(Lifestyle.Singleton);
            Container.Register<MainForm>(Lifestyle.Singleton);

            // Optionally verify the container.
            Container.Verify();
        }
    }
}
