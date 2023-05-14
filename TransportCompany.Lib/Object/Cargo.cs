namespace TransportCompany.Lib.Object;

public class Cargo : IObject
{
    public string Owner { get; init; }
    
    public Cargo(string owner)
    {
        Owner = owner;
    }
}