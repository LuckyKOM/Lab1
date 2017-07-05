using System.Text;

namespace Store
{
    public  class Product :BaseProduct

    {
        public Product()
        {

        }
        public Product(string title)
        {
            Title = title;
        }
        public Product (int productId)
        {
            ProductId = productId;       
        }
   
        public override bool IsValid()
        {
           bool valid = true;
            if (string.IsNullOrWhiteSpace(Title)||Price <= 0)
                    valid = false;
            return valid;
           }
        public override string ToString()
        {
            var fullDescription = new StringBuilder("");
            fullDescription.Append("\nProduct ID: " + ProductId);
            fullDescription.Append("\nTitle: " + Title);
            fullDescription.Append("\nDescription: " + Description);
            fullDescription.Append("\nPrice: " + Price);
            return fullDescription.ToString();
            
        }

    }
}
