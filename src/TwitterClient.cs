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
