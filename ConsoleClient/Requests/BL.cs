using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using ConsoleClient.ConnectionString;
using ConsoleClient.Dto;
using ConsoleClient.Model;
using ConsoleClient.ViewModel;

namespace ConsoleClient.Requests;

public class BL
{
    private HttpClient httpClient = new HttpClient
    {
        BaseAddress = new Uri(BaseAddress.GetBaseAddress())
    };
    
    public async Task<List<ProductVM>?> GetAllProducts()
    {
        var responce = await httpClient.GetFromJsonAsync<List<ProductVM>>("products");
        return responce;
    }
    
    public async Task<ProductDetailsVM?> GetProductDetailsById(int id)
    {
        var responce = await httpClient.GetFromJsonAsync<ProductDetailsVM>($"products/{id}");
        
        return responce;
    }
    
    public async Task AddNewProduct(ProductDto product)
    {
        var responseMessage = await httpClient.PostAsJsonAsync("products", product);
    }
    
    public async Task UpdateProduct(Product product)
    {
        var responce = await httpClient.PutAsJsonAsync("products", product);
    }
    
    public async Task DeleteProduct(int id)
    {
        var responce = await httpClient.DeleteAsync($"products/{id}");
    }

    public async Task<List<ProductCategory>> GetProductCategories()
    {
        var responce = await httpClient.GetFromJsonAsync<List<ProductCategory>>("categories");
        
        return responce;
    }
    
    public async Task AddNewCategory(ProductCategory category)
    {
        var responce = await httpClient.PostAsJsonAsync("categories", category);
    }
}