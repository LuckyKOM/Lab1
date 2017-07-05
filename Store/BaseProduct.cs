namespace Store
{
    public abstract class BaseProduct
    {
        private string vTitle;
        public string Title { get; set; }
        public int ProductId { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public abstract bool IsValid();

    }
}
