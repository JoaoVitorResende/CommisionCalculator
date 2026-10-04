using System.Text.Json.Serialization;

namespace CommisionCalculator.Domain.Entities
{
    public class SellerSales
    {
        [JsonPropertyName("vendedor")]
        public string Seller { get; set; } = string.Empty;
        [JsonPropertyName("total")]
        public decimal Total {  get; set; }
        [JsonPropertyName("comissao")]
        public decimal Commision { get; set; }
    }
}
