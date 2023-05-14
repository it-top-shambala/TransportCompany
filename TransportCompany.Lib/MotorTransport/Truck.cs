using TransportCompany.Lib.Object;

namespace TransportCompany.Lib.MotorTransport;

public class Truck : MotorTransport, ICargoTransition
{
    public Truck(string name) : base(name)
    {
    }

    public void Loading(List<Cargo> cargoes)
    {
        foreach (var cargo in cargoes)
        {
            _objects.Add(cargo);
        }
    }

    public List<Cargo> UnLoading()
    {
        var list = new List<Cargo>();
        foreach (var o in _objects)
        {
            list.Add((Cargo)o);
        }
        _objects.Clear();
        return list;
    }
}