using SimpleInjector;
using System;
using System.Windows.Forms;
using Translator.Core;
using Translator.Core.IServices;
using Translator.Core.Services;

namespace Translator.Server
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
            Application.Run(_container.GetInstance<Server>());
        }
        private static void Bootstrap()
        {
            // Create the container as usual.
            _container = new Container();

            // Register your types, for instance:
            _container.Register<TranslatorContext>(Lifestyle.Singleton);
            _container.Register<IConfigPathService, ConfigPathService>(Lifestyle.Singleton);
            _container.Register<Server>(Lifestyle.Singleton);

            // Optionally verify the container.
            _container.Verify();
        }
    }
}
