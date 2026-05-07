using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3
{
    internal class EmailService : INotificationService
    {
        private Logger _logger;
        public EmailService(Logger logger)
        {
            _logger = logger;
        }
        public string ServiceName
        {
            get { return "Email Service";}
        }
        public void Send(string message)
        {
            _logger.Log("EmailService: начинаем отправку");
            Random random = new Random();
            int chance = random.Next(1, 6);
            if (chance == 1)
            {
                throw new Exception("Ошибка подключения к почтовому серверу");
            }
        }
    }
}
