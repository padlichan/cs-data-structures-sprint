using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_data_structures_sprint.Playlist
{
    public class Playlist
    {
        public LinkedList<Song> PlayListSongs = new();

        public void AddSong(Song? song)
        {
            if(song != null)
            PlayListSongs.AddLast(song);
        }

        public void PlaySong(int index)
        {
            if (PlayListSongs.Count > index)
            {
                var song = PlayListSongs.ElementAt(index);
                Console.WriteLine($"Playing {song.Title} for {song.duration}");
            }
        }

        public List<Song> AllSongs()
        {
            return PlayListSongs.ToList();
        }

        public void RemoveSong(Song song)
        {
            PlayListSongs.Remove(song);
        }

        public void RemoveSong(string title)
        {
            var song = PlayListSongs.Where(s => s.Title == title).First();
            PlayListSongs.Remove(song);
        }

    }
}
