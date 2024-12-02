using CleanArchitecture.Application.Features.PlanFeatures.Commands.CreatePlan;
using CleanArchitecture.Application.Features.PlanFeatures.Queries.GetAllPlan;
using CleanArchitecture.Domain.Dtos;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Presentation.Abstraction;
using EntityFrameworkCorePagination.Nuget.Pagination;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Presentation.Controllers;

public sealed class PlansController : ApiController
{   
    public PlansController(IMediator mediator) : base(mediator) {}

    //[RoleFilter("Create")]
    [HttpPost("[action]")]
    public async Task<IActionResult> Create(CreatePlanCommand request, CancellationToken cancellationToken)
    {
        MessageResponse response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }

    //[RoleFilter("GetAll")]
    [HttpPost("[action]")]
    public async Task<IActionResult> GetAll(GetAllPlanQuery request, CancellationToken cancellationToken)
    {
        PaginationResult<Plan> response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }

}
