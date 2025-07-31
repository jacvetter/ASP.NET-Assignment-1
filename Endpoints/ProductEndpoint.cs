using Assignment_1.Models;

namespace Assignment_1.Endpoints;

public static class ProductEndpoint
{
    //in memory list
    private static readonly List<Product> Products = new();
    private static int nextId = 1;

    //routing
    public static void MapProductEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapPost("/products", CreateProduct);
        app.MapGet("/products", GetAllProducts);
        app.MapGet("/products/{id:int}", GetProductById);
        app.MapDelete("/products/{id:int}", DeleteProduct);
    }

    private static IResult CreateProduct(Product product)
    {
        product.Id = nextId++;
        Products.Add(product);
        return Results.Ok(new
        {
            message = $"Product was created:",
            newProduct = product
        });
    }

    private static IResult GetAllProducts()
    {
        return Results.Ok(Products);
    }

    private static IResult GetProductById (int id)
    {
        var product = Products.FirstOrDefault(p => p.Id == id);
        
        if (product is null)
        {
            return Results.NotFound($"Product with ID {id} was not found.");
        }

        return Results.Ok(product);
    }

    private static IResult DeleteProduct(int id)
    {
        var product = Products.FirstOrDefault(p => p.Id == id);

        if (product is null)
        {
            return Results.NotFound($"Product with ID {id} was not found.");
        }

        Products.Remove(product);
        return Results.Ok(new
        {
            message = $"Product was deleted:",
            deletedProduct = product
        });
    }
}
