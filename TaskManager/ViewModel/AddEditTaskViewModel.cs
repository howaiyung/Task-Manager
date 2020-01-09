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

namespace TaskManager.ViewModel
{
    class AddEditTaskViewModel : ValidatableBindableBase
    {
        public ObservableCollection<SimpleEditableTask> Tasks { get; set; } = new ObservableCollection<SimpleEditableTask>();

        private SimpleEditableTask _NewTask;



        public SimpleEditableTask NewTask
        {

            get { return _NewTask; }
            set
            {
                SetProperty(ref _NewTask, value);
            }

        }


        public AddEditTaskViewModel()
        {
            SetTask(null);
            AddCommand = new DelegateCommand(AddTask, CanAddTask);
            EditCommand = new DelegateCommand(EditTask, CanEditTask);
        }

        

        public DelegateCommand AddCommand { get; private set; }
        public DelegateCommand EditCommand { get; private set; }
        private SimpleEditableTask _newViewTask = null;

        private SimpleEditableTask _newEditableTask = null;

        private void AddTask()
        {
            if(_newViewTask == null) { _newViewTask = new SimpleEditableTask(); }
            
            AddNewTask(NewTask, _newViewTask);

            /*UpdateCustomer(NewTask, _editingTask);

            Tasks.Add(NewTask);*/

            
            //MessageBox.Show("This action is getting reached!");
            Tasks.Add(_newViewTask);
            _newViewTask = null;
            NewTask.TaskDueDate = null;
            NewTask.TaskInfo = "";


        }

        private bool CanAddTask()
        {
            return !NewTask.HasErrors;
        }

        private void AddNewTask(SimpleEditableTask source, SimpleEditableTask target)
        {
            target.TaskInfo = source.TaskInfo;
            target.TaskDueDate = source.TaskDueDate;
            target.TaskIsComplete = false;


            //MessageBox.Show(target.TaskDueDate);
        }

        
        public void SetTask(SimpleEditableTask nTask)
        {
            _newViewTask = nTask;
            if (NewTask != null) NewTask.ErrorsChanged -= RaiseCanExecuteChanged;
            NewTask = new SimpleEditableTask();
            NewTask.ErrorsChanged += RaiseCanExecuteChanged;
            //CopyTask(nTask, NewTask);

        }

        
        private void RaiseCanExecuteChanged(object sender, DataErrorsChangedEventArgs e)
        {
            AddCommand.RaiseCanExecuteChanged();
        }

        private SimpleEditableTask _selectedTask;
        public SimpleEditableTask SelectedTask
        {
            get
            {
                return _selectedTask;
            }
            set
            {
                if(value == _selectedTask)
                    return;

                SetProperty(ref _selectedTask, value);

                //MessageBox.Show("This action is getting reached!");

                MessageBox.Show(_selectedTask.TaskInfo);
                if(_selectedTask.TaskInfo == "")
                {
                    
                    Tasks.Remove(value);
                }


            }
        }



        private void EditTask()
        {
            //SelectedTask = new SimpleEditableTask();

            EditNewTask(_selectedTask, _newEditableTask);
            

        }
        private bool CanEditTask()
        {
            return SelectedTask != null;
        }


        private void EditNewTask(SimpleEditableTask source, SimpleEditableTask target)
        {
            target.Id = source.Id;
            target.TaskInfo = source.TaskInfo;
            target.TaskDueDate = source.TaskDueDate;
            target.TaskIsComplete = source.TaskIsComplete;
        }
    }
}



