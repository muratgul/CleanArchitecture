using FluentValidation;

namespace CleanArchitecture.Application.Features.PlanFeatures.Commands.CreatePlan;

public sealed class CreatePlanCommandValidator : AbstractValidator<CreatePlanCommand>
{
    public CreatePlanCommandValidator()
    {
        RuleFor(p => p.planNr).NotEmpty().WithMessage("Plan no alanı boş olamaz");
    }
}