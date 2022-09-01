namespace GitTweet;

public class TwitterTests
{
    [Fact]
    public void Post_EmptyStatus_Fails()
    {
	var mockClient = new Mock<ITwitterClient>();
	var twitter = new Twitter(mockClient.Object);
	var result = twitter.PostTweet("");

	Assert.False(result);
    }

    /*
    [Fact]
    public void Method_Scenario_Expectation()
    {
        // Arrange
        // Act
        // Assert
    }
    */
}
