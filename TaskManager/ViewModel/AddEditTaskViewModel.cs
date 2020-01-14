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
            SetEditableTask(null);
            AddCommand = new DelegateCommand(AddTask, CanAddTask);
            EditCommand = new DelegateCommand(EditTask, CanEditTask);
        }

        

        public DelegateCommand AddCommand { get; private set; }
        
        private SimpleEditableTask _newViewTask = null;
        private EditableTask _newSelectedTask = null;


        private void AddTask()
        {
            if(_newViewTask == null) { _newViewTask = new SimpleEditableTask(); }
            if(_newSelectedTask == null) { _newSelectedTask = new EditableTask(); }

            AddNewTask(NewTask, _newViewTask);
            EditNewTask(NewTask, _newSelectedTask);
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

        //--------------------------------------------------------------------------------------------------------


        public DelegateCommand EditCommand { get; private set; }

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

            }
        }

        private void SetEditableTask(EditableTask nEditTask)
        {
            _newSelectedTask = nEditTask;
            if (SelectedTask != null) SelectedTask.ErrorsChanged -= RaiseCanEditChanged;
            SelectedTask = new EditableTask();
            SelectedTask.ErrorsChanged += RaiseCanEditChanged;

        }

        private void RaiseCanEditChanged(object sender, DataErrorsChangedEventArgs e)
        {
            EditCommand.RaiseCanExecuteChanged();

        }

        private void EditTask()
        {
            //EditNewTask(_selectedTask, _newEditableTask);
            MessageBox.Show("This action is getting reached!");
        }
        private bool CanEditTask()
        {
            //return SelectedTask != null;
            return !SelectedTask.HasErrors;
        }


        private void EditNewTask(SimpleEditableTask source, EditableTask target)
        {
            target.TaskInfo = source.TaskInfo;
            target.TaskDueDate = source.TaskDueDate;
            target.TaskIsComplete = source.TaskIsComplete;
            target.TaskStatusColour = Brushes.Gray;

        }
    }
}



