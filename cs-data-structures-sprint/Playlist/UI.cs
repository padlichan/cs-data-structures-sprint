namespace cs_data_structures_sprint.Playlist
{
    public static class UI
    {

        public static Playlist playlist;
        public static void PrintActions()
        {
            Song? currentSong = playlist.GetCurrentSong();
            if (currentSong != null) Console.WriteLine($"Current song: {currentSong.Title}");
            else Console.WriteLine("No current song");
            Console.WriteLine($"Play next (E), Play previous (Q), Play current (W), List songs (L), Delete current song (D), Menu (M), Exit (X) ");
        }

        public static Action PromptForAction()
        {
            PrintActions();
            char userInput = Console.ReadKey().KeyChar;
            switch (char.ToUpper(userInput))
            {
                case 'E':
                    return Action.PlayNext;
                case 'Q':
                    return Action.PlayPrevious;
                case 'W':
                    return Action.PlayCurrent;
                case 'L':
                    return Action.ListAll;
                case 'D':
                    return Action.DeleteCurrentSong;
                case 'M':
                    return Action.Menu;
                case 'X':
                    return Action.Exit;
                default: { Console.WriteLine("\nUnrecognised input.\n"); return PromptForAction(); }
            }
        }
    }



    public enum Action
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
