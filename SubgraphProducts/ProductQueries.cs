using HotChocolate.ApolloFederation.Types;

namespace SubgraphProducts;

[ExtendObjectType("Query")]
public class ProductQueries
{
    public Product GetProductById(int id) => new Product { Id = id, Name = "Product " + id };
}

[Key("id")]
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
}