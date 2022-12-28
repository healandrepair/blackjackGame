namespace blackjackGame;

public class Player
{
    private decimal _playerMoneyDeposited;

    private decimal _playerMoneyDepositedTotal;

    public decimal PlayerMoney
    {
        get => _playerMoneyDeposited;
        set
        {
            _playerMoneyDeposited += value;
            _playerMoneyDepositedTotal += value;
        }
    }
    
    public Player(decimal initalAmountDeposit)
    {
        PlayerMoney = initalAmountDeposit;
    }
}