using TransportCompany.Lib;
using TransportCompany.Lib.MotorTransport;
using TransportCompany.Lib.Object;

Transport transport;

Console.WriteLine("*** ТИПЫ ПЕРЕВОЗОК ***");
Console.WriteLine("*** 1. Пассажирские перевозки ***");
Console.WriteLine("*** 2. Грузовые перевозки ***");
var inputTypeTransition = Console.ReadLine();
switch (inputTypeTransition)
{
    case "1": // 1. Пассажирские перевозки
    {
        Console.WriteLine("*** ТИП ТРАНСПОРТА ***");
        Console.WriteLine("*** 1. Автотранспорт ***");
        var inputTypeTransport = Console.ReadLine();
        transport = inputTypeTransport switch
        {
            "1" => // 1. Автотранспорт
                new Bus("Bus"),
            _ => null
        };
    }
        break;
    case "2": // 2. Грузовые перевозки
    {
        Console.WriteLine("*** ТИП ТРАНСПОРТА ***");
        Console.WriteLine("*** 1. Автотранспорт ***");
        var inputTypeTransport = Console.ReadLine();
        transport = inputTypeTransport switch
        {
            "1" => // 1. Автотранспорт
                new Truck("Truck"),
            _ => null
        };
    }
        break;
    default:
        transport = null;
        break;
}

/*
if (transport is IPassengerTransition t1)
{
    var passengers = new List<Passenger>()
    {
        new Passenger("AA", "A"),
        new Passenger("AB", "A")
    };
    t1.Boarding(passengers);
    transport.Move();
    t1.UnBoarding();
} else if (transport is ICargoTransition t2)
{
    var cargoes = new List<Cargo>()
    {
        new Cargo("AA"),
        new Cargo("AB")
    };
    t2.Loading(cargoes);
    transport.Move();
    t2.UnLoading();
}
*/

switch (transport)
{
    case IPassengerTransition t1:
    {
        var passengers = new List<Passenger>
        {
            new("AA", "A"),
            new("AB", "A")
        };
        t1.Boarding(passengers);
        transport.Move();
        t1.UnBoarding();
        break;
    }
    case ICargoTransition t2:
    {
        var cargoes = new List<Cargo>
        {
            new("AA"),
            new("AB")
        };
        t2.Loading(cargoes);
        transport.Move();
        t2.UnLoading();
        break;
    }
}