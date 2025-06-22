using ConsoleClient.ViewModel;

namespace ConsoleClient;

public static class Helper
{
    public static void PrintProductVmList(List<ProductVM> products)
    {
        foreach (var product in products)
        {
            Console.WriteLine(product);
        }
    }
    
    public static void PrintProductDetailsVm(ProductDetailsVM product)
    {
            Console.WriteLine(product);
    }
}