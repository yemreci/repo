using VendingMachineOOP;

internal class Program
{
    private static void Main(string[] args)
    {
        VendingMachine mealMachine = new MealMachine();
        VendingMachine beverageMachine = new BeverageMachine();
        mealMachine.LoadItem("SKS",5);
        beverageMachine.LoadItem("Cola", 5);
        mealMachine.DepositMoney(50);
        mealMachine.Order("SKS");
        beverageMachine.DepositMoney(60);
        beverageMachine.Order("Cola");
        Console.WriteLine(beverageMachine.WithdrawMoney());
        Console.WriteLine(mealMachine.WithdrawMoney());
    }
}