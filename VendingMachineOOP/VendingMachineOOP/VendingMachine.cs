using VendingMachineOOP;

public abstract class VendingMachine
{
    protected VendingMachine()
    {
        Money = 0;
        Items = new List<Item>();
    }
    public int Money { get; set; }
    public List<Item> Items { get; }
    public Item Order(string name)
    {
        var item = Items.FirstOrDefault(o => o.Name == name);
        if (item == null)
        {
            throw new NullReferenceException("There is no item with the given name");
        }
        if ((Money - item.Cost) <= 0)
        {
            throw new Exception("Not enough money");
        }
        Money -= item.Cost;
        Console.WriteLine("Enjoy " + item.Name);
        return PrepareItem(item);
    }
    protected abstract Item PrepareItem(Item item);
    public void DepositMoney(int money)
    {
        if (money < 0)
        {
            throw new Exception("Deposited money can't be less than 0");
        }
        Money += money;
    }
    public int WithdrawMoney()
    {
        int temp = Money;
        Money = 0;
        return temp;
    }
    public abstract void LoadItem(string name, int cost);
    public void EmptyContainer()
    {
        Items.Clear();
    }
}