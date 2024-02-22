//Creates an item class that has sub-classes of item types that depending on their type do different things.
class Item
{
    public string Name { get;}
    public Item (string name)
    {
        Name = name;
    }
}
class Weapon:Item
{
    public Weapon(string name):base(name) {}
}
class Armor:Item
{
    public Armor(string name):base(name) {}
}
class Consumable:Item
{
    public Consumable(string name):base(name) {}
}