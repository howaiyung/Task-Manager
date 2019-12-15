

using System;
using System.Collections.Generic;
using System.Linq; using System.Text;
using System.Threading.Tasks;



namespace Task_Manager.Services
{
    public class TaskRepository : ITaskRepository{
        ZzaDBContext _DBContext = new ZzaDBContext();

        public Task<List<TaskModel>> GetTasksAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TaskModel> GetTaskAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<TaskModel> AddTaskAsync(TaskModel task)
        {
            throw new NotImplementedException();
        }

        public Task<TaskModel> UpdateCustomerAsync(TaskModel task)
        {
            throw new NotImplementedException();
        }

        public Task DeleteTaskAsync(Guid taskId)
        {
            throw new NotImplementedException();
        }

        

    }
}
