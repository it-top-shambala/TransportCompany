namespace TransportCompany.Lib;

public abstract class Transport
{
    protected readonly List<IObject> _objects;
    public string Name { get; init; }

    protected Transport(string name)
    {
        _objects = new List<IObject>();
        Name = name;
    }

    public abstract void Move();
}