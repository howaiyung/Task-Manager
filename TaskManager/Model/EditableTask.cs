using System;
using System.Collections.Generic;
using System.Text;
using Prism.Validation;
using System.ComponentModel.DataAnnotations;
using System.Windows.Media;

namespace TaskManager.Model
{
    public class EditableTask : ValidatableBindableBase
    {
        private Guid _id;

        public Guid Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }

        private string _taskInfo;

        public string TaskInfo
        {
            get { return _taskInfo; }
            set { SetProperty(ref _taskInfo, value); }
        }

        public string _taskDueDate;
        [Required]
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

        private Brush _taskStatusColour;

        public Brush TaskStatusColour
        {
            get { return _taskStatusColour; }
            set { SetProperty(ref _taskStatusColour, value);  }
        }
    }
}
