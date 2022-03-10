using Employee.Core.Repositories.Base;

namespace Employee.Core.Repositories
{
    public interface IEmployeeRepository : IRepository<Entities.Employee>
    {
        //custom operations here
        Task<IEnumerable<Entities.Employee>> GetEmployeeByLastName(string lastname);
    }
}
