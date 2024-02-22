using System;
using System.Collections.Generic;

class Program
{
     public static void Main(string[] args)
    {
        // Call the GetMusicTracks method
        List<Track> tracks = GetMusicTracks();

        // Display the retrieved tracks
        Console.WriteLine("Retrieved Music Tracks:");
        foreach (var track in tracks)
        {
            Console.WriteLine($"Artist: {track.Artist}, Title: {track.Title}, Genre: {track.Genre}, Duration: {track.Duration}");
        }
    }

  static List<Track> GetMusicTracks () 
  {
    // code to be executed
    var tracks = new List<Track>(){
         new Track { Artist = "Artist2", Title = "Title2", Genre = "Pop", Duration = 210 },
        new Track { Artist = "Artist3", Title = "Title3", Genre = "Jazz", Duration = 0 }
    }

    var validTracks = new List<Track>();
        foreach (var track in tracks)
        {
            if (track.Duration > 0)
            {
                validTracks.Add(track);
            }
        }

        return validTracks;
    }

  }
