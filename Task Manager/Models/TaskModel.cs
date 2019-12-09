using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;


namespace Task_Manager.Models
{
    public class Task : INotifyPropertyChanged
    {
        private string _taskDescription;
        private string _taskDueDate;
        private bool _isComplete;
        private bool _isValidTask;

        public event PropertyChangedEventHandler PropertyChanged;

        public string TaskDescription
        {
            get
            {
                return _taskDescription;
            }
            set
            {
                if(_taskDescription != value)
                {
                    _taskDescription = value;
                    OnPropertyChanged();
                    SetIsValid();

                }
            }
        }

        public string TaskDueDate
        {
            get
            {
                return _taskDueDate;
            }
            set
            {
                _taskDueDate = value;
                OnPropertyChanged();
                SetIsValid();
            }
        }

        public bool IsValidTask
        {
            get
            {
                return _isValidTask;
            }
            set
            {
                if (_isValidTask != value)
                {
                    _isValidTask = value;
                    OnPropertyChanged();
                }
            }
        }



        private void SetIsValid()
        {
            IsValidTask = !string.IsNullOrEmpty(TaskDescription) && !string.IsNullOrEmpty(TaskDueDate);
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }



}
