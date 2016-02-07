using System;
using System.Collections.Generic;

class Cd
{
  public string Title;
  public string Artist;
  public int Price;

  public Cd(string albumTitle, string albumArtist, int albumPrice = 10)
  {
    Title = albumTitle;
    Artist = albumArtist;
    Price = albumPrice;
  }
}

public class Program
{
  public static void Main()
  {
    Cd firstCd = new Cd("Master of Reality", "Black Sabbath", 10);
    Cd secondCd = new Cd("Electric Ladyland", "Jimi Hendrix", 10);
    Cd thirdCd = new Cd("Nevermind", "Nirvana", 10);

    List<Cd> Cds = new List<Cd>() { firstCd, secondCd, thirdCd };

    foreach (Cd album in Cds)
    {
      Console.WriteLine(album.Title);
      Console.WriteLine("By " + album.Artist);
      Console.WriteLine("Price: $" + album.Price);
    }
  }
}