using CommisionCalculator.Communication.Requests;
using FluentValidation;

namespace CommisionCalculator.Application.UseCases.Sales
{
    public class SaleValidation: AbstractValidator<RequestSales>
    {
        public SaleValidation()
        {
            RuleFor(request => request.Sales).NotEmpty().WithMessage("O input nao pode ser vazio");

            RuleForEach(request => request.Sales).ChildRules(sale =>
            {
                sale.RuleFor(s => s.Seller)
                .NotEmpty()
                .WithMessage("O nome do vendedor nao pode ser vazio");

                sale.RuleFor(s => s.Value)
                .GreaterThan(0)
                .WithMessage("O valor nao pode ser zero");
            });
        }
    }
}
