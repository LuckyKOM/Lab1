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

            users:
            string userName = Console.ReadLine();
            if (!users.ContainsKey(userName))
            {
                Console.WriteLine("Invalid user ID");
                goto users;
            }

            Users currentUser = users[userName];
            password:
            Console.WriteLine("Enter password: ");
            int password = int.Parse(Console.ReadLine());
            if (!(password == currentUser.Password))
            {
                Console.WriteLine("Wrong password");
                goto password;
            }

            if (userName == "admin")
            {
                var wareHouse = new WareHouse();
                Selection:
                Console.WriteLine("\nPlease, select the action you want to perform (1 to 5):");
                Console.WriteLine("1: Add new goods to warehouse \n2: Modify existing goods ");
                Console.WriteLine("3: List available goods  \n4: Delete goods");
                Console.WriteLine("5: Exit from the application");
                int action = int.Parse(Console.ReadLine());
                switch (action)
                {
                    case 1: //Add product
                        var newProduct = new Product();
                        wareHouse.AddProduct(newProduct);
                        AddMore:
                        Console.WriteLine("\nDo you want to add more products (y/n)? ");
                        string answer = Console.ReadLine();
                        if (0 == string.Compare(answer, "y", true))
                            goto case 1;
                        else if (0 == string.Compare(answer, "n", true))
                            goto Selection;
                        else
                        {
                            Console.WriteLine("Invalid selection");
                            goto AddMore;
                        }

                    case 2: // Update
                        Console.WriteLine("\nSpecify Product ID or type '0' to return to main menu.");

                        int productId = int.Parse(Console.ReadLine());
                        if (productId == 0)
                            goto Selection;
                        else
                        {
                            Product updProduct = wareHouse.RetreiveProduct(productId);
                            Console.WriteLine(updProduct);
                            Console.WriteLine("\nSpecify new product's parameters.");
                            wareHouse.UpdateProduct(updProduct);

                            goto Selection;
                        }

                    case 3: // View products
                        foreach (Product product in wareHouse.ProductList)
                            Console.WriteLine(product);
                        goto Selection;

                    case 4: //Delete 
                        Deletion:
                        Console.WriteLine("\nSpecify product ID to be deleted.");
                        int prodId = int.Parse(Console.ReadLine());
                        if (Validation.ProductExists(prodId, wareHouse))
                        {
                            Product product = wareHouse.RetreiveProduct(prodId);
                            int count1 = wareHouse.ProductList.Count;
                            wareHouse.DeleteProduct(product);
                            int count = wareHouse.ProductList.Count;
                        }
                        else
                        {
                            Console.WriteLine("There is no product with the given product ID.");
                            goto Deletion;
                        }
                        goto Selection;

                    case 5:  //Exit
                        break;
                    
                    default:
                        Console.WriteLine("Invalid selection");
                        goto Selection;

                }
            }
            else if (userName == "manager")
             Console.WriteLine("There is a vacancy for manager position. Try this option later");
             Console.WriteLine("Press any key to exit");
             Console.ReadLine();

        }
        
    }
}
