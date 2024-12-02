using CleanArchitecture.Application.Features.PlanFeatures.Commands.CreatePlan;
using CleanArchitecture.Application.Features.PlanFeatures.Queries.GetAllPlan;
using CleanArchitecture.Domain.Entities;
using EntityFrameworkCorePagination.Nuget.Pagination;

namespace CleanArchitecture.Application.Services;

public interface IPlanService
{
    Task CreateAsync(CreatePlanCommand request, CancellationToken cancellationToken);
    Task<PaginationResult<Plan>> GetAllAsync(GetAllPlanQuery request, CancellationToken cancellationToken);
}
