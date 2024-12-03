using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_data_structures_sprint.Playlist
{
    public class Album(string name,string artist)
    {
        string Name { get; set; } = name;
        string Artist { get; set; } = artist;
        List<Song> Songs { get; set; } = new();

        public void AddSong(Song song)
        {
            Songs.Add(song);
        }

        public void AddSong(string title, double duration)
        {
            Songs.Add(new Song(title, duration));
        }

        public Song? FindSong(string title)
        {
            var songCheck = Songs.Where(song => song.Title == title).ToList();
            if (songCheck.Count == 0) return null;

            return songCheck.First();
        }

    }

}
