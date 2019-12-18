using System;
using System.Collections.Generic;
using System.Text;

using System.Collections.ObjectModel;
using ChoreManager.Model;
using System.Windows.Input;

using Prism.Mvvm;
using Prism.Commands;


namespace ChoreManager.ViewModel
{
    class ChoreViewModel : BindableBase
    {

        private bool _isFilled;
        public bool IsFilled
        {
            get { return _isFilled; }
            set { SetProperty(ref _isFilled, value); }
        }

        

        public ObservableCollection<Chore> Chores { get; } = new ObservableCollection<Chore>();

        public DelegateCommand AddCommand { get; private set; }

        public ChoreViewModel()
        {
            AddCommand = new DelegateCommand(AddChore, CanAddChore).ObservesProperty(() => IsFilled);
        }

        private void AddChore()
        {
            
          
        }

        private bool CanAddChore()
        {
            return IsFilled;
        }



        /*
         * There will be 2 sets of actions. 
         * 
         * One for handling when the Add button is pushed.
         * The events of the text box filled would automatically turn the add button from disabled to enabled.
         * The date is automatically set to today to expedite the process. 
         * There could be a another event detection/requirement where the client selects a date.
         * 
         * The 2nd set of actions would be when the information is edited in the box
         * Once the text in a entry is empty, the task is deleted from the list
         * If the date selected to a date before today, highlight the task as red
         * If the checkmark is pressed, if it is checked, means the text box is greyed out and 
         * 
         */


        /*
        * Optional:
        * 1. Creating a permanent option for saving the data in a database file.
        * 2. Have the events triggered such that it is handled by the Chore model.
        * 
        */

        /*
         * Step 1: Have a event where the Add button becomes usable after the textbox and is not empty
         */
    }
}


/*
 * Composite command
 * https://www.youtube.com/watch?v=kssprOqdfME
 * 
 */
