using Factory_Method.Contracts;
using Factory_Method.Service;

namespace Factory_Method.Factory
{
    internal class TruckFactory : IFactory
    {
        public IProduction Create() => new Truck();
    }
}
