using System;
namespace HomeWork_3
{
    internal class PushNotificationService : INotificationService
    {
        private Logger _logger;
        public PushNotificationService(Logger logger)
        {
            _logger = logger;
        }
        public string ServiceName
        {
            get { return "Push Notification Service"; }
        }
        public void Send(string message)
        {
            _logger.Log("PushNotificationService: начинаем отправку");
            Random random = new Random();
            int chance = random.Next(1, 6);
            if (chance == 1)
            {
                throw new Exception("Ошибка отправки push-уведомления");
            }
        }
    }
}
