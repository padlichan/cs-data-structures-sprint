namespace cs_data_structures_sprint.Playlist
{
    public class UI
    {

        public Playlist playlist;
        public void PrintActions()
        {
            Song? currentSong = playlist.GetCurrentSong();
            if (currentSong != null) Console.WriteLine($"Current song: {currentSong.Title}");
            else Console.WriteLine("No current song");
            Console.WriteLine($"Play next (E), Play previous (Q), Play current (W), List songs (L), Delete current song (D), Menu (M), Exit (X) ");
        }

        public UserAction PromptForAction()
        {
            PrintActions();
            char userInput = Console.ReadKey().KeyChar;
            switch (char.ToUpper(userInput))
            {
                case 'E':
                    return UserAction.PlayNext;
                case 'Q':
                    return UserAction.PlayPrevious;
                case 'W':
                    return UserAction.PlayCurrent;
                case 'L':
                    return UserAction.ListAll;
                case 'D':
                    return UserAction.DeleteCurrentSong;
                case 'M':
                    return UserAction.Menu;
                case 'X':
                    return UserAction.Exit;
                default: { Console.WriteLine("\nUnrecognised input.\n"); return PromptForAction(); }
            }
        }
    }



    public enum UserAction
    {
        PlayNext,
        PlayPrevious,
        PlayCurrent,
        ListAll,
        DeleteCurrentSong,
        Menu,
        Exit
    }
}
