using NHibernate;
using WebApi2Book.Data.Entities;
using WebApi2Book.Data.QueryProcessors;

namespace WebApi2Book.Data.SqlServer.QueryProcessors
{
    public class TaskByIdQueryProcessor : ITaskByIdQueryProcessor
    {
        private readonly ISession _session;

        public TaskByIdQueryProcessor(ISession session)
        {
            _session = session;
        }

        public Task GetTask(long TaskId)
        {
            var task = _session.Get<Task>(TaskId);
            return task;
        }
    }
}
