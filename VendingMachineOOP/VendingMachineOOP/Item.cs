class Item
{
    private readonly string _name;
    private readonly int _cost;
    public Item(string name, int cost)
    {
        _name = name;
        _cost = cost;
    }

    public string Name => _name;

    public int Cost => _cost;
}
