using System.Text.Json;

namespace ConsoleClient.ConnectionString;

public static class BaseAddress
{
    public static string GetBaseAddress()
    {
        var sr = new StreamReader("appsettings.json");
        var json = sr.ReadToEnd();
        var address = JsonSerializer.Deserialize<ConnectionString>(json);
        
        return address.BaseAddress;
    }
}