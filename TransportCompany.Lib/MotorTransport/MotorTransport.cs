namespace TransportCompany.Lib.MotorTransport;

public class MotorTransport : Transport
{
    protected MotorTransport(string name) : base(name)
    {
    }

    public override void Move()
    {
        Console.WriteLine("Едем");
    }
}