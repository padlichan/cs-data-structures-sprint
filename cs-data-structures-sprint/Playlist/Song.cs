namespace cs_data_structures_sprint.Playlist
{
    public record Song(string Title, double duration)
    {
        public override string ToString()
        {
            return $"{Title}: {duration}";
        }
    }
}
