using HotChocolate.ApolloFederation.Types;

namespace SubgraphUsers;

[ExtendObjectType("Query")]
public class UserQueries
{
    public User GetUserById(int id) => new User { Id = id, Username = "User" + id };
}

[Key("id")]
public class User
{
    public int Id { get; set; }
    public string Username { get; set; } = string.Empty;
}