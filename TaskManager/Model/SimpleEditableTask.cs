using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TaskManager.ViewModel;
using Prism.Mvvm;
using Prism.Commands;
using Prism.Events;
using System.ComponentModel;
using System.Collections;
using Prism.Validation;

/// <summary>
/// This section is used in returning whether something has changed or not.
/// https://documentation.devexpress.com/WPF/17350/MVVM-Framework/View-Models/BindableBase
/// 
/// https://stackoverflow.com/questions/28844518/bindablebase-vs-inotifychanged
/// 
/// https://github.com/mfe-/Prism.Validation
/// </summary>
/// 

namespace TaskManager.Model
{
    public class SimpleEditableTask : ValidatableBindableBase
    {
        private Guid _id;

        public Guid Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }

        private string _taskInfo;
        //[Required(AllowEmptyStrings = false)]
        [Required]
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

        
    }
}
