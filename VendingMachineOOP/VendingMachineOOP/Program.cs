internal class Program
{
    private static void Main(string[] args)
    {
        Item item1 = new Item("Beverage1", 1);
        Item item2 = new Item("Beverage4", 2);
        Item item3 = new Item("Meal1", 3);
        Item item4 = new Item("Meal2", 4);
        Item item5 = new Item("Cloth1", 5);
        Item item6 = new Item("Cloth2", 5);
        Item item7 = new Item("Ticket1", 5);
        Item item8 = new Item("Ticket2", 5);
        HotMealMachine machine1 = new HotMealMachine();
        ClothingMachine machine2 = new ClothingMachine();
        BeverageMachine machine3 = new BeverageMachine();
        Console.WriteLine("Money is: " + machine1.Money);
        machine1.TakeMoney(100);
        Console.WriteLine("Left money is: " + machine1.Money);
        machine1.DepositItemAndMoney(item3);
        Console.WriteLine("Left money is: " + machine1.Money);
        machine2.TakeMoney(100);
        machine2.DepositItemAndMoney(item5);
        machine3.TakeMoney(100);
        machine3.DepositItemAndMoney(item1);
        machine3.TakeMoney(100);
        machine3.DepositItemAndMoney(item2);
    }
}