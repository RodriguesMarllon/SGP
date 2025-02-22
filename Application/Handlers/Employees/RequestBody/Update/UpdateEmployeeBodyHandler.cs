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

namespace Application.Handlers.Employees.RequestBody.Update
{
    public class UpdateEmployeeBodyHandler : IRequestHandler<UpdateEmployeeBodyRequest, ResponseBase<UpdateEmployeeResponseItem>>
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        public UpdateEmployeeBodyHandler(ILogger<UpdateEmployeeBodyHandler> logger, IMapper mapper, IEmployeeRepository employeeRepository)
        {
            _logger = logger;
            _mapper = mapper;
            _employeeRepository = employeeRepository;
        }

        public async Task<ResponseBase<UpdateEmployeeResponseItem>> Handle(UpdateEmployeeBodyRequest request, CancellationToken cancellationToken)
        {
            var errorMessage = "Failed on update Emplyee data";

            try
            {
                await _employeeRepository.Update(_mapper.Map<Employee>(request));
            }
            catch (Exception ex)
            {
                _logger.LogError($"{errorMessage} Ex: {ex}");
                throw new ApiException(errorMessage, HttpStatusCode.InternalServerError);
            }

            ResponseBase<UpdateEmployeeResponseItem> response = new(null)
            {
                IsSuccessful = true,
                Message = null,
                StatusCode = StatusCodes.Status200OK
            };

            return response;
        }
    }
}
