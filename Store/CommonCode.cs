using System;

namespace Store
{
    public static class CommonCode
    {
        public static Product Description(Product product)
        {          
                Console.WriteLine("\nProduct description:");
                string description = Console.ReadLine();
                Console.WriteLine("\nProduct price:");
               decimal price = 0;
               string sprice = Console.ReadLine();
               if (!string.IsNullOrWhiteSpace(sprice)) price = decimal.Parse(sprice);     
                product.Description = description;
                product.Price = price;
                return product;                      
        }
    }
}
