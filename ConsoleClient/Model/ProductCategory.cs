﻿namespace ConsoleClient.Model;

public class ProductCategory
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}";
    }
}