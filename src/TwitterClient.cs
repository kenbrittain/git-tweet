using Refit;

namespace GitTweet;

/// <summary>
/// Twitter API client.
/// </summary>
public interface ITwitterClient
{
    [Post("/2/tweets")]
    bool PostTweet(string body);
}

public class Twitter
{
    private ITwitterClient _client;

    public Twitter(ITwitterClient client)
    {
        _client = client ?? throw new ArgumentNullException(nameof(client));
    }

    public bool PostTweet(string body)
    {
        if (body == null)
        {
            throw new ArgumentNullException(nameof(body));
	}
    
        return false;
    }
}

