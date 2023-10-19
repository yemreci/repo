namespace VendingMachineOOP
{
    public class BeverageFactory : ItemFactory
    {
        public override Item CreateItem(string name, int cost)
        {
            return new Beverage(name, cost);
        }
    }
}
