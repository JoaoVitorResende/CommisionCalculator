using CommisionCalculator.Communication.Responses;
using CommisionCalculator.Domain.Entities;

namespace CommisionCalculator.Application.UseCases.Sales.Calculate
{
    public interface ICalculateCommisionUseCase
    {
        ResponseSales Execute(List<Sale> sales);
    }
}
