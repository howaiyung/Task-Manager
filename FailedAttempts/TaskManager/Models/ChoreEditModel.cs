using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Mvvm;

namespace TaskManager.Models
{
    public class ChoreEditModel : BindableBase
    {
        private Guid _id;
        public Guid Id
        {
            get { return _id; }
            set
            {
                if (_id != value)
                    _id = value;
            }
        }

        private string _choreInfo;
        [Required]

        public string ChoreInfo
        {
            get { return _choreInfo; }
            set { SetProperty(ref _choreInfo, value); }
        }

        private string _choreDueDate;

        public string ChoreDueDate
        {
            get { return _choreDueDate; }
            set { SetProperty(ref _choreDueDate, value); }
        }

        private bool _choreIsComplete;

        public bool ChoreIsComplete
        {
            get { return _choreIsComplete; }
            set { SetProperty(ref _choreIsComplete, value);  }
        }

    }
}
