using System.Collections.Generic;

namespace Store
{
    public  interface  IRepository
    {
        Product RetreiveProduct(int productId);
        List<Product> RetreiveAllProducts();
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);
    }
}
