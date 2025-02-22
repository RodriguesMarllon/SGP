using Application.Models.Abstracts;
using Application.Models.Response.Employees;
using AutoMapper;
using Domain.Entities.Employees;
using Domain.InterfacesRepositories.Employees;
using Infrastructure.CrossCutting.Utils;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Net;

namespace Application.Handlers.Employees.RequestBody.Create
{
    public class CreateEmployeeBodyHandler : IRequestHandler<CreateEmployeeBodyRequest, ResponseBase<CreateEmployeeResponseItem>>
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        public CreateEmployeeBodyHandler(IEmployeeRepository employeeRepository, ILogger<CreateEmployeeBodyHandler> logger, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseBase<CreateEmployeeResponseItem>> Handle(CreateEmployeeBodyRequest request, CancellationToken cancellationToken)
        {
            var errorMessage = "Failed to create Employee";

            try
            {
                request.InsertUpdateDatetime = DateTime.Now;
                await _employeeRepository.Add(_mapper.Map<Employee>(request));
            }
            catch (Exception ex)
            {
                _logger.LogError($"{errorMessage} Ex: {ex.Message}");
                throw new ApiException(errorMessage, HttpStatusCode.InternalServerError);
            }

            ResponseBase<CreateEmployeeResponseItem> response = new(null)
            {
                IsSuccessful = true,
                Message = null,
                StatusCode = StatusCodes.Status200OK
            };

            return response;
        }
    }
}
