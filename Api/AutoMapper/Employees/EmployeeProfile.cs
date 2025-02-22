using Api.Models.Employee.RequestBody;
using Application.Handlers.Employees.RequestBody;
using AutoMapper;
using Domain.Entities.Employees;

namespace Api.AutoMapper.Employees
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<CreateEmployeeBodyRequest, Employee>();
            CreateMap<CreateEmployeeBodyModel, CreateEmployeeBodyRequest>();
        }
    }
}
