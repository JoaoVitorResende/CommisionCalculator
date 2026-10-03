namespace CommisionCalculator.Domain.Entities
{
    public class SellerSales
    {
        public string Seller { get; set; } = string.Empty;
        public decimal Total {  get; set; }
        public decimal Commision { get; set; }
    }
}
