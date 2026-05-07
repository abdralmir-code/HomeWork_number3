namespace HomeWork_3
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_message = new System.Windows.Forms.Label();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.labelMessageType = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.listBoxLogs = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label_message
            // 
            this.label_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_message.Location = new System.Drawing.Point(250, 27);
            this.label_message.Name = "label_message";
            this.label_message.Size = new System.Drawing.Size(174, 40);
            this.label_message.TabIndex = 0;
            this.label_message.Text = "Сообщение:";
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMessage.Location = new System.Drawing.Point(255, 70);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(222, 34);
            this.textBoxMessage.TabIndex = 1;
            // 
            // labelMessageType
            // 
            this.labelMessageType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessageType.Location = new System.Drawing.Point(250, 136);
            this.labelMessageType.Name = "labelMessageType";
            this.labelMessageType.Size = new System.Drawing.Size(195, 44);
            this.labelMessageType.TabIndex = 2;
            this.labelMessageType.Text = "Тип уведомления:";
            // 
            // comboBoxType
            // 
            this.comboBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(255, 183);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(222, 37);
            this.comboBoxType.TabIndex = 3;
            // 
            // buttonSend
            // 
            this.buttonSend.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.buttonSend.FlatAppearance.BorderSize = 2;
            this.buttonSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSend.Location = new System.Drawing.Point(220, 239);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(284, 81);
            this.buttonSend.TabIndex = 4;
            this.buttonSend.Text = "Отправить уведомление";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // listBoxLogs
            // 
            this.listBoxLogs.FormattingEnabled = true;
            this.listBoxLogs.ItemHeight = 16;
            this.listBoxLogs.Location = new System.Drawing.Point(220, 344);
            this.listBoxLogs.Name = "listBoxLogs";
            this.listBoxLogs.Size = new System.Drawing.Size(284, 84);
            this.listBoxLogs.TabIndex = 5;
            this.listBoxLogs.SelectedIndexChanged += new System.EventHandler(this.listBoxLogs_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxLogs);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.labelMessageType);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.label_message);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_message;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Label labelMessageType;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.ListBox listBoxLogs;
    }
}

