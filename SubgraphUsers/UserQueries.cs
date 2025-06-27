using HotChocolate.ApolloFederation.Types;

namespace SubgraphUsers;

public class UserQueries
{
    public User GetUserById(int id) => new User { Id = id, Username = "User" + id };
}

[Key(nameof(Id))]
public class User
{
    public int Id { get; set; }
    public string Username { get; set; } = string.Empty;
}