using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace client
{
    public partial class Form1 : Form
    {
     
         int port = 8005; // порт сервера
        string address;// = "127.0.0.1"; // адрес сервера
     
        
        string fileNameForSending = string.Empty;//хранит имя и путь к файлу который передаётся
        byte[] data_for_send = new byte[10000];//хранит данные для передачи
        string working_directory;


        public Form1()
        {
            InitializeComponent();
            tb_hostname.Text = System.Net.Dns.GetHostName();
            tb_ip_adr.Text = System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName()).AddressList[0].ToString();
            working_directory = "filedir";
            tb_select_cat.Text = "filedir";
            tb_mes.Text = "";

        }
        public void sendMessage(string action = null)
        {
            address = ip_servers_list.Text;
            try
            {
                IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse(address), port);

                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                // подключаемся к удаленному хосту
                socket.Connect(ipPoint);
                //Console.Write("Введите сообщение:");
                string message;
                if (action == null)
                {
                    if ((tb_mes.Text == null) || (tb_mes.Text == ""))
                        message = "<Пустое сообщение>";
                    else
                         message = "send_text_message$"+ tb_mes.Text;//Console.ReadLine();
                    data_for_send = Encoding.Unicode.GetBytes(message);
                }
                else
                {
                    message = "action$" + action;
                    data_for_send = Encoding.Unicode.GetBytes(message);
                }
                if(action == "get_file")
                {
                    string file = list_files.SelectedItem.ToString();
                    message += "$" +file;
                    data_for_send = Encoding.Unicode.GetBytes(message);
                }
                if(action == "send_file_name")
                {
                    // OpenFileDialog openFile = new OpenFileDialog();
                    string[] list = fileNameForSending.Split('\\');
                    message += "$" + list[list.Length-1];
                  //  fileNameForSending = openFile.FileName;
                    data_for_send = Encoding.Unicode.GetBytes(message);
                }
                if (action == "send_file_data")
                {
                    data_for_send = File.ReadAllBytes(fileNameForSending);
                    fileNameForSending = "";
                }
                byte[] data = data_for_send;//Encoding.Unicode.GetBytes(message);
                socket.Send(data);

                // получаем ответ
                data = new byte[10000]; // буфер для ответа
                StringBuilder builder = new StringBuilder();
                int bytes = 0; // количество полученных байт

                do
                {
                    bytes = socket.Receive(data, data.Length, 0);
                    builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                }
                while (socket.Available > 0);
                if ((action == null)||(action == "send_file_name")||(action == "send_file_data"))
                    MessageBox.Show("Ответ сервера - " + builder.ToString());
                else
                    parse_message(builder, action, data);

                // закрываем сокет
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }
          
        }
        void send_file()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                //string[] list = openFile.FileName.Split('\\');
                fileNameForSending = openFile.FileName;
               // data_for_send = File.ReadAllBytes(openFile.FileName);
                sendMessage("send_file_name");
                sendMessage("send_file_data");
            }

        }
        private string selected_file()
        {
            string f = list_files.SelectedItem.ToString();
            string[] list = f.Split('\\');



            return list[list.Length-1];
        }
        private void parse_message(StringBuilder answer, string action, byte[] data)
        {
            try
            {
                switch (action)
                {
                    case "get_folders_list":
                        string content = answer.ToString();
                        string[] files = content.Split('|');
                        list_files.Items.Clear();
                        for (int i = 0; i < files.Length; i++)
                            list_files.Items.Add(files[i]);
                        break;
                    case "get_file":
                        string file_name = working_directory + '\\' + list_files.SelectedItem.ToString();// selected_file();
                        FileInfo info;
                        if (!File.Exists(file_name))
                        {
                            info = new FileInfo(file_name);
                            info.Create().Close();

                        }
                        File.WriteAllBytes(file_name, data);
                        MessageBox.Show("Файл с сервера получен");
                        break;

                }
            }
            catch(Exception w) { MessageBox.Show(w.Message); }
            
        }
        private void but_sendmes_Click(object sender, EventArgs e)
        {
            // readder = new Thread(reading);
            //readder.Start();
            if (tb_mes.Text != null)
                sendMessage();
            else
                MessageBox.Show("Введен пустой текст сообщения");
        }
     
     
       

        private void but_ip_server_add_Click(object sender, EventArgs e)
        {
            string item = Microsoft.VisualBasic.Interaction.InputBox("Введите новый IP");
            ip_servers_list.Items.Add(item);
        }

        private void list_files_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
        private void but_select_cat_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.ShowDialog();
            tb_select_cat.Text = folder.SelectedPath;
        }

        private void actions_list_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (actions_list.SelectedIndex == 0)
                sendMessage("get_folders_list");
            if(actions_list.SelectedIndex == 1)
            {
                send_file();
            }
            if(actions_list.SelectedIndex == 2)
            {
               
                  sendMessage("get_file");
            }
        }

        private void tb_select_cat_TextChanged(object sender, EventArgs e)
        {
            working_directory = tb_select_cat.Text;
        }
    }
}
