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

namespace Application.Handlers.Employees.Queries.GetAll
{
    public class GetAllEmployeeQueryHandler : IRequestHandler<GetAllEmployeeQueryRequest, ResponseBase<List<GetAllEmployeeResponseItem>>>
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        public GetAllEmployeeQueryHandler(ILogger<GetAllEmployeeQueryHandler> logger, IMapper mapper, IEmployeeRepository employeeRepository)
        {
            _logger = logger;
            _mapper = mapper;
            _employeeRepository = employeeRepository;
        }

        public async Task<ResponseBase<List<GetAllEmployeeResponseItem>>> Handle(GetAllEmployeeQueryRequest request, CancellationToken cancellationToken)
        {
            var errorMessage = "Failed to get all Employees";
            List<Employee> data;

            try
            {
                data = await _employeeRepository.GetAll();
            }
            catch (Exception ex)
            {
                _logger.LogError($"{errorMessage} Ex: {ex}");
                throw new ApiException(errorMessage, HttpStatusCode.InternalServerError);
            }

            if (data == null)
            {
                throw new ApiException("Employees data not found.", HttpStatusCode.NotFound);
            }

            List<GetAllEmployeeResponseItem> responseItems = new();

            data.ForEach(data =>
            {
                responseItems.Add(_mapper.Map<GetAllEmployeeResponseItem>(data));
            });

            ResponseBase<List<GetAllEmployeeResponseItem>> response = new(responseItems)
            {
                IsSuccessful = true,
                Message = null,
                StatusCode = StatusCodes.Status200OK
            };

            return response;
        }
    }
}
