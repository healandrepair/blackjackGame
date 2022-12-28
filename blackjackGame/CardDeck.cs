namespace blackjackGame;

using Enums;
public class CardDeck 
{
    private IList<Card> _deck;

    private int NumberOfDeck;
    
    public CardDeck(int numOfCardsInDeck = 1)
    {
        NumberOfDeck = numOfCardsInDeck;
        _deck = new List<Card>();
        PopulateDeck();
    }

    public int GetRemainingNumberOfCards()
    {
        return _deck.Count();
    }

    // Next card is essentially Peek
    public Card NextCard()
    {
        int numberOfCards = GetRemainingNumberOfCards();
        Card nextCard = _deck[numberOfCards - 1];
        return nextCard;
    }

    public bool RemoveCard(Card card)
    {
        int numberOfCards = GetRemainingNumberOfCards();
        if (numberOfCards == 0)
        {
            return false;
        }
        _deck.RemoveAt(numberOfCards-1);
        return true;
    }

    public void AddCard(Card card)
    {
        _deck.Add(card);
    }

    public void PopulateDeck()
    {
        for (int number = 0; number < NumberOfDeck; number++)
        {
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank rank in Enum.GetValues(typeof(Rank)))
                {
                    Card card = new Card(rank, suit);
                    _deck.Add(card);
                }
            }
        }
    }
    
    public void Shuffle()  
    {  
        Random rng = new Random(); 
        int n = _deck.Count;  
        while (n > 1) 
        {  
            n--;  
            int k = rng.Next(n + 1);  
            Card value = _deck[k];  
            _deck[k] = _deck[n];  
            _deck[n] = value;
        }  
    }
}