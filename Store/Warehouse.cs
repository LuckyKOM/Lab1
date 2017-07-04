using System;
using System.Collections.Generic;

namespace Store
{

    public class WareHouse : IRepository
    {
        public List<Product> ProductList { get; set; }
          public WareHouse()
        {
            ProductList = RetreiveAllProducts();
        }

        public  List<Product> RetreiveAllProducts()
        {
            var productList = new List<Product>()
           {
           new Books()
            {
                ProductId = 10,
                Title = "War and Piece",
                Description = "Epic novel",
                Author = "L. Tosltoy",
                YearOfPublish = 2010,
                Price = 189
            },

         new TVsets()
            {
                ProductId = 20,
                Title = "Sony KD 55",
                Description = "LCD TV set",
                Price = 4000
            },
            new TVsets()
            {
                ProductId = 30,
                Title = "Samsung UE 43K",
                Description = "LCD TV set",
                Price = 5000
            }
        };
            return productList;
        }

        public Product RetreiveProduct(int productId)
        {
            List<Product> productList = this.ProductList;
            if (productList.Exists(x => x.ProductId == productId))
                return productList.Find(x => x.ProductId == productId);
            else
                return new Product();

        }
    
        public void AddProduct(Product product)
        {
           Repeat1:
                Console.WriteLine("Please enter title of product: ");
                string title = Console.ReadLine();
                product.Title = title;

                if (!(Validation.IsNewProduct(product, this)))
                {
                    Console.WriteLine("Product with this title already exists.");
                     goto Repeat1;
                }
                else 
                {
                   product =  CommonCode.Description(product);
                if (product.IsValid())
                {
              
                    int  prodId = 0;
                    foreach (var pd in this.ProductList)
                    {
                        if (pd.ProductId > prodId)
                            prodId = pd.ProductId;
                    }
                    prodId ++;
                    product.ProductId = prodId;
                    this.ProductList.Add(product);
                }
                }                
        }

        public void DeleteProduct(Product product)
        {
            this.ProductList.Remove(product); 
        }

        public void UpdateProduct(Product product)
        {
            Repeat:
            Console.WriteLine("Enter title of product");
            string title = Console.ReadLine();
            product.Title = title;
            product = CommonCode.Description (product);
            if (product.IsValid())
              {
                if (!(Validation.IsNewProduct(product, this)))
                {
                    Console.WriteLine("Product with this title already exists.");
                    goto Repeat;
                }
             }
            else
            {
                Console.WriteLine("Incorrect product characteristics");
                goto Repeat; 
            }
        }
    }
}
