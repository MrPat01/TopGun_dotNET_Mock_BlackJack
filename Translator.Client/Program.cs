using System;
using System.Windows.Forms;
using SimpleInjector;
using Translator.Core;
using Translator.Core.IServices;
using Translator.Core.Services;

namespace Translator.Client
{
    static class Program
    {
        private static Container _container;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Bootstrap();
            Application.Run(_container.GetInstance<Client>());
            //Application.Run(new Client());
        }

        private static void Bootstrap()
        {
            // Create the container as usual.
            _container = new Container();

            // Register your types, for instance:
            _container.Register<TranslatorContext>(Lifestyle.Singleton);
            _container.Register<ITranslateFailService, TranslateFailService>(Lifestyle.Singleton);
            _container.Register<IDictionaryService, DictionaryService>(Lifestyle.Singleton);
            _container.Register<ITypeService, TypeService>(Lifestyle.Singleton);
            _container.Register<IExcelService, ExcelService>(Lifestyle.Singleton);
            _container.Register<ITxtService, TxtService>(Lifestyle.Singleton);
            _container.Register<Client>(Lifestyle.Singleton);

            // Optionally verify the container.
            _container.Verify();
        }
    }
}
