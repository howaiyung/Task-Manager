using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using Task_Manager.Model;
using System.Collections.ObjectModel;

namespace Task_Manager.ViewModel
{
    class TaskViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Task task;
        public ObservableCollection<Task> Tasks
        {
            get;
            set;
        }

        
    }
}
