using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Szkolenie.Tasks;
using System.IO;
using System.Configuration;

namespace TasksWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TaskMan tasaki = new TaskMan();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void InfoButton_Click(object sender, RoutedEventArgs e)
        {
            infoLabel.Content = infoText.Text;
        }

        private void NewTaskButton_Click(object sender, RoutedEventArgs e)
        {
            TaskDialog td = new TaskDialog();
            if (td.ShowDialog().Value)
            {
                string taskTitle = td.titleTask.Text;//Pobieram z okna td
                DateTime? taskDueDate = td.dateTask.SelectedDate;
                if (!taskDueDate.HasValue)
                {
                    taskDueDate = DateTime.Now.AddDays(1);
                }

                ToDoItem newTask = new ToDoItem(taskTitle, taskDueDate.Value);
                tasaki.AddTask(newTask);
                taskList.ItemsSource = tasaki.TaskList.Select(t => t.Info());

            }
            
        }

        private void TaskListButton_Click(object sender, RoutedEventArgs e)
        {
            string info = "";
            foreach (var item in tasaki.UncompletedTask())
            {
                info += item + System.Environment.NewLine;
            }
            MessageBox.Show(info, "Niezakonczone", 
                MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void SaveUncompleted_Click(object sender, RoutedEventArgs e)
        {
            //string path = @"c:\DemoData\Niezakonczone.txt";
            string path = ConfigurationManager.AppSettings["myPath"];
            Microsoft.Win32.SaveFileDialog fileDialog = new Microsoft.Win32.SaveFileDialog();
            fileDialog.DefaultExt = ".txt";
            fileDialog.Filter = "Text documents .txt | *.txt";
            fileDialog.FileName = path;
            if(fileDialog.ShowDialog().Value)
            {
                path = fileDialog.FileName;

                try
                {
                    File.WriteAllLines(path, tasaki.UncompletedTask());
                    MessageBox.Show("Zapis zakończone", "Uwaga",
                        MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    //FileInfo
                    //FileInfo myFile = new FileInfo(path);
                    ////Katalogi
                    //Directory.CreateDirectory(path);
                    //DirectoryInfo myDir = new DirectoryInfo("C:\\DemoData");

                }
                catch (Exception)
                {
                    MessageBox.Show("Błąd zapisu", "Błąd",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

        }

        private void ReadStrem_Click(object sender, RoutedEventArgs e)
        {
            string path = ConfigurationManager.AppSettings["myPath"];
            FileStream file = new FileStream(path, FileMode.Open);
            //Binarne
            BinaryReader binRead = new BinaryReader(file);
            byte[] data = new byte[binRead.BaseStream.Length];
            int position = 0;
            int retByte;
            while ((retByte = binRead.Read()) != -1)
            {
                data[position] = (byte)retByte;
                position += sizeof(byte);
            }
            binRead.Close();
            file.Close();
            BinaryWriter binWrite = new BinaryWriter(file);
            //Tekstowe
            StreamReader txtRead = new StreamReader(file);
            StringBuilder txtData = new StringBuilder();
            while (txtRead.Peek() != -1)
            {
                txtData.AppendLine(txtRead.ReadLine());
            }
            txtRead.Close();
            StringWriter txtWrite = new StringWriter();
           
        }
    }
}
