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
        }


        

        /*private Task _editingTask = null;

        public void SetTask(Task nTask)
        {
            _editingTask = nTask;

            if (NewTask != null) NewTask.ErrorsChanged -= RaiseCanExecuteChanged;
            NewTask = new SimpleEditableTask();
            NewTask.ErrorsChanged += RaiseCanExecuteChanged;
            CopyCustomer(nTask, NewTask);
        }


        private void UpdateCustomer(SimpleEditableTask source, Task target)
        {
            target.TaskInfo = source.TaskInfo;
            target.TaskDueDate = source.TaskDueDate;
            target.TaskIsComplete = false;
        }

        private void CopyCustomer(Task source, SimpleEditableTask target)
        {
            target.Id = source.Id;

            if (EditMode)
            {
                target.TaskInfo = source.TaskInfo;
                target.TaskDueDate = source.TaskDueDate;
                target.TaskIsComplete = source.TaskIsComplete;
            }
        }

        private void RaiseCanExecuteChanged(object sender, EventArgs e)
        {
            AddCommand.RaiseCanExecuteChanged();
        }*/



        /// <summary>
        /// Handles the AddCommand, will need to be triggered once text is entered into the textbox
        /// </summary>


        /*public ICommand _addCommand { get; private set; }

        public ICommand AddCommand
        {
            get
            {
                if(_addCommand == null)
                {
                    _addCommand = new RelayCommand(
                        param => this.AddTask(),
                        param => this.CanAddTask()
                    );
                }
            }

        }*/ //= new TaskICommand(AddTask, CanAddTask);


        



        public DelegateCommand AddCommand { get; private set; }
        private void AddTask()
        {
            /*UpdateCustomer(NewTask, _editingTask);

            Tasks.Add(NewTask);*/

            MessageBox.Show("This action is getting reached!");

        }

        private bool CanAddTask()
        {

            //return !NewTask.HasErrors;
            /*if (NewTask.ValidateProperties() == null)
                return false;
            else
                return NewTask.ValidateProperties();*/

            
            return !_NewTask.HasErrors;



        }


        private SimpleEditableTask _newViewTask = null;

        public void SetTask(SimpleEditableTask nTask)
        {
            _newViewTask = nTask;
            if (NewTask != null) NewTask.ErrorsChanged -= RaiseCanExecuteChanged;
            NewTask = new SimpleEditableTask();
            NewTask.ErrorsChanged += RaiseCanExecuteChanged;
            //CopyTask(nTask, NewTask);

        }

        private void CopyTask(SimpleEditableTask source, SimpleEditableTask target)
        {
            source.TaskInfo = target.TaskInfo;
            source.TaskDueDate = target.TaskDueDate;
            source.TaskIsComplete = false;

        }

        private void RaiseCanExecuteChanged(object sender, DataErrorsChangedEventArgs e)
        {
            AddCommand.RaiseCanExecuteChanged();
        }
    }
}



