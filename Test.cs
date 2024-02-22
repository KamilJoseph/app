// Test the list of tracks
public class MusicLibraryTests
{
    [Test]
    public void TestGetMusicTracks_ReturnsAtLeastOneTrackOrMore()
    {
        // Arrange
        var musicLibrary = new MusicLibrary();

        // Act
        List<Track> tracks = musicLibrary.GetMusicTracks("Pop");

        // Assert
        Assert.That(tracks.Count, Is.GreaterThan(0));
    }