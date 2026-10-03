using CommisionCalculator.Domain.Entities;

namespace CommisionCalculator.Communication.Requests
{
    public class RequestSales
    {
        public List<Sale> Sales { get; set; } = [];
    }
}
