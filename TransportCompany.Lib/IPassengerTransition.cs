using TransportCompany.Lib.Object;

namespace TransportCompany.Lib;

public interface IPassengerTransition
{
    public void Boarding(List<Passenger> passengers);
    public List<Passenger> UnBoarding();
}