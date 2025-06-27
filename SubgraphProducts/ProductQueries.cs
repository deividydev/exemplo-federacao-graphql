using HotChocolate.ApolloFederation.Types;

namespace SubgraphProducts;

public class ProductQueries
{
    public Product GetProductById(int id) => new Product { Id = id, Name = "Product " + id };
}

[Key(nameof(Id))]
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
}