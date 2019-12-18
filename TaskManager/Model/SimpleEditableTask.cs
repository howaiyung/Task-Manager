using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TaskManager.ViewModel;

/// <summary>
/// This section is used in returning whether something has changed or not.
/// https://documentation.devexpress.com/WPF/17350/MVVM-Framework/View-Models/BindableBase
/// </summary>
namespace TaskManager.Model
{
    public class SimpleEditableTask : ValidateBindableBase
    {
        private Guid _id;

        public Guid Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }

        private string _taskInfo;
        [Required]

        public string TaskInfo
        {
            get { return _taskInfo; }
            set { SetProperty(ref _taskInfo, value); }
        }

        public string _taskDueDate;

        public string TaskDueDate
        {
            get { return _taskDueDate; }
            set { SetProperty(ref _taskDueDate, value); }
        }

        private bool _taskIsComplete;

        public bool TaskIsComplete
        {
            get { return _taskIsComplete; }
            set { SetProperty(ref _taskIsComplete, value); }
        }
    }
}
