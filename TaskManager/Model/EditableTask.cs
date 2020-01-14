using System;
using System.Collections.Generic;
using System.Text;
using Prism.Validation;
using System.ComponentModel.DataAnnotations;
using System.Windows.Media;
using Microsoft.OData.Edm;

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

        /*private Brush _taskStatusColour;

        public Brush TaskStatusColour
        {
            get { return _taskStatusColour; }
            set { SetProperty(ref _taskStatusColour, value);  }
        }*/


        private string _taskStatus;

        public string TaskStatus
        {
            get { return _taskStatus; }
            set { SetProperty(ref _taskStatus, value); }
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
