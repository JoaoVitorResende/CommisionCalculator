using CommisionCalculator.Domain.Entities;
using System.Text.Json.Serialization;

namespace CommisionCalculator.Communication.Requests
{
    public class RequestSales
    {
        [JsonPropertyName("vendas")]
        public List<Sale> Sales { get; set; } = [];
    }
}
