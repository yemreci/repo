using VendingMachineOOP;

class MealMachine : VendingMachine, IHeater
{
    public ItemFactory ItemFactory { get;}
    public MealMachine() : base()
    {
        ItemFactory = new MealFactory();
    }

    public void Heat(Item item)
    {
        Console.WriteLine(item.Name + " has been heated");
    }

    protected override Item PrepareItem(Item item)
    {
        Heat(item);
        return item;
    }

    public override void LoadItem(string name, int cost)
    {
        Items.Add(ItemFactory.CreateItem(name,cost));
    }
}
