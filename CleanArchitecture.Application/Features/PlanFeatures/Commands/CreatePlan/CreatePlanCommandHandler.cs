using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.Dtos;
using MediatR;

namespace CleanArchitecture.Application.Features.PlanFeatures.Commands.CreatePlan;

public sealed class CreatePlanCommandHandler : IRequestHandler<CreatePlanCommand, MessageResponse>
{
    private readonly IPlanService _planService;

    public CreatePlanCommandHandler(IPlanService planService)
    {
        _planService = planService;
    }

    public async Task<MessageResponse> Handle(CreatePlanCommand request, CancellationToken cancellationToken)
    {
        await _planService.CreateAsync(request, cancellationToken);
        return new MessageResponse("Plan başarıyla kaydedildi");
    }
}