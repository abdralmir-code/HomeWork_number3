using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace HomeWork_3
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Logger logger = new Logger("log.txt");
            List<INotificationService> services = new List<INotificationService>();
            services.Add(new EmailService(logger));
            services.Add(new SmsService(logger));
            services.Add(new PushNotificationService(logger));
            MainForm form = new MainForm(services, logger);
            Application.Run(form);
        }
    }
}
