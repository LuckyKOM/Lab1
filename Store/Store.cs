using System;
using System.Collections.Generic;

namespace Store
{
    class Store
    {

        static void Main(string[] args)
        {

            var users = new Dictionary<string, Users>
            {
                {"admin", new Users ("Store administrator", 1234 ) },
                { "manager", new Users ("Warehouse manager", 5678  ) }
            };
            Console.WriteLine("Hello, welcome to Internet Store!");
            Console.WriteLine("Please, enter your user name:");
            string userName = Console.ReadLine();

            while (!users.ContainsKey(userName))
          {
                Console.WriteLine("Invalid user ID");
                userName = Console.ReadLine();
           }
        
            Users currentUser = users[userName];
            Console.WriteLine("Enter password: ");
            int password = int.Parse(Console.ReadLine());
            while (password != currentUser.Password)
            {
                Console.WriteLine("Wrong password");
                password = int.Parse(Console.ReadLine());
            }
               
            if (userName == "admin")
            {
                var wareHouse = new WareHouse();
                bool goMain = true;
                while (goMain)
                {
                    Console.WriteLine("\nPlease, select the action you want to perform (1 to 5):");
                    Console.WriteLine("1: Add new goods to warehouse \n2: Modify existing goods ");
                    Console.WriteLine("3: List available goods  \n4: Delete goods");
                    Console.WriteLine("5: Exit from the application");
                    int action = int.Parse(Console.ReadLine());
                    switch (action)
                    {
                        case 1: //Add product
                            bool goAdd = true;
                            while (goAdd)
                            {
                                var newProduct = new Product();
                                wareHouse.AddProduct(newProduct);
                                Console.WriteLine("\nDo you want to add more products (y/n)? ");
                                string answer = Console.ReadLine();
                                if (0 == string.Compare(answer, "y", true))
                                    goAdd = true ;
                                else if (0 == string.Compare(answer, "n", true))
                                    goAdd= false;
                                else                    
                                        Console.WriteLine("Invalid selection.");                                                                      
                            }
                            break;
                        case 2: // Update
                            Console.WriteLine("\nSpecify Product ID or type '0' to return to main menu.");
                            int  productId = 0;
                            string stringId = Console.ReadLine();
                            if (!string.IsNullOrWhiteSpace(stringId)) productId = int.Parse(stringId);
                            if (productId != 0)                                                      
                            {
                                Product updProduct = wareHouse.RetreiveProduct(productId);
                                Console.WriteLine(updProduct);
                                Console.WriteLine("\nSpecify new product's parameters.");
                                wareHouse.UpdateProduct(updProduct);
                            }
                            break;
                        case 3: // View products
                            foreach (Product product in wareHouse.ProductList)
                                Console.WriteLine(product);
                            break;

                        case 4: //Delete 
                            bool goDel = true;
                            while (goDel)
                            {
                                Console.WriteLine("\nSpecify product ID to be deleted.");
                                int prodId = int.Parse(Console.ReadLine());
                                if (Validation.ProductExists(prodId, wareHouse))
                                {
                                    Product product = wareHouse.RetreiveProduct(prodId);
                                   // int count1 = wareHouse.ProductList.Count;
                                    wareHouse.DeleteProduct(product);
                                   // int count = wareHouse.ProductList.Count;
                                    goDel = false;
                                }
                                else
                                    Console.WriteLine("There is no product with the given product ID.");
                            }
                            break;

                        case 5:  //Exit
                            goMain = false;
                            break;

                        default:
                            Console.WriteLine("Invalid selection");
                            break;
                    }
                }
            } // end while 
            else if (userName == "manager")
                Console.WriteLine("There is a vacancy for manager position. Try this option later");
             Console.WriteLine("Press any key to exit");
             Console.ReadLine();

        }
        
    }
}
