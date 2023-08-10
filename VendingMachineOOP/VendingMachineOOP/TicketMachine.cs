class TicketMachine : VendingMachine
{
    public override void DepositItemAndMoney(Item item)
    {
        if (Money <= 0 || Money < item.Cost)
        {
            throw new Exception("Please Insert Money!");
        }
        if (item.Name == "" || !(item.Name == "Ticket1" || item.Name == "Ticket2" || item.Name == "Ticket3" || item.Name == "Ticket4" || item.Name == "Ticket5"))
        {
            throw new Exception("Please select a valid Item!");
        }
        Console.WriteLine("Your ticket of " + item.Name + " has been deposited. Here's your change: " + (Money - item.Cost));
        Money = 0;
    }
}