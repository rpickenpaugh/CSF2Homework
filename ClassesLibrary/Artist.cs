using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ClassesLibrary
{
    public class Artist
    {
        //fields

        //properties


        public Song[] Tracks { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }

        //constructors
        public Artist()
        {

        }
        public Artist(Song[] tracks, string title, string genre, string artist, int lengthInSeconds)
        {
            Tracks = tracks;
            Title = title;
            Genre = genre;
        }//end fqctor

        //methods
        public override string ToString()
        {
            string songs = "";
            foreach (Song item in Tracks)
            {
                songs += item.Title + "\n";
            }

            return string.Format(
                "Song: {0}\n" + 
                "Tracks: {1}\n"+ 
                "Title: {2}\n"+
                "Genre: {3}\n",
                songs, Tracks, Title, Genre);
        }



    }//end class
}
