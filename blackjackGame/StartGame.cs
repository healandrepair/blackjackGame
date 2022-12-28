using System.Runtime.InteropServices;

namespace blackjackGame;

public class StartGame
{
    ITextController _textController;
    
    public void RunGame()
    {
        _textController = new TextController();
        
        _textController.Introduction();

        _textController.Instructions();

        // New game
        while (true)
        {
            int numberOfDecks = _textController.DeckInput();

            CardDeck deck = new CardDeck(numberOfDecks);
            deck.Shuffle();

            decimal moneyStartedWith = _textController.MoneyInput();
            
            
            // High score using a notepad would be cool

            Player player = new Player(moneyStartedWith);
            
            // New Round
            RoundController roundController = new RoundController(_textController);
            while (true)
            {
                // This should all be ina method

                break;
            }

            break;
        }
    }
}