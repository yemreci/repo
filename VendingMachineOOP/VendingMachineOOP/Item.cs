namespace VendingMachineOOP
{
    public abstract class Item
    {
        public string Name { get; }
        public int Cost { get; }
        public Item(string name, int cost)
        {
            Name = name;
            Cost = cost;
        }
    }
}