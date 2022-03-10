using MediatR;

namespace Employee.Application.Queries
{
    public class GetAllEmployeeQuery : IRequest<List<Core.Entities.Employee>>
    {

    }
}
