namespace blackjackGame;
using Enums;
public class Card
{
    private Rank _value;

    private Suit _suit;

    public Card(Rank value, Suit suit)
    {
        _value = value;
        _suit = suit;
    }
}