namespace GitTweet;

/// <summary>
/// Twitter client for posting media and status updates.
/// </summary>
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

	if (body == "")
	{
	}
    
        return false;
    }
}

