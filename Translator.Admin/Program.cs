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
        private static Container container;
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
            Application.Run(container.GetInstance<MainForm>());
        }
        private static void Bootstrap()
        {
            // Create the container as usual.
            container = new Container();

            // Register your types, for instance:
            container.Register<TranslatorContext>(Lifestyle.Singleton);
            container.Register<IDictionaryService, DictionaryService>(Lifestyle.Singleton);
            container.Register<IFieldService, FieldService>(Lifestyle.Singleton);
            container.Register<ITypeService, TypeService>(Lifestyle.Singleton);
            container.Register<IExcelService, ExcelService>(Lifestyle.Singleton);
            container.Register<ITxtService, TxtService>(Lifestyle.Singleton);
            container.Register<MainForm>(Lifestyle.Singleton);

            // Optionally verify the container.
            container.Verify();
        }
    }
}
