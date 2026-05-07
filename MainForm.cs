using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace HomeWork_3
{
    public partial class MainForm : Form
    {
        private List<INotificationService> _services;
        private Logger _logger;
        public MainForm(List<INotificationService> services, Logger logger)
        {
            InitializeComponent();
            _services = services;
            _logger = logger;
            for (int i = 0; i < _services.Count; i++)
            {
                comboBoxType.Items.Add(_services[i].ServiceName);
            }
            comboBoxType.SelectedIndex = 0;
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            string message = textBoxMessage.Text;
            if (message == string.Empty || message == null)
            {
                MessageBox.Show("Сообщение не может быть пустым!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _logger.LogError("Попытка отправить пустое сообщение");
                AddLog("ОШИБКА: пустое сообщение");
                return;
            }
            int selectedIndex = comboBoxType.SelectedIndex;
            INotificationService selectedService = _services[selectedIndex];
            NotificationSender notificationSender = new NotificationSender(selectedService);
            try
            {
                if (message.ToLower() == "привет")
                {
                    MessageBox.Show("Привет! Я Док, поздравляю ты нашёл пасхалку", "Пасхалка", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    AddLog("Пользователь нашёл пасхалку!");
                    _logger.Log("Пасхалка активирована");
                    return;
                }

                notificationSender.Send(message);
                notificationSender.Send(message);
                string logMessage = "Отправлено через " + selectedService.ServiceName + ": " + message;
                _logger.Log(logMessage);
                AddLog(logMessage);
                MessageBox.Show("Уведомление отправлено!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                string errorMessage = "Ошибка при отправке через " + selectedService.ServiceName + ": " + ex.Message;
                _logger.LogError(errorMessage);
                AddLog("ОШИБКА: " + errorMessage);
                MessageBox.Show("Не удалось отправить: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AddLog(string message)
        {
            string line = DateTime.Now.ToString("HH:mm:ss") + " | " + message;
            listBoxLogs.Items.Add(line);
            listBoxLogs.SelectedIndex = listBoxLogs.Items.Count - 1;
            listBoxLogs.SelectedIndex = -1;
        }

        private void listBoxLogs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}