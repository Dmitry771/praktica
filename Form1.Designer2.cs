namespace server
{
    partial class Form1
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
            this.but_connect = new System.Windows.Forms.Button();
            this.tb_mes_from_client = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_IP_serv = new System.Windows.Forms.TextBox();
            this.tb_host_serv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_status = new System.Windows.Forms.TextBox();
            this.tb_clientFilesSaving = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.but_changeDirFiles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // but_connect
            // 
            this.but_connect.Location = new System.Drawing.Point(332, 137);
            this.but_connect.Name = "but_connect";
            this.but_connect.Size = new System.Drawing.Size(144, 23);
            this.but_connect.TabIndex = 0;
            this.but_connect.Text = "Начать прослушивание";
            this.but_connect.UseVisualStyleBackColor = true;
            this.but_connect.Click += new System.EventHandler(this.but_connect_Click);
            // 
            // tb_mes_from_client
            // 
            this.tb_mes_from_client.Location = new System.Drawing.Point(102, 73);
            this.tb_mes_from_client.Name = "tb_mes_from_client";
            this.tb_mes_from_client.Size = new System.Drawing.Size(121, 20);
            this.tb_mes_from_client.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Полученное от клиента сообщение";
            // 
            // tb_IP_serv
            // 
            this.tb_IP_serv.Location = new System.Drawing.Point(376, 47);
            this.tb_IP_serv.Name = "tb_IP_serv";
            this.tb_IP_serv.Size = new System.Drawing.Size(100, 20);
            this.tb_IP_serv.TabIndex = 3;
            // 
            // tb_host_serv
            // 
            this.tb_host_serv.Location = new System.Drawing.Point(376, 92);
            this.tb_host_serv.Name = "tb_host_serv";
            this.tb_host_serv.Size = new System.Drawing.Size(100, 20);
            this.tb_host_serv.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "IP сервера";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Хост сервера";
            // 
            // tb_status
            // 
            this.tb_status.Location = new System.Drawing.Point(28, 153);
            this.tb_status.Multiline = true;
            this.tb_status.Name = "tb_status";
            this.tb_status.Size = new System.Drawing.Size(141, 44);
            this.tb_status.TabIndex = 7;
            // 
            // tb_clientFilesSaving
            // 
            this.tb_clientFilesSaving.Location = new System.Drawing.Point(305, 208);
            this.tb_clientFilesSaving.Name = "tb_clientFilesSaving";
            this.tb_clientFilesSaving.Size = new System.Drawing.Size(171, 20);
            this.tb_clientFilesSaving.TabIndex = 8;
            this.tb_clientFilesSaving.TextChanged += new System.EventHandler(this.tb_clientFilesSaving_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Каталог для сохранения";
            // 
            // but_changeDirFiles
            // 
            this.but_changeDirFiles.Location = new System.Drawing.Point(482, 208);
            this.but_changeDirFiles.Name = "but_changeDirFiles";
            this.but_changeDirFiles.Size = new System.Drawing.Size(75, 23);
            this.but_changeDirFiles.TabIndex = 10;
            this.but_changeDirFiles.Text = "Выбрать";
            this.but_changeDirFiles.UseVisualStyleBackColor = true;
            this.but_changeDirFiles.Click += new System.EventHandler(this.but_changeDirFiles_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 259);
            this.Controls.Add(this.but_changeDirFiles);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_clientFilesSaving);
            this.Controls.Add(this.tb_status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_host_serv);
            this.Controls.Add(this.tb_IP_serv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_mes_from_client);
            this.Controls.Add(this.but_connect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_connect;
        private System.Windows.Forms.TextBox tb_mes_from_client;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_IP_serv;
        private System.Windows.Forms.TextBox tb_host_serv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_status;
        private System.Windows.Forms.TextBox tb_clientFilesSaving;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button but_changeDirFiles;
    }
}

