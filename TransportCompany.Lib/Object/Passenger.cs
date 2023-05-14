namespace TransportCompany.Lib.Object;

public class Passenger : IObject
{
    private readonly string _firstName;
    private readonly string _lastName;

    public Passenger(string firstName, string lastName)
    {
        _firstName = firstName;
        _lastName = lastName;
    }

    public string FullName => $"{_lastName} {_firstName}";
}