using CleanArchitecture.Domain.Dtos;
using MediatR;

namespace CleanArchitecture.Application.Features.PlanFeatures.Commands.CreatePlan;

public sealed record CreatePlanCommand(
    string planNr
) : IRequest<MessageResponse>;
