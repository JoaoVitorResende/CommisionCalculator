using CommisionCalculator.Communication.Requests;
using CommisionCalculator.Communication.Responses;
using CommisionCalculator.Domain.Entities;
using CommisionCalculator.Exception.InvalidInput;

namespace CommisionCalculator.Application.UseCases.Sales.Calculate
{
    public class CalculateCommisionUseCase : ICalculateCommisionUseCase
    {
        public ResponseSales Execute(RequestSales req)
        {
            Validate(req);

            var sellerSales = req.Sales
                .GroupBy(saller => saller.Seller)
                .Select(group => new SellerSales
                {
                    Seller = group.Key,
                    Total = group.Sum(s => s.Value),
                    Commision = group.Sum(s => CalculateCommission(s.Value))
                }).ToList();

            return new ResponseSales { Sales = sellerSales };
        }

        private void Validate(RequestSales req)
        {
            var result = new SaleValidation().Validate(req);
            if(!result.IsValid)
            {
                var errors = result.Errors.Select(e => e.ErrorMessage).ToList();
                throw new InputInvalidException(errors);
            }
        }

        private decimal CalculateCommission(decimal value)
        {
            if(value < 100)
                return 0;
            else if(value < 500)
                return value * 0.01m;

            return value * 0.05m;
        }
    }
}
