using Api.Models.Employee.RequestBody;
using Application.Handlers.Employees.RequestBody.Create;
using Application.Handlers.Employees.RequestBody.Update;
using Application.Models.Response.Employees;
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
            CreateMap<Employee, GetAllEmployeeResponseItem>();
            CreateMap<UpdateEmployeeBodyRequest, Employee>();
            CreateMap<UpdateEmployeeBodyModel, UpdateEmployeeBodyRequest>();
        }
    }
}
