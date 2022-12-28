namespace blackjackGame;

public class RoundController
{
    private int RoundsPlayed;

    private readonly ITextController _textController;

    public RoundController(ITextController textController)
    {
        _textController = textController;
    }

    public void NewRound(Player player, CardDeck cardDeck)
    {
        SetupRound(player, cardDeck);
    }

    private void SetupRound(Player player, CardDeck cardDeck)
    {
        // Ask for input for bet played in this round:
        Console.WriteLine("How much do you want to bet?");
    }
}