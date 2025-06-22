using ConsoleClient.Dto;
using ConsoleClient.Model;
using ConsoleClient.Requests;
using ConsoleClient.ViewModel;

namespace ConsoleClient;

public static class UserData
{
    public static int GetProductId()
    {
        Console.WriteLine("Enter product ID: ");
        var productId = Convert.ToInt32(Console.ReadLine());
        return productId;
    }

    public static async Task<ProductDto> GetProduct()
    {
        Console.WriteLine("Enter product name: ");
        var productName = Console.ReadLine();
        Console.WriteLine("Enter product description: ");
        var productDescription = Console.ReadLine();
        Console.WriteLine("Enter product price: ");
        var productPrice = Convert.ToDecimal(Console.ReadLine());
        var bl = new BL();
        var categories = await bl.GetProductCategories();
        foreach (var category in categories)
        {
            Console.WriteLine(category);
        }
        Console.WriteLine("Enter product category: ");
        var productCategory = Console.ReadLine();

        int productCategoryId;

        var categoryId = categories.FirstOrDefault(c => c.Name == productCategory);
        if (categoryId != null)
        {
            productCategoryId = categories.FirstOrDefault(c => c.Name == productCategory).Id;
        }
        else
        {
            var category = new ProductCategory
            {
                Name = productCategory
            };
            await bl.AddNewCategory(category);
        }
        
        var productCategoryName = categories.FirstOrDefault(c => c.Name == productCategory);

        var product = new ProductDto
        {
            Name = productName,
            Description = productDescription,
            Price = productPrice,
            ProductCategoryId = productCategoryName.Id,
        };
        
        return product;
    }

    public static Product UpdateProduct(ProductDetailsVM productToUpdate)
    {
        
        Console.WriteLine("Enter product name: ");
        var productName = Console.ReadLine();
        Console.WriteLine("Enter product description: ");
        var productDescription = Console.ReadLine();
        Console.WriteLine("Enter product price: ");
        var productPrice = Convert.ToDecimal(Console.ReadLine());

        var product = new Product
        {
            Id = productToUpdate.Id,
            Name = productName,
            Description = productDescription,
            Price = productPrice,
            ProductCategoryId = productToUpdate.ProductDetailsCategoryVM.IdProductCategory
        };
        
        return product;
    }
}