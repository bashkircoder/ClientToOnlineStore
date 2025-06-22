using ConsoleClient.Requests;

namespace ConsoleClient;

public static class MainMenu
{
    public static async Task ShowMainMenu()
    {
        do
        {
            Console.WriteLine("1. Show all products");
            Console.WriteLine("2. Show product by Id");
            Console.WriteLine("3. Add new product");
            Console.WriteLine("4. Update product");
            Console.WriteLine("5. Delete product");
            Console.WriteLine("6. Exit");
            int choice;
            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            switch (choice)
            {
                case 1:
                {
                    var bl = new BL();
                    var products = await bl.GetAllProducts();
                    Helper.PrintProductVmList(products);
                    break;
                }

                case 2:
                {
                    var productId = UserData.GetProductId();
                    var bl = new BL();
                    var product = await bl.GetProductDetailsById(productId);
                    
                    Helper.PrintProductDetailsVm(product);
                    break;
                }
                case 3:
                {
                    var product = await UserData.GetProduct();
                    var bl = new BL();
                    await bl.AddNewProduct(product);
                    break;
                }
                case 4:
                {
                    var productId = UserData.GetProductId();
                    var bl = new BL();
                    var productToUpdate = await bl.GetProductDetailsById(productId);
                    var updatedProduct = UserData.UpdateProduct(productToUpdate);
                    await bl.UpdateProduct(updatedProduct);
                    break;
                }
                case 5:
                {
                    var productId = UserData.GetProductId();
                    var bl = new BL();
                    await bl.DeleteProduct(productId);
                    break;
                }
                case 6:
                {
                    return;
                }
                default:
                {
                    return;
                }
            }
        } while (true);
    }
}