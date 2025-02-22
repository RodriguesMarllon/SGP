using Application.Models.Abstracts;
using Application.Models.Response.Employees;
using MediatR;
using System.Diagnostics.CodeAnalysis;

namespace Application.Handlers.Employees.RequestBody
{
    [ExcludeFromCodeCoverage]
    public class CreateEmployeeBodyRequest : IRequest<ResponseBase<CreateEmployeeResponseItem>>
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Signature { get; set; }
        public bool Active { get; set; }
        public string Position { get; set; }
        public DateTime InsertUpdateDatetime { get; set; }
    }
}
