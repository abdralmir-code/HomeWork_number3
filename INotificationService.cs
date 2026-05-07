using System;
namespace HomeWork_3
{
    public interface INotificationService
    {
        string ServiceName { get; }
        void Send(string message);
    }
}
