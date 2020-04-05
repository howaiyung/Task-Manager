using System;
using System.Collections.Generic;
using System.Text;
using Prism.Validation;
using System.ComponentModel.DataAnnotations;
using System.Windows.Media;
using Microsoft.OData.Edm;

namespace TaskManager.Model
{

    public enum TaskCurrentStatus
    {
        TaskIsComplete,
        TaskIsOverDue,
        TaskIsInProgress
    }

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

        public DateTime _taskDueDate;
        [Required]
        public DateTime TaskDueDate
        {
            get { return _taskDueDate; }
            set { SetProperty(ref _taskDueDate, value);
                  CheckStatus();
                }
        }

        public bool _taskDueDateValid;
        [Required]
        public bool taskDueDateValid
        {
            get { return _taskDueDateValid; }
            set { SetProperty(ref _taskDueDateValid, value);  }
        }

        private bool _taskIsComplete;


        public bool TaskIsComplete
        {
            get { return _taskIsComplete; }
            set { SetProperty(ref _taskIsComplete, value);
                  CheckStatus();
            }
        }


        


        private TaskCurrentStatus _currStatTask;


        public TaskCurrentStatus TaskStatus
        {
            get { return _currStatTask; }
            set { SetProperty(ref _currStatTask, value); }
        }


        public void CheckStatus()
        {
            if ((DateTime.Compare(_taskDueDate.Date, DateTime.Today) >= 0) && (_taskIsComplete == false))
                this.TaskStatus = TaskCurrentStatus.TaskIsInProgress;
            else if (_taskIsComplete == true)
                this.TaskStatus = TaskCurrentStatus.TaskIsComplete;
            else
                this.TaskStatus = TaskCurrentStatus.TaskIsOverDue;
            

        }
    }
}



/*
 * It seems the most optimial way of handling this is if the colour background for each of tasks to be handled by a status variable.
 * 
 * There is a an example:
 * 
 * https://stackoverflow.com/questions/50570409/how-to-bind-backgroundcolor-of-wpf-listview-items
 * 
 * Where the most optimial way to doing it is having a bunch of style triggers passively reading the status of the task at hand and change colour
 * to the appropriate status.
 * 
 * Wouldn't it be easier in a way such that when you add an item into the task list, there is a case structure function that is called, a temp variable which is monitor everytime
 * Something changes.
 * 
 */
