using CommisionCalculator.Communication.Requests;
using CommisionCalculator.Communication.Responses;

namespace CommisionCalculator.Application.UseCases.Sales.Calculate
{
    public interface ICalculateCommisionUseCase
    {
        ResponseSales Execute(RequestSales req);
    }
}
