using System;
using System.Collections.Generic;
using System.Text;
using Prism.Mvvm;
using TaskManager.ViewModel;
using System.Windows;

namespace TaskManager.Model
{
    public class AddTaskViewModel : BindableBase
    {

        private string _addTaskInfo;
        private string _addTaskDueDate;
        public string AddTaskInfo
        {
            get { return _addTaskInfo; }
            set 
            {
                MessageBox.Show("This action is getting reached!");
                SetProperty(ref _addTaskInfo, value);
            }
        }

        public string AddTaskDueDate
        {
            get { return _addTaskDueDate; }
            set { 
                SetProperty(ref _addTaskDueDate, value); }
        }

    }
}
