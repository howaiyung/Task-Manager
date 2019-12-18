using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using TaskManager.Models;

namespace TaskManager.ViewModels
{
    class ChoreViewModel : BindableBase
    {


        private bool _isFilled;

        public bool IsFilled
        {
            get { return _isFilled; }
            set
            {
                SetProperty(ref _isFilled, value);

            }
        }


        private ChoreEditModel _Chore;

        public ChoreEditModel Chore
        {
            get { return _Chore; }
            set { SetProperty(ref _Chore, value); }
        }

        public ObservableCollection<ChoreEditModel> Chores
        {
            get;
            set;
        }

        public DelegateCommand triggerCommand { get; private set; }
        
        public ChoreViewModel()
        {
            triggerCommand = new DelegateCommand(Execute, CanExecute);
        }

        private void Execute()
        {
            throw new NotImplementedException();
        }

        private bool CanExecute()
        {
            throw new NotImplementedException();
        }

        /*
         * There are 5 actions that are to be attached to this viewModel
         * 
         * 1. Add a new task to a list of tasks, the '+' button will only activate once a date and the text box is filled.
         * 2. Modifying the task info such that if it is empty, the task automatically deletes itself. Otherwise, it updates the entry with the new task.
         * 3. If the date changes, it checks today's date and chamges the background entry from white to red.
         * 4. If the user checkmarks the checkbox, it does a cross out and grey out of the text, and turns the entry to green, overriding the red color.
         * 5. If the user uncheckmarks the checkbox, it automatically checks the date and turns red if over date.
         * 
         */


        /*
         * Optional:
         * 1. Creating a permanent option for saving the data in a database file.
         * 
         */
    }

}
