using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ClassesLibrary
{
    public class Artist : Song
    {
        //fields

        //properties


        public ArrayList[Song] Tracks { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }

        //constructors
        public Artist()
        {

        }
        public Artist(ArrayList[Song] tracks, string title, string genre, string artist, int lengthInSeconds) : base(artist, title, lengthInSeconds)
        {
            Tracks = tracks;
            Title = title;
            Genre = genre;
        }//end fqctor

        //methods
        public override string ToString()
        {
            return string.Format(
                "Song: {0}\n",
                "Tracks: {1}\n",
                "Title: {2}\n",
                "Genre: {3}\n",
                , Tracks, Title, Genre);
        }



    }//end class
}
