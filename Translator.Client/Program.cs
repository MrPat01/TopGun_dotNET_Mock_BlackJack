using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleInjector;
using Translator.Core.Common;

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
            Application.Run(container.GetInstance<Client>());
            //Application.Run(new Client());
        }

        private static void Bootstrap()
        {
            // Create the container as usual.
            container = new Container();

            // Register your types, for instance:
            //container.Register<IUserRepository, SqlUserRepository>(Lifestyle.Singleton);
            //container.Register<IUserContext, WinFormsUserContext>();
            container.Register<Client>();

            // Optionally verify the container.
            container.Verify();
        }
    }
}
