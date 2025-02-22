using Api.Models.Employee.RequestBody;
using Application.Handlers.Employees.RequestBody;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace Api.Controllers
{
    [ExcludeFromCodeCoverage]
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : BaseController
    {
        public readonly IMapper _mapper;
        public readonly ILogger<EmployeeController> _logger;

        public EmployeeController(ILogger<EmployeeController> logger, IMediator mediator, IMapper mapper) : base(mediator)
        {
            _mapper = mapper;
            _logger = logger;
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] CreateEmployeeBodyModel body)
        {
            try
            {
                var queryMediator = _mapper.Map<CreateEmployeeBodyRequest>(body);
                var result = await _mediator.Send(queryMediator);
                return Ok(result);
            }
            catch (AutoMapperMappingException ex)
            {
                _logger.LogError($"Mapping error: {ex.Message}");
                return BadRequest("Mapping error");
            }
        }
    }
}
