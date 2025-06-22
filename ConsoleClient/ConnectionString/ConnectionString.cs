using System.Text.Json.Serialization;

namespace ConsoleClient.ConnectionString;

public class ConnectionString
{
    [JsonPropertyName("base_address")]
    public string? BaseAddress { get; init; }
}