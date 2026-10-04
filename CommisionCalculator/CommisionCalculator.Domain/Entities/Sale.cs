using System.Text.Json.Serialization;

namespace CommisionCalculator.Domain.Entities
{
    public class Sale
    {
        [JsonPropertyName("vendedor")]
        public string Seller { get; set; } = string.Empty;
        [JsonPropertyName("valor")]
        public decimal Value { get; set; } 
    }
}
