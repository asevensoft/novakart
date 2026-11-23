namespace NovaKart.Domain.Entities
{
    public class ProductImage
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public string Url { get; set; } = string.Empty;
        public Product Product { get; set; } = null!;
        public string AltText { get; set; } = string.Empty;
    }
}