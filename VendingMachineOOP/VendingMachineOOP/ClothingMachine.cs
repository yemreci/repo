class ClothingMachine : VendingMachine
{
    public override void DepositItemAndMoney(Item item)
    {
        if(Money <= 0 || Money < item.Cost)
        {
            throw new Exception("Please Insert Money!");
        }
        if (item.Name == "" || !(item.Name != "Cloth1" || item.Name != "Cloth2" || item.Name != "Cloth3" || item.Name != "Cloth4" || item.Name != "Cloth5"))
        {
            throw new Exception("Please select a valid Item!");
        }
        Console.WriteLine("Your cloth of " + item.Name + " has been deposited. Here's your change: " + (Money - item.Cost));
        Money = 0;
    }
}
