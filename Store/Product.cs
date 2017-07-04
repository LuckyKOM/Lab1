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

      
        public  override bool IsValid()
        {
           bool valid = true;
            if ( (string.IsNullOrWhiteSpace(Title))||(!Price.HasValue)||(Price == 0))
                    valid = false;
            return valid;
           }
        public override string ToString()
        {
            string  FullDescription ="";
            FullDescription += "\nProduct ID: " + ProductId;
            FullDescription +="\nTitle: " + Title;
            FullDescription += "\nDescription: " + Description ;
            FullDescription += "\nPrice: " + Price;
            return FullDescription;
        }

    }
}
