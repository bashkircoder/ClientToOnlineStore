using System.Text.Json.Serialization;

namespace ConsoleClient.Model;

public class Product
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    [JsonPropertyName("name")]
    public required string Name { get; set; }
    
    [JsonPropertyName("description")]
    public required string Description { get; set; }
    
    [JsonPropertyName("price")]
    public required decimal Price { get; set; }
    
    [JsonPropertyName("productCategoryId")]
    public required int ProductCategoryId { get; set; }
    
    [JsonPropertyName("productCategory")]
    public ProductCategory? ProductCategory { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, Description: {Description}, Price: {Price}";
    }
}