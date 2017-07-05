
namespace Store
{
    public  static  class Validation
    {
        public static bool IsNewProduct(Product product, WareHouse wareHouse)
        {
            bool isNew = true;
            foreach (Product currentProduct in wareHouse.ProductList)
            {
                if ( (currentProduct.Title.ToUpper() == product.Title.ToUpper()) )
                    isNew =  false;
            }
            return isNew;
        }
        public static bool ProductExists(int prodId, WareHouse wareHouse)
        {

            bool exists = false;
            foreach (Product currentProduct in wareHouse.ProductList)
            {
                if (currentProduct.ProductId == prodId )
                    exists = true;
            }
            return exists;

        }
    }
}
