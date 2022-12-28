namespace blackjackGame;

public interface ITextController
{
    public void Instructions();

    public string CenteredString(string stringValue, int width);

    public void WriteText(string text);

    public int DeckInput();

    public decimal MoneyInput();

    public void Introduction();
}