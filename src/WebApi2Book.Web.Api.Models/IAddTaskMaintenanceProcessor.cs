using WebApi2Book.Web.Api.Models;

namespace WebApi2Book.Web.Api.Models
{
    public interface IAddTaskMaintenanceProcessor
    {
        Task AddTask(NewTask newTask);
    }
}
