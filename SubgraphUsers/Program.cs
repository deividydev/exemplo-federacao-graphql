using SubgraphUsers;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer()
    .AddQueryType(d => d.Name("Query"))
    .AddTypeExtension<UserQueries>()
    .AddType<User>()
    .AddApolloFederation();

var app = builder.Build();
app.MapGraphQL();
app.Run("http://0.0.0.0:80");
