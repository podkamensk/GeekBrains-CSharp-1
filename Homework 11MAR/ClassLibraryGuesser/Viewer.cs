namespace ClassLibraryGuesser
{
    public interface Viewer
    {
        string guess { get; }
        
        string message { set; }
        string num_games_won { set; }
        string num_games { set; }
        string lowest { set; }
        string highest { set; }
        string current_try { set; }
        string tries_left { set; }

    }
}
