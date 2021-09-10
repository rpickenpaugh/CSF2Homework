using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Song
    {
        //fields

        //properties
        public string Artist { get; set; }
        public string Title { get; set; }
        public int LengthInSeconds { get; set; }
        //constructors
        public Song(string artist, string title, int lengthInSeconds)
        {
            Artist = artist;
            Title = title;
            LengthInSeconds = lengthInSeconds;
        }
        public Song()
        {

        }
        //methods
        public override string ToString()
        {
            return string.Format("Artist: {0}\n" +
                "Title: {1}\n" +
                "Length: {2} seconds\n",
                Artist, Title, LengthInSeconds);
        }

    }//end class
}
