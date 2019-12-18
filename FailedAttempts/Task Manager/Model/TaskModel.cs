using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;


namespace Task_Manager.Model
{


    public class TaskModel { }

    /*
    public class Task : INotifyPropertyChanged
    {
        private string __taskDescription;
        private string __taskDueDate;
        private bool __isComplete;

        public string taskDescription
        {
            get
            {
                return __taskDescription;
            }
            set
            {
                if (__taskDescription != value)
                {
                    __taskDescription = value;
                   
                }
            }
        }

        public string taskDueDate
        {
            get
            {
                return __taskDueDate;
            }
            set
            {
                if(__taskDueDate != value)
                {
                    __taskDueDate = value;
                    //RaisePropertyChanged("dateChanged");
                }
            }
        }

        public bool isComplete
        {
            get
            {
                return __isComplete;
            }
            set
            {
                if(__isComplete != value)
                {
                    __isComplete = value;
                    //RaisePropertyChanged("statusChanged");
                }
            }
        }

        
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        
    }
    */



}


/// <summary>
/// Rememeber to add event handlers whenever the data has changed
/// Now the best way is to add the bool functions in the Model and have them called from ViewModel
/// But there is a way to intergrate INotifyPropertyChanged such that if any info changes, 
/// the function handling the element can also call the functionality.
/// For example, the function is called and makes a modification to the View. 
/// But now thinking about it, it would complicated the issue.
/// </summary>
