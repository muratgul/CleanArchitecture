using AutoMapper;
using CleanArchitecture.Application.Features.PlanFeatures.Commands.CreatePlan;
using CleanArchitecture.Application.Features.PlanFeatures.Queries.GetAllPlan;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Repositories;
using CleanArchitecture.Persistance.Context;
using EntityFrameworkCorePagination.Nuget.Pagination;
using GenericRepository;

namespace CleanArchitecture.Persistance.Services;

public sealed class PlanService : IPlanService
{
    private readonly AppDbContext _context;
    private readonly IPlanRepository _planRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public PlanService(AppDbContext context, IMapper mapper, IPlanRepository planRepository, IUnitOfWork unitOfWork)
    {
        _context = context;
        _mapper = mapper;
        _planRepository = planRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task CreateAsync(CreatePlanCommand request, CancellationToken cancellationToken)
    {        
        Plan plan = _mapper.Map<Plan>(request);

        await _planRepository.AddAsync(plan, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }

    public async Task<PaginationResult<Plan>> GetAllAsync(GetAllPlanQuery request, CancellationToken cancellationToken)
    {
        PaginationResult<Plan> plans = 
            await _planRepository
            .GetWhere(p=> p.planNr.ToLower().Contains(request.Search.ToLower()))     
            .OrderBy(p=> p.planNr)
            .ToPagedListAsync(request.PageNumber, request.PageSize, cancellationToken);
        return plans;
    }

    
}
