using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kill_Nickelback
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define a List, named goodSongs, that will hold instances of Song.
            var goodSongs = new List<Song>();

            //Define a HashSet, named allSongs, that contains 7 instances of Song.
            //Make sure that some of the songs are from the band Nickelback. You can see a list of their greatest hits on Amazon.
            var allSongs = new HashSet<Song>
            {
                new Song("Nickleback", "How You Remind Me"),
                new Song("Ed Sheeran", "Shape of You"),
                new Song("Selena Gomez", "Bad Liar"),
                new Song("DJ Khaled", "Wild Thoughts"),
                new Song("Future", "Mask Off"),
                new Song("Kendrick Lemar", "DNA"),
                new Song("Cardi B", "Bodak Yellow"),
                new Song("Nickleback", "Photograph")
            };

            //Once the set is populated with 7 instances, iterate over the set of songs, and check if the band name is "Nickelback".
            foreach (var song in allSongs)
            {
                Console.WriteLine($"{song}");
            }

            //If the band is not Nickelback, then add it to the goodSongs list.

            //Use another foreach loop to print out all the good songs.
            Console.ReadLine();
        }
    }
}
