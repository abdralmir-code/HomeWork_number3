using System;
using System.IO;
namespace HomeWork_3
{
    public class Logger
    {
        private string _filePath;
        public Logger(string filePath)
        {
            _filePath = filePath;
        }
        public void Log(string message)
        {
            string line = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss") + " | " + message;
            File.AppendAllText(_filePath, line + Environment.NewLine);
        }
        public void LogError(string message)
        {
            string line = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss") + " | ОШИБКА: " + message;
            File.AppendAllText(_filePath, line + Environment.NewLine);
        }
    }
}
