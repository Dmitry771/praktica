namespace client
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
            this.tb_mes = new System.Windows.Forms.TextBox();
            this.tb_ip_adr = new System.Windows.Forms.TextBox();
            this.leb_mes = new System.Windows.Forms.Label();
            this.leb_IP = new System.Windows.Forms.Label();
            this.but_sendmes = new System.Windows.Forms.Button();
            this.tb_hostname = new System.Windows.Forms.TextBox();
            this.leb_hostname = new System.Windows.Forms.Label();
            this.ip_servers_list = new System.Windows.Forms.ComboBox();
            this.leb_ip_serv = new System.Windows.Forms.Label();
            this.but_ip_server_add = new System.Windows.Forms.Button();
            this.list_files = new System.Windows.Forms.ListBox();
            this.lab_list_files = new System.Windows.Forms.Label();
            this.lab_actions = new System.Windows.Forms.Label();
            this.actions_list = new System.Windows.Forms.ComboBox();
            this.but_select_cat = new System.Windows.Forms.Button();
            this.tb_select_cat = new System.Windows.Forms.TextBox();
            this.lab_select_cat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_mes
            // 
            this.tb_mes.Location = new System.Drawing.Point(86, 48);
            this.tb_mes.Name = "tb_mes";
            this.tb_mes.Size = new System.Drawing.Size(100, 20);
            this.tb_mes.TabIndex = 1;
            // 
            // tb_ip_adr
            // 
            this.tb_ip_adr.Location = new System.Drawing.Point(431, 33);
            this.tb_ip_adr.Name = "tb_ip_adr";
            this.tb_ip_adr.Size = new System.Drawing.Size(100, 20);
            this.tb_ip_adr.TabIndex = 2;
            // 
            // leb_mes
            // 
            this.leb_mes.AutoSize = true;
            this.leb_mes.Location = new System.Drawing.Point(97, 21);
            this.leb_mes.Name = "leb_mes";
            this.leb_mes.Size = new System.Drawing.Size(65, 13);
            this.leb_mes.TabIndex = 3;
            this.leb_mes.Text = "Сообщение";
            // 
            // leb_IP
            // 
            this.leb_IP.AutoSize = true;
            this.leb_IP.Location = new System.Drawing.Point(437, 9);
            this.leb_IP.Name = "leb_IP";
            this.leb_IP.Size = new System.Drawing.Size(83, 13);
            this.leb_IP.TabIndex = 4;
            this.leb_IP.Text = "IP компьютера";
            // 
            // but_sendmes
            // 
            this.but_sendmes.Location = new System.Drawing.Point(71, 84);
            this.but_sendmes.Name = "but_sendmes";
            this.but_sendmes.Size = new System.Drawing.Size(129, 35);
            this.but_sendmes.TabIndex = 5;
            this.but_sendmes.Text = "Отправить сообщение на сервер";
            this.but_sendmes.UseVisualStyleBackColor = true;
            this.but_sendmes.Click += new System.EventHandler(this.but_sendmes_Click);
            // 
            // tb_hostname
            // 
            this.tb_hostname.Location = new System.Drawing.Point(431, 73);
            this.tb_hostname.Name = "tb_hostname";
            this.tb_hostname.Size = new System.Drawing.Size(100, 20);
            this.tb_hostname.TabIndex = 6;
            // 
            // leb_hostname
            // 
            this.leb_hostname.AutoSize = true;
            this.leb_hostname.Location = new System.Drawing.Point(454, 55);
            this.leb_hostname.Name = "leb_hostname";
            this.leb_hostname.Size = new System.Drawing.Size(34, 13);
            this.leb_hostname.TabIndex = 7;
            this.leb_hostname.Text = "Хост ";
            // 
            // ip_servers_list
            // 
            this.ip_servers_list.FormattingEnabled = true;
            this.ip_servers_list.Items.AddRange(new object[] {
            "192.168.1.5",
            "127.0.0.1"});
            this.ip_servers_list.Location = new System.Drawing.Point(245, 47);
            this.ip_servers_list.Name = "ip_servers_list";
            this.ip_servers_list.Size = new System.Drawing.Size(121, 21);
            this.ip_servers_list.TabIndex = 8;
            // 
            // leb_ip_serv
            // 
            this.leb_ip_serv.AutoSize = true;
            this.leb_ip_serv.Location = new System.Drawing.Point(242, 21);
            this.leb_ip_serv.Name = "leb_ip_serv";
            this.leb_ip_serv.Size = new System.Drawing.Size(109, 13);
            this.leb_ip_serv.TabIndex = 9;
            this.leb_ip_serv.Text = "Выбрать IP сервера";
            // 
            // but_ip_server_add
            // 
            this.but_ip_server_add.Location = new System.Drawing.Point(245, 84);
            this.but_ip_server_add.Name = "but_ip_server_add";
            this.but_ip_server_add.Size = new System.Drawing.Size(121, 35);
            this.but_ip_server_add.TabIndex = 10;
            this.but_ip_server_add.Text = "Добавить IP сервера";
            this.but_ip_server_add.UseVisualStyleBackColor = true;
            this.but_ip_server_add.Click += new System.EventHandler(this.but_ip_server_add_Click);
            // 
            // list_files
            // 
            this.list_files.FormattingEnabled = true;
            this.list_files.Location = new System.Drawing.Point(71, 154);
            this.list_files.Name = "list_files";
            this.list_files.Size = new System.Drawing.Size(198, 186);
            this.list_files.TabIndex = 11;
            this.list_files.SelectedIndexChanged += new System.EventHandler(this.list_files_SelectedIndexChanged);
            // 
            // lab_list_files
            // 
            this.lab_list_files.AutoSize = true;
            this.lab_list_files.Location = new System.Drawing.Point(83, 140);
            this.lab_list_files.Name = "lab_list_files";
            this.lab_list_files.Size = new System.Drawing.Size(148, 13);
            this.lab_list_files.TabIndex = 12;
            this.lab_list_files.Text = "Список файлов на сервере:";
            // 
            // lab_actions
            // 
            this.lab_actions.AutoSize = true;
            this.lab_actions.Location = new System.Drawing.Point(355, 193);
            this.lab_actions.Name = "lab_actions";
            this.lab_actions.Size = new System.Drawing.Size(101, 13);
            this.lab_actions.TabIndex = 13;
            this.lab_actions.Text = "Выбрать действие";
            // 
            // actions_list
            // 
            this.actions_list.FormattingEnabled = true;
            this.actions_list.Items.AddRange(new object[] {
            "Получить список файлов",
            "Отправить на сервер файл",
            "Загрузить файл с сервера"});
            this.actions_list.Location = new System.Drawing.Point(358, 209);
            this.actions_list.Name = "actions_list";
            this.actions_list.Size = new System.Drawing.Size(162, 21);
            this.actions_list.TabIndex = 14;
            this.actions_list.SelectedIndexChanged += new System.EventHandler(this.actions_list_SelectedIndexChanged);
            // 
            // but_select_cat
            // 
            this.but_select_cat.Location = new System.Drawing.Point(496, 317);
            this.but_select_cat.Name = "but_select_cat";
            this.but_select_cat.Size = new System.Drawing.Size(75, 23);
            this.but_select_cat.TabIndex = 15;
            this.but_select_cat.Text = "Выбрать";
            this.but_select_cat.UseVisualStyleBackColor = true;
            this.but_select_cat.Click += new System.EventHandler(this.but_select_cat_Click);
            // 
            // tb_select_cat
            // 
            this.tb_select_cat.Location = new System.Drawing.Point(297, 319);
            this.tb_select_cat.Name = "tb_select_cat";
            this.tb_select_cat.Size = new System.Drawing.Size(193, 20);
            this.tb_select_cat.TabIndex = 16;
            this.tb_select_cat.TextChanged += new System.EventHandler(this.tb_select_cat_TextChanged);
            // 
            // lab_select_cat
            // 
            this.lab_select_cat.AutoSize = true;
            this.lab_select_cat.Location = new System.Drawing.Point(311, 303);
            this.lab_select_cat.Name = "lab_select_cat";
            this.lab_select_cat.Size = new System.Drawing.Size(131, 13);
            this.lab_select_cat.TabIndex = 17;
            this.lab_select_cat.Text = "Каталог для сохранения";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 355);
            this.Controls.Add(this.lab_select_cat);
            this.Controls.Add(this.tb_select_cat);
            this.Controls.Add(this.but_select_cat);
            this.Controls.Add(this.actions_list);
            this.Controls.Add(this.lab_actions);
            this.Controls.Add(this.lab_list_files);
            this.Controls.Add(this.list_files);
            this.Controls.Add(this.but_ip_server_add);
            this.Controls.Add(this.leb_ip_serv);
            this.Controls.Add(this.ip_servers_list);
            this.Controls.Add(this.leb_hostname);
            this.Controls.Add(this.tb_hostname);
            this.Controls.Add(this.but_sendmes);
            this.Controls.Add(this.leb_IP);
            this.Controls.Add(this.leb_mes);
            this.Controls.Add(this.tb_ip_adr);
            this.Controls.Add(this.tb_mes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

      
        private System.Windows.Forms.TextBox tb_mes;
        private System.Windows.Forms.TextBox tb_ip_adr;
        private System.Windows.Forms.Label leb_mes;
        private System.Windows.Forms.Label leb_IP;
        private System.Windows.Forms.Button but_sendmes;
        private System.Windows.Forms.TextBox tb_hostname;
        private System.Windows.Forms.Label leb_hostname;
        private System.Windows.Forms.ComboBox ip_servers_list;
        private System.Windows.Forms.Label leb_ip_serv;
        private System.Windows.Forms.Button but_ip_server_add;
        private System.Windows.Forms.ListBox list_files;
        private System.Windows.Forms.Label lab_list_files;
        private System.Windows.Forms.Label lab_actions;
        private System.Windows.Forms.ComboBox actions_list;
        private System.Windows.Forms.Button but_select_cat;
        private System.Windows.Forms.TextBox tb_select_cat;
        private System.Windows.Forms.Label lab_select_cat;
    }
}

