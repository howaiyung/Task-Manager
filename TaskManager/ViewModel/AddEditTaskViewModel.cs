using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Prism.Mvvm;
using Prism.Commands;
using TaskManager.Model;
using System.Windows.Input;
using System.ComponentModel;
using System.Windows;
using Prism.Validation;
using System.Windows.Media;
using Microsoft.OData.Edm;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Interactivity;
using System.Collections.Specialized;

namespace TaskManager.ViewModel
{
    class AddEditTaskViewModel : ValidatableBindableBase
    {

        public DelegateCommand AddCommand { get; private set; }
        public DelegateCommand<EditableTask> EditCommand { get; private set; }

        //public ObservableCollection<EditableTask> Tasks { get; set; } = new ObservableCollection<EditableTask>();

        public ObservableCollection<EditableTask> Tasks { get; set; }


        public AddEditTaskViewModel()
        {
            Tasks = new ObservableCollection<EditableTask>();
            Tasks.CollectionChanged += OnCollectionChanged;
            SetTask(null);
            AddCommand = new DelegateCommand(AddTask, CanAddTask);
            EditCommand = new DelegateCommand<EditableTask>(EditTask, CanEditTask);
            
        }

        private void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            AddCommand.RaiseCanExecuteChanged();
        }

        private EditableTask _NewTask;

        public EditableTask NewTask
        {

            get { return _NewTask; }
            set
            {
                SetProperty(ref _NewTask, value);
            }

        }






        private EditableTask _newViewTask = null;


        private void AddTask()
        {
            if (_newViewTask == null) { _newViewTask = new EditableTask(); }

            AddNewTask(NewTask, _newViewTask);

            //MessageBox.Show("This action is getting reached!");
            Tasks.Add(_newViewTask);
            _newViewTask = null;
            NewTask.TaskDueDate = DateTime.Now;
            NewTask.TaskInfo = "";


        }

        private bool CanAddTask()
        {
            return !NewTask.HasErrors;
        }

        private void AddNewTask(EditableTask source, EditableTask target)
        {
            target.TaskInfo = source.TaskInfo;
            target.TaskDueDate = source.TaskDueDate;
            target.TaskIsComplete = false;
            target.CheckStatus();

            //target.TaskStatus = CheckStatus(source);
            //target.taskDueDateValid = CheckDate(source.TaskDueDate);
            //target.TaskStatus = CheckStatus(source);
            //MessageBox.Show(target.TaskDueDate);
        }



        private bool CheckDate(string taskDueDate)
        {
            throw new NotImplementedException();
        }

        public void SetTask(EditableTask nTask)
        {
            _newViewTask = nTask;
            
            if (NewTask != null) NewTask.ErrorsChanged -= RaiseCanExecuteChanged;
            NewTask = new EditableTask();
            NewTask.ErrorsChanged += RaiseCanExecuteChanged;
            
            
            //CopyTask(nTask, NewTask);

        }

        //private void NewTask_PropertyChanged1(object sender, PropertyChangedEventArgs e)
        //{
        //    MessageBox.Show("This works!5");
        //}

        public TaskCurrentStatus CheckStatus(EditableTask taskToCheck)
        {

            MessageBox.Show(DateTime.Today.ToString());

            if ((DateTime.Compare(taskToCheck.TaskDueDate.Date,DateTime.Today) >= 0) && (taskToCheck.TaskIsComplete == false))
            {
                return TaskCurrentStatus.TaskIsInProgress;
            }
            else if (taskToCheck.TaskIsComplete == true)
            {
                return TaskCurrentStatus.TaskIsComplete;
            }

            return TaskCurrentStatus.TaskIsOverDue;
        }
        private void RaiseCanExecuteChanged(object sender, DataErrorsChangedEventArgs e)
        {
            AddCommand.RaiseCanExecuteChanged();
        }


        //--------------------------------------------------------------------------------------------------------

        /*public string CheckStatus(EditableTask cNewTask)
        {
            var parameterDate = DateTime.ParseExact(cNewTask.TaskDueDate, "MM/dd/yyyy", CultureInfo.InvariantCulture);

            if (cNewTask.TaskIsComplete == true)
            {
                return "TaskComplete";
            }
            else 
            {
                if (parameterDate < DateTime.Today)
                    return "TaskOverDue";
            }

            return "TaskInProgress";
        }*/


        private EditableTask _selectedTask;

        public EditableTask SelectedTask
        {
            get
            {
                return _selectedTask;
            }
            set
            {
                SetProperty(ref _selectedTask, value);


                MessageBox.Show(value.Id.ToString());
            }
        }



        public void SelectedEditableTask(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show("This works!2");
        }



        private void EditTask(EditableTask nEditTask)
        {
            MessageBox.Show(nEditTask.Id.ToString());
        }

        private bool CanEditTask(object nEditTask)
        {
            return true;
        }


        private void ItemOnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("This works!2");

        }


    }

}



/*
 * 
 * In the end, I use string to handles the date because it allows to have nulls in the date parameter.
 * The problem with date as a variable type is there are issues when selecting dates.
 * I'll figure out the issues in another time, but there is a way to set the date time to a variable type.
 * 
 */