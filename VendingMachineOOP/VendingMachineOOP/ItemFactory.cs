namespace VendingMachineOOP
{
    public abstract class ItemFactory
    {
        public abstract Item CreateItem(string name, int cost);
    }
}
