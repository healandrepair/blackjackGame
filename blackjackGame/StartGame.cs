using System.Runtime.InteropServices;

namespace blackjackGame;

public class StartGame
{
    private const string SeparatorLine = "////////////////////////////////////////////////////////////";

    private const int SeparatorWidth = 60;
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("hello World");
        
            CardDeck deck = new CardDeck(6);
            deck.Shuffle();
            
            Introduction();
            
            Instructions();
            break;

        }
        
        
    }


    public static void Introduction()
    {
        Console.WriteLine(SeparatorLine);
        Console.WriteLine(centeredString("Welcome to Blackjack!", SeparatorWidth));
        Console.WriteLine(centeredString("Made by Evan Ng", SeparatorWidth));
        Console.WriteLine(SeparatorLine);
    }

    public static void Instructions()
    {
        Console.WriteLine(SeparatorLine);
        WriteText("Blackjack is one of the most widely played casino banking game in the world, it uses decks of 52 cards and descends from a global family of casino banking games known as Twenty-One. In Blackjack, players do not compete against each other. The game is a comparing card game where each player competes against the dealer.");
        Console.WriteLine();

        WriteText("Every player is dealt an inital hand of two cards every round, and the dealer is dealt one card in their inital hand. The objective of the game is to win money by creating card totals higher than those of the dealer's hand but not exceeding 21, or by stopping at a total in the hope that dealer will bust. On a player's turn, they can choose to 'hit' (take a card), 'stand' (end their turn and stop without taking a card), " +
                  "'double' (double their wager, take a single card, and finish), 'split' (if the two cards have the same value, separate them to make two hands)");
        Console.WriteLine();

        WriteText("Number cards count as their number, the jack, queen, and king count as 10, and aces count as either 1 or 11 according to the player's choice. If the total exceeds 21 points, it busts, and all bets on it immediately lose.");
        
    }
    
    static string centeredString(string stringValue, int width)
    {
        if (stringValue.Length >= width)
        {
            return stringValue;
        }

        int leftPadding = (width - stringValue.Length) / 2;
        int rightPadding = width - stringValue.Length - leftPadding;

        return new string(' ', leftPadding) + stringValue + new string(' ', rightPadding);
    }

    public static void WriteText(string text)
    {
        var words = text.Split().ToList();
        var lines = new List<string>();

        string tempLine = "";
        int tempLineCount = 0;
        
        for (int element = 0; element < words.Count; element++)
        {

            if (element == words.Count - 1)
            {
                tempLine += words[element];
                lines.Add(tempLine);
                break;
            }
            int potentialNewWord = (tempLineCount + words[element].Length + 1);
            // Checks Current line length + word length + space is less than separatorWidth
            if (potentialNewWord <= 50)
            {
                tempLine += words[element] + " ";
                tempLineCount += words[element].Length + 1;
            }

            else if (potentialNewWord > 50)
            {
                lines.Add(tempLine);
                tempLine = "";
                tempLineCount = 0;
                tempLine += words[element] + " ";
                tempLineCount += words[element].Length + 1;
            }
        }
      
        foreach (var line in lines)
        {
            Console.WriteLine(centeredString(line, 60));
        }
    }
}