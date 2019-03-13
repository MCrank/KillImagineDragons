using KillImagineDragons.Songs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KillImagineDragons
{
    /*
      ## Instructions
        1. Define a class called `Song` that has a string property `Artist` and a string property `Name`. 
            Both properties should be required (invariant) in order to construct an instance of `Song`
        2. Define a List, named `goodSongs`, that will hold instances of `Song`.
        3. Define a List, named `allSongs`, that contains 12 instances of `Song`.
            Make sure that some of the songs are from the band Imagine Dragons. 
            If you're not familiar, here's a [list of their hits](https://www.billboard.com/articles/columns/rock/8462544/imagine-dragons-songs-best-hits-list).
        4. Once the set is populated with 12 instances of song, use Linq to filter the `allSongs` list for songs where the artist is **not** Imagine Dragons. Set `goodSongs` equal to the filtered result.
        5. Loop to print out all the good songs like:

        Elton John : Tiny Dancer
     */
    class Program
    {
        static void Main(string[] args)
        {
            var goodSongs = new List<Song>();
            var allSongs = new List<Song>
            {
                new Song("Imagine Dragons", "Radioactive"),
                new Song("Elvis", "Radioactive"),
                new Song("Biz Markie", "Just a Friend"),
                new Song("Imagine Dragons", "Bleeding Out"),
                new Song("Def Leppard", "Pour Some Sugar On Me"),
                new Song("Ratt", "Round and Round"),
                new Song("Scorpions", "Amsterdam"),
                new Song("Queensryche", "Radioactive"),
                new Song("Poison", "Radioactive"),
                new Song("Twisted Sister", "We're Not Gonna Take It"),
                new Song("White Snake", "Shots"),
                new Song("Quiet Riot", "C'mon Feel The Noise")
            };

            goodSongs = allSongs.Where(song => song.Artist != "Imagine Dragons").ToList();

            foreach (var song in goodSongs)
            {

                Console.WriteLine($"{song.Artist}:\t{song.Name}");
            }
            Console.ReadLine();
        }
    }
}
