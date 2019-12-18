using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Model
{
    public class TaskModel { }

    public class Task : INotifyPropertyChanged
    {
        private Guid _id;

        public Guid Id
        {
            get { return _id; }
            set
            {
                if (_id != value)
                {
                    _id = value;
                    RaisePropertyChanged("Id");
                }
            }
        }

        private string _taskInfo;
        public string TaskInfo
        {
            get { return _taskInfo; }
            set
            {
                if (_taskInfo != value)
                {
                    _taskInfo = value;
                    RaisePropertyChanged("TaskInfo");
                }

            }
        }

        private string _taskDueDate;
        public string TaskDueDate
        {
            get { return _taskDueDate; }
            set
            {
                if (_taskDueDate != value)
                {
                    _taskDueDate = value;
                    RaisePropertyChanged("TaskDueDate");
                }

            }
        }

        private bool _taskIsComplete;

        public bool TaskIsComplete
        {
            get { return _taskIsComplete; }
            set
            {
                if (_taskIsComplete != value)
                {
                    _taskIsComplete = value;
                    RaisePropertyChanged("TaskIsComplete");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
