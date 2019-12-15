using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager.Model
{
    public class AddTask : ValidatableBindableBase
    {
        private Guid _id;

        public Guid Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value);  }
        }

        private string _taskDetails;
        [Required]

        public string TaskDetails
        {
            get { return _taskDetails; }
            set { SetProperty(ref _taskDetails, value);  }
        }

        private string _taskDateDue;

        public string TaskDateDue
        {
            get { return _taskDateDue; }
            set { SetProperty(ref _taskDateDue, value);  }
        }

        private bool _taskIsDone;

        public bool TaskIsDone
        {
            get { return _taskIsDone;  }
            set { SetProperty(ref _taskIsDone, value);  }
        }
    }
}
