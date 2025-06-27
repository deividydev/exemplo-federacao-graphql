using SubgraphProducts;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer()
    .AddQueryType(d => d.Name("Query"))
    .AddTypeExtension<ProductQueries>()
    .AddType<Product>()
    .AddApolloFederation();

var app = builder.Build();
app.MapGraphQL();
app.Run("http://0.0.0.0:80");
