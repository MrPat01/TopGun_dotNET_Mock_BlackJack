using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleInjector;
using Translator.Core;
using Translator.Core.IServices;
using Translator.Core.Services;

namespace Translator.Admin
{
    static class Program
    {
        public static Container container;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Bootstrap();
            Application.Run(container.GetInstance<MainForm>());
            //Application.Run(new MainForm());
        }

        private static void Bootstrap()
        {
            // Create the container as usual.
            container = new Container();

            // Register your types, for instance:
            container.Register<TranslatorContext>(Lifestyle.Singleton);
            container.Register(typeof(IRepository<>), typeof(Repository<>), Lifestyle.Singleton);
            container.Register<IFieldService, FieldService>(Lifestyle.Singleton);
            
            container.Register<MainForm>(Lifestyle.Singleton);

            // Optionally verify the container.
            container.Verify();
        }
    }
}
