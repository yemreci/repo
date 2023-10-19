namespace VendingMachineOOP
{
    public class MealFactory : ItemFactory
    {
        public override Item CreateItem(string name, int cost)
        {
            return new Meal(name,cost);
        }
    }
}
