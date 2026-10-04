using CommisionCalculator.Domain.Entities;
using System.Text.Json.Serialization;

namespace CommisionCalculator.Communication.Responses
{
    public class ResponseSales
    {
        [JsonPropertyName("vendas")]
        public List<SellerSales> Sales { get; set; } = [];
    }
}
