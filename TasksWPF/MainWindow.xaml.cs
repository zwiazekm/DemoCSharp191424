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
            td.ShowDialog();
        }
    }
}
