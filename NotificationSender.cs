using System;
namespace HomeWork_3
{
    internal class NotificationSender
    {
        private INotificationService _service;
        public NotificationSender(INotificationService service)
        {
            _service = service;
        }
        public void Send(string message)
        {
            _service.Send(message);
        }
    }
}
