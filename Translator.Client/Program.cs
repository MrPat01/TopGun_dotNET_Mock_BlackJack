using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleInjector;
using Translator.Core;
using Translator.Core.Common;
using Translator.Core.IServices;
using Translator.Core.Services;

namespace Translator.Client
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
            Bootstrap();
            Application.Run(container.GetInstance<Client>());
            //Application.Run(new Client());
        }

        private static void Bootstrap()
        {
            // Create the container as usual.
            container = new Container();

            // Register your types, for instance:
            container.Register<TranslatorContext>(Lifestyle.Singleton);
            container.Register<IDictionaryService, DictionaryService>(Lifestyle.Singleton);
            container.Register<ITypeService, TypeService>(Lifestyle.Singleton);
            container.Register<IExcelService, ExcelService>(Lifestyle.Singleton);
            container.Register<ITxtService, TxtService>(Lifestyle.Singleton);
            container.Register<Client>(Lifestyle.Singleton);

            // Optionally verify the container.
            container.Verify();
        }
    }
}
