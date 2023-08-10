class BeverageMachine : VendingMachine, IHeater, IFreezer
{
    public void Heat(Item item)
    {
        Console.WriteLine("Beverage " + item.Name + " is heated");
    }
    public void Freeze(Item item)
    {
        Console.WriteLine("Beverage " + item.Name + " is chilled");
    }
    public override void DepositItemAndMoney(Item item)
    {
        if (Money <= 0 || Money < item.Cost)
        {
            throw new Exception("Please Insert Money!");
        }
        if (item.Name == "" || !(item.Name == "Beverage1" || item.Name == "Beverage2" || item.Name == "Beverage3" || item.Name == "Beverage4" || item.Name == "Beverage5"))
        {
            throw new Exception("Please select a valid Item!");
        }
        if(item.Name == "Beverage1" || item.Name == "Beverage2" || item.Name == "Beverage3")
        {
            Heat(item);
        }
        else if(item.Name == "Beverage4" || item.Name == "Beverage5")
        {
            Freeze(item);
        }
        Console.WriteLine("Your Beverage of " + item.Name + " has been deposited. Here's your change: " + (Money - item.Cost));
        Money = 0;
    }
}