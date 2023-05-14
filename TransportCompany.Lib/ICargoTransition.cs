using TransportCompany.Lib.Object;

namespace TransportCompany.Lib;

public interface ICargoTransition
{
    public void Loading(List<Cargo> cargoes);
    public List<Cargo> UnLoading();
}