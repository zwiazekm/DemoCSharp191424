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
using System.Threading;
using Microsoft.Office.Interop.Excel;

namespace DemoTPL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : System.Windows.Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LongRunButton_Click(object sender, RoutedEventArgs e)
        {
            Task task1 = new Task(LongRun);
            task1.Start();
            //Task tas2 = new Task(delegate
            //{
            //    MessageBox.Show("Zaczynam");
            //    Thread.Sleep(10000);
            //    MessageBox.Show("Skonczone");
            //});

            var task3 = Task.Factory.StartNew(LongRun);
            var task4 = Task.Run(() => LongRun());

        }

        private void LongRun()
        {
            MessageBox.Show("Zaczynam");
            Thread.Sleep(10000);
            MessageBox.Show("Skonczone");
        }

        private string LongRunRetStr()
        {
            MessageBox.Show("Zaczynam");
            Thread.Sleep(5000);
            return "Obliczenia zakonczone";
        }


        private void LongRun2()
        {
            //infoTxt.Text = "Zaczynam liczyć";
            infoTxt.Dispatcher.BeginInvoke(new Action(() => infoTxt.Text = "Zaczynam"));
            Thread.Sleep(10000);

        }

        private void WaitButton_Click(object sender, RoutedEventArgs e)
        {
            Task[] tasks = new Task[3]
            {
                 Task.Run(() => LongRun()),
                 Task.Run(() => LongRun()),
                 Task.Run(() => LongRun())
               };
            Task.WaitAll(tasks);


            var task4 = Task.Run(() => LongRun());
            task4.Wait();
        }

        private async void TaskretString_Click(object sender, RoutedEventArgs e)
        {
            Task<string> task1 = Task.Run<string>(() => LongRunRetStr());
            infoTxt.Text = await task1;
        }

        private void ChilTaksButton_Click(object sender, RoutedEventArgs e)
        {
            //Zagnieżdżone
            var outer = Task.Run(() =>
            {
                MessageBox.Show("Outer Start");
                var inner = Task.Factory.StartNew(() =>
                {
                    MessageBox.Show("Inner task start");
                    Thread.Sleep(5000);
                });
                MessageBox.Show("Outer after inner");
            }
            );
        }

        private void DispatcheDemo_Click(object sender, RoutedEventArgs e)
        {
            Task.Run(() => LongRun2());
        }

        private async void AwaitableBUtton_Click(object sender, RoutedEventArgs e)
        {
            Task<string> t1 = Task.Run(() => LongRun3());
            infoTxt.Text = await t1;
        }

        private async Task<string> LongRun3()
        {

            return await Task.Run(()=>LongRun4());
            
        }

        private string LongRun4()
        {
            Thread.Sleep(10000);
            return "Koniec Longrun3";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<string> list = new List<string>();

            var wyn = from l in list.AsParallel()
                      select l;

            Parallel.Invoke();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            dynamic excel = new ApplicationClass();

        }
    }
}
