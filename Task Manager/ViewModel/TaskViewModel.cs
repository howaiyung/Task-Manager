using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using Task_Manager.Model;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Task_Manager.Views;

namespace Task_Manager.ViewModel
{
    public class TaskViewModel
    {
        public TaskICommand AddCommand { get; set; }


        public TaskViewModel(){
            AddCommand = new TaskICommand(OnAdd, CanAdd);
        }
 
        public ObservableCollection<TaskModel> Tasks
        {
            get;
            set;
        }


        private TaskModel _newTask;

        /// <summary>
        /// This adds a new Task into the Tasks list
        /// </summary>
        private void OnAdd()
        {
            TaskModel newTask = new TaskModel();
            newTask.taskDescription =  
            

        }

        /// <summary>
        /// This checks if the input is valid, and it'll allow it or not
        /// </summary>
        private void CanAdd()
        {

        }
    }
}
