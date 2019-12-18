using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace ChoreManager.Model
{
    public class ChoreModel {}

    public class Chore : INotifyPropertyChanged
    {
        private Guid _id;

        public Guid Id
        {
            get { return _id; }
            set
            {
                if (_id != value)
                {
                    _id = value;
                    RaisePropertyChanged("Id");
                }
            }
        }

        private string _choreInfo;
        public string ChoreInfo
        {
            get { return _choreInfo; }
            set
            {
                if (_choreInfo != value)
                {
                    _choreInfo = value;
                    RaisePropertyChanged("ChoreInfo");
                }
                   
            }
        }

        private string _choreDueDate;
        public string ChoreDueDate
        {
            get { return _choreDueDate; }
            set
            {
                if (_choreDueDate != value)
                {
                    _choreDueDate = value;
                    RaisePropertyChanged("ChoreDueDate");
                }
                    
            }
        }

        private bool _choreIsComplete;

        public bool ChoreIsComplete
        {
            get { return _choreIsComplete; }
            set
            {
                if (_choreIsComplete != value)
                {
                    _choreIsComplete = value;
                    RaisePropertyChanged("ChoreIsComplete");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
