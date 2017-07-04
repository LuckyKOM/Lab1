using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//public enum StateOption
//{
  //  Active,
    //Deleted
//}
namespace Store
{
   public  static  class Validation
    {
        // public StateOption StateOfEntity { get; set; }
        //public bool Changed { get; set; }
        //public bool Valid
        // {
        //   get { return Validate(); }
        // }
        // public bool New { get; set; }
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
       // public static bool IsChangedProduct(Product product, int productId)
       // {

       // }
    }
}
