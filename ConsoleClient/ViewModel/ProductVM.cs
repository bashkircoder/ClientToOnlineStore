namespace ConsoleClient.ViewModel;

public class ProductVM
{
    public required int ProductId { get; init; }
    public required string Name { get; init; }
    public required decimal Price { get; init; }
    public required string NameCategory { get; init; }

    public override string ToString()
    {
        return $"Id: {ProductId}, Name: {Name}, Price: {Price}, Category: {NameCategory}";
    }
}