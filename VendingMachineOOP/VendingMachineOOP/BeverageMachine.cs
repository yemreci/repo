using VendingMachineOOP;

public class BeverageMachine : VendingMachine, IFreezer
{
    public BeverageMachine() : base()
    {
        ItemFactory = new BeverageFactory();
    }
    public ItemFactory ItemFactory { get; }
    public void Freeze(Item item)
    {
        Console.WriteLine(item.Name + " has been frozen");
    }

    public override void LoadItem(string name, int cost)
    {
        Items.Add(ItemFactory.CreateItem(name, cost));
    }

    protected override Item PrepareItem(Item item)
    {
        Freeze(item);
        return item;
    }
}