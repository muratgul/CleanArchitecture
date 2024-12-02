using CleanArchitecture.Domain.Entities;
using EntityFrameworkCorePagination.Nuget.Pagination;
using MediatR;

namespace CleanArchitecture.Application.Features.PlanFeatures.Queries.GetAllPlan;

public sealed record GetAllPlanQuery(
    int PageNumber = 1,
    int PageSize = 10,
    string Search = "") : IRequest<PaginationResult<Plan>>;