using Base.Abstractions;
using Service.Abstraction;

using System.Collections.Generic;
using System.Linq;

namespace CourseProject.GYM.Models
{
    public class ListUsersModel
    {
        public IEnumerable<BaseUser> Users { get; set; }

        public ListUsersModel(IWorkerService workerService, IUserService clientService)
        {
            Users.ToList().AddRange(workerService.GetWorker());
            Users.ToList().AddRange(clientService.GetClients());
        }
    }
}