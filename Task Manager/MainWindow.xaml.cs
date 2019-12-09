using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Task_Manager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
        }

        ObservableCollection<Task> Task_ListBoxItems = new ObservableCollection<Task>();

        private void Add_Task(object sender, RoutedEventArgs e)
        {


            Task newTask = new Task();

            newTask.Description = taskInfo.Text;
            newTask.Date = Convert.ToString(dueDate.SelectedDate);
            newTask.TaskComplete = false;
            
            Task_ListBoxItems.Add(newTask);

            lbTasks.ItemsSource = Task_ListBoxItems;


        }

        private void ListBoxTasksItemChanged(object sender, RoutedEventArgs e)
        {
            if (lbTasks.SelectedItem != null)
            {

               

                //string curItem = lbTasks.SelectedItem.ToString();
                MessageBox.Show("The index of the row for the clicked cell is " + sender.ToString());


            }
                //MessageBox.Show("The index of the row for the clicked cell is " + lbTasks.SelectedIndex);

        }

        

        

        
    }
}
