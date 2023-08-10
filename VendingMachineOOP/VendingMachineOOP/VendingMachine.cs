abstract class VendingMachine
{
    private int _money;
    public VendingMachine()
    {
        Money = 0;
    }
    public int Money { get => _money; set => _money = value; }
    public void TakeMoney(int money)
    {
        Money += money;
    }
    public abstract void DepositItemAndMoney(Item item);
}