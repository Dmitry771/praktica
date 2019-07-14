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

namespace server
{
    public partial class Form1 : Form
    {
        int port = 8005;
        string ip;
        string host;
        Thread listen;

        string file_Recept_name;//тут будет хранится имя и путь к файлу при приеме
        bool wait_file;
        string working_directory;
        
        public Form1()
        {
            host = System.Net.Dns.GetHostName();

            ip = System.Net.Dns.GetHostByName(host).AddressList[0].ToString();

            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            wait_file = false;
            tb_clientFilesSaving.Text = "dir";
            working_directory = "dir";
        }

      
        private void Form1_Load(object sender, EventArgs e)
        {
         
        }
      
      
        private void SendMessage()
        {
         
        }
      
        private void but_connect_Click(object sender, EventArgs e)
        {
            //connecting();
            listen = new Thread(connecting);
            listen.IsBackground = true;
            listen.Start();
            tb_IP_serv.Text = ip;
            tb_host_serv.Text = host;
        }
        private void connecting()
        {
            IPEndPoint ipPoint = new IPEndPoint(IPAddress.Any, port);

            // создаем сокет
            Socket listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                // связываем сокет с локальной точкой, по которой будем принимать данные
                listenSocket.Bind(ipPoint);

                // начинаем прослушивание
                listenSocket.Listen(10);

                tb_status.Text = " Сервер запущен. Ожидание подключений..";
              //  Console.WriteLine("Сервер запущен. Ожидание подключений...");

                while (true)
                {
                    Socket handler = listenSocket.Accept();
                    // получаем сообщение
                    StringBuilder builder = new StringBuilder();
                    int bytes = 0; // количество полученных байтов
                    byte[] data = new byte[10000]; // буфер для получаемых данных

                    do
                    {
                        bytes = handler.Receive(data);
                        builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                    }
                    while (handler.Available > 0);
                    // MessageBox.Show(DateTime.Now.ToShortTimeString() + ": " + builder.ToString());
                
                
                    //Console.WriteLine(DateTime.Now.ToShortTimeString() + ": " + builder.ToString());

                    // отправляем ответ
                    //"ваше сообщение доставлено";
                    if (!wait_file)
                        data = parse_action(builder.ToString());
                    else
                        data = save_client_file(data);
                    handler.Send(data);
                    // закрываем сокет
                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }
         

        }
        private byte[] save_client_file(byte[] data)
        {
            string result_answer;
            string file_name = file_Recept_name;
            FileInfo info;
            tb_mes_from_client.Text = "send_file_data - " + file_Recept_name;
            try
            {
                string file_info = working_directory + '\\' + file_name;
                if (!File.Exists(file_name))
                {
                    info = new FileInfo(file_info);
                    info.Create().Close();

                }
                File.WriteAllBytes(file_info, data);
                result_answer = "Файл успешно отправлен";
            }
            catch(Exception w)
            {
                result_answer = "Не удалось отправить файл";
                MessageBox.Show("Ошибка при сохранении файла");
             
            }
            wait_file = false;
            file_Recept_name = "";
            return Encoding.Unicode.GetBytes(result_answer);
        }
        private byte[] parse_action(string message)
        {

            string[] action;
            string answer = "Доставлено";
            byte[] data = new byte[10000];
            
            action = message.Split('$');
            if (action.Length > 1)
            {
                if (action[1] == "get_folders_list")
                {
                    answer = get_folders_list(working_directory);
                    tb_mes_from_client.Text = "get_files_list";
                }
                if (action[1] == "get_file")
                {
                    data = get_file(action[2]);
                    tb_mes_from_client.Text = "get_file - " + action[2]; 
                    return data;
                }
                if(action[1] == "send_file_name")
                {
                    file_Recept_name = action[2];
                    wait_file = true;
                    answer = "Имя файла получено";
                    tb_mes_from_client.Text = "send_file_name - " + action[2];
                    return Encoding.Unicode.GetBytes(answer);
                }
                if (action[0] == "send_text_message")
                {
                    tb_mes_from_client.Text = action[1];
                    return Encoding.Unicode.GetBytes(answer);
                }


            }
            
          
            return Encoding.Unicode.GetBytes(answer);
        }
        private byte[] get_file(string file)
        {
            byte[] data = new byte[256];
            data = File.ReadAllBytes(working_directory+'\\'+file);
            return data;
        }
        private string get_folders_list(string directory = "dir")
        {
            List<string> files = Directory.GetFiles(directory).ToList<string>();
            string list = string.Empty;
            foreach(string file in files)
            {
                string[] fil = file.Split('\\');
                list += fil[fil.Length-1] + "|";
            }
            return list;
        }

        private void tb_clientFilesSaving_TextChanged(object sender, EventArgs e)
        {
            working_directory = tb_clientFilesSaving.Text;
        }

        private void but_changeDirFiles_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                tb_clientFilesSaving.Text = folderBrowser.SelectedPath;
                working_directory = tb_clientFilesSaving.Text;
            }
        }
    }
}
