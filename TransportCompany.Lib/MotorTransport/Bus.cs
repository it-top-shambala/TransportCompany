using TransportCompany.Lib.Object;

namespace TransportCompany.Lib.MotorTransport;

public class Bus : MotorTransport, IPassengerTransition
{
    public Bus(string name) : base(name)
    {
    }

    public void Boarding(List<Passenger> passengers)
    {
        foreach (var passenger in passengers)
        {
            _objects.Add(passenger);
        }
    }

    public List<Passenger> UnBoarding()
    {
        var list = new List<Passenger>();
        foreach (var o in _objects)
        {
            list.Add((Passenger)o);
        }
        _objects.Clear();
        return list;
    }
}