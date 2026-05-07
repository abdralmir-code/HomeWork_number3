using System;
namespace HomeWork_3
{
    internal class SmsService : INotificationService
    {
        private Logger _logger;
        public SmsService(Logger logger)
        {
            _logger = logger;
        }
        public string ServiceName
        {
            get { return "SMS Service"; }
        }
        public void Send(string message)
        {
            _logger.Log("SmsService: начинаем отправку");
            Random random = new Random();
            int chance = random.Next(1, 6);
            if (chance == 1)
            {
                throw new Exception("Ошибка отправки SMS");
            }
        }
    }
}
