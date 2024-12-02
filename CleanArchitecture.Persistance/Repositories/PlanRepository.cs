using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Repositories;
using CleanArchitecture.Persistance.Context;
using GenericRepository;

namespace CleanArchitecture.Persistance.Repositories;

public class PlanRepository : Repository<Plan, AppDbContext>, IPlanRepository
{
    public PlanRepository(AppDbContext context) : base(context) { }
}