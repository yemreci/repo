class HotMealMachine : VendingMachine, IHeater
{
    public void Heat(Item item)
    {
        Console.WriteLine("Meal " + item.Name + " is heated");
    }
    public override void DepositItemAndMoney(Item item)
    {
        if (Money <= 0 || Money < item.Cost)
        {
            throw new Exception("Please Insert Money!");
        }
        if (item.Name == "" || !(item.Name == "Meal1" || item.Name == "Meal2" || item.Name == "Meal3" || item.Name == "Meal4" || item.Name == "Meal5"))
        {
            throw new Exception("Please select a valid Item!");
        }
        Heat(item);
        Console.WriteLine("Your hot meal of " + item.Name + " has been deposited. Here's your change: " + (Money - item.Cost));
        Money = 0;
    }
}
