using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.Entities;
using EntityFrameworkCorePagination.Nuget.Pagination;
using MediatR;

namespace CleanArchitecture.Application.Features.PlanFeatures.Queries.GetAllPlan;

public sealed class GetAllPlanQueryHandler : IRequestHandler<GetAllPlanQuery, PaginationResult<Plan>>
{
    private readonly IPlanService _planService;

    public GetAllPlanQueryHandler(IPlanService planService)
    {
        _planService = planService;
    }

    public async Task<PaginationResult<Plan>> Handle(GetAllPlanQuery request, CancellationToken cancellationToken)
    {
        PaginationResult<Plan> plans = await _planService.GetAllAsync(request, cancellationToken);
        return plans;
    }
}