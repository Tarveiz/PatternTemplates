using Factory_Method.Contracts;
using Factory_Method.Service;

namespace Factory_Method.Factory
{
    internal class CarFactory : IFactory
    {
        public IProduction Create() => new Car();
    }
}
