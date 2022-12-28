namespace blackjackGame;

public class TextController : ITextController
{
    private const string SeparatorLine = "////////////////////////////////////////////////////////////";
    
    private int separatorWidth = 60;

    public void Introduction()
    {
        Console.WriteLine(SeparatorLine);
        Console.WriteLine(CenteredString("Welcome to Blackjack!", separatorWidth));
        Console.WriteLine(CenteredString("Made by Evan Ng", separatorWidth));
        Console.WriteLine(SeparatorLine);
    }

    public string GetSeparatorLine => SeparatorLine;

    public int GetSeparatorWidth => separatorWidth;

    public void Instructions()
    {
        Console.WriteLine(SeparatorLine);
        WriteText(
            "Blackjack is one of the most widely played casino banking game in the world, it uses decks of 52 cards and descends from a global family of casino banking games known as Twenty-One. In Blackjack, players do not compete against each other. The game is a comparing card game where each player competes against the dealer.");
        Console.WriteLine();

        WriteText(
            "Every player is dealt an initial hand of two cards every round, and the dealer is dealt one card in their initial hand. The objective of the game is to win money by creating card totals higher than those of the dealer's hand but not exceeding 21, or by stopping at a total in the hope that dealer will bust. On a player's turn, they can choose to 'hit' (take a card), 'stand' (end their turn and stop without taking a card), " +
            "'double' (double their wager, take a single card, and finish), 'split' (if the two cards have the same value, separate them to make two hands)");
        Console.WriteLine();

        WriteText(
            "Number cards count as their number, the jack, queen, and king count as 10, and aces count as either 1 or 11 according to the player's choice. If the total exceeds 21 points, it busts, and all bets on it immediately lose.");
        Console.WriteLine(SeparatorLine);
    }

    public string CenteredString(string stringValue, int width)
    {
        if (stringValue.Length >= width)
        {
            return stringValue;
        }

        int leftPadding = (width - stringValue.Length) / 2;
        int rightPadding = width - stringValue.Length - leftPadding;

        return new string(' ', leftPadding) + stringValue + new string(' ', rightPadding);
    }

    public void WriteText(string text)
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
            Console.WriteLine(CenteredString(line, 60));
        }
    }

    public int DeckInput()
    {
        Console.WriteLine("Type in a number of decks you would like to play with. (default is 6)");
        while (true)
        {
            string? inputDeck = Console.ReadLine() ?? "6";
            if (int.TryParse(inputDeck, out int value))
            {
                return value;
            }

            Console.WriteLine("Error: Please type in an integer number.");
        }
    }

    public decimal MoneyInput()
    {
        Console.WriteLine("Type in the money you would like to start with. (default is $200)");
        while (true)
        {
            string? inputMoney = Console.ReadLine() ?? "200";
            if (decimal.TryParse(inputMoney, out decimal value))
            {
                return value;
            }

            Console.WriteLine("Error: Please type in an decimal number.");
        }
    }
}