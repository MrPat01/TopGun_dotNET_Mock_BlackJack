using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Translator.Core;
using Translator.Core.IServices;
using Translator.Core.Services;

namespace Translator.Server
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
            //Application.Run(new Server());
            Bootstrap();
            Application.Run(container.GetInstance<Server>());
        }
        private static void Bootstrap()
        {
            // Create the container as usual.
            container = new Container();

            // Register your types, for instance:
            container.Register<TranslatorContext>(Lifestyle.Singleton);
            container.Register<IConfigPathService, ConfigPathService>(Lifestyle.Singleton);
            container.Register<Server>(Lifestyle.Singleton);

            // Optionally verify the container.
            container.Verify();
        }
    }
}
