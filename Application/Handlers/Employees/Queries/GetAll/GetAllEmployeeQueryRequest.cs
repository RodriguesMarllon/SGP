using Application.Models.Abstracts;
using Application.Models.Response.Employees;
using MediatR;
using System.Diagnostics.CodeAnalysis;

namespace Application.Handlers.Employees.Queries.GetAll
{
    [ExcludeFromCodeCoverage]
    public class GetAllEmployeeQueryRequest : IRequest<ResponseBase<List<GetAllEmployeeResponseItem>>>
    {
    }
}
