using Task_Manager.Model;

using System;
using MVVMHierarchiesDemo.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/*
 * Interface for creating the services
 */

namespace Task_Manager.Services
{
    public interface ITaskRepository
    {
        Task<List<TaskModel>> GetTasksAsync();
        Task<TaskModel> GetTaskAsync(Guid id);
        Task<TaskModel> AddTaskAsync(TaskModel task);
        Task<TaskModel> UpdateCustomerAsync(TaskModel task);
        Task DeleteTaskAsync(Guid taskId);


    }
}
