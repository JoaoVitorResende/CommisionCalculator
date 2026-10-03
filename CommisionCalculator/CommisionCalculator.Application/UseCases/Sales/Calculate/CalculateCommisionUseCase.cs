using CommisionCalculator.Communication.Responses;
using CommisionCalculator.Domain.Entities;

namespace CommisionCalculator.Application.UseCases.Sales.Calculate
{
    public class CalculateCommisionUseCase : ICalculateCommisionUseCase
    {
        public ResponseSales Execute(List<Sale> sales)
        {
            var sellerSales = sales
                .GroupBy(saller => saller.Seller)
                .Select(group => new SellerSales
                {
                    Seller = group.Key,
                    Total = group.Sum(s => s.Value),
                    Commision = group.Sum(s => CalculateComission(s.Value))
                }).ToList();

            return new ResponseSales { Sales = sellerSales };
        }

        private decimal CalculateComission(decimal value)
        {
            if(value < 100)
                return 0;
            else if(value < 500)
                return value * 0.01m;

            return value * 0.05m;
        }
    }
}
