using Factory_Method.Contracts;
using System.Text;

namespace Factory_Method
{
    /// <summary>
    ///     Входной класс фабрики
    /// </summary>
    public class MakeProduction
    {
        private string? _vehicleType;

        public string MakeVehicle(string vehicleType)
        {
            _vehicleType = vehicleType;

            IFactory _factory = ChooseFactory();
            IProduction vehicle = _factory.Create();
            return vehicle.Release();
        }

        private IFactory ChooseFactory()
        {
            if (_vehicleType == null)
                throw new ArgumentNullException(nameof(_vehicleType));

            switch (_vehicleType)
            {
                case "Car":
                    return new CarFactory();
                case "Truck":
                    return new TruckFactory();
                default:
                    throw new ArgumentException(_vehicleType + " is unkown vehicle");
            }
        }

    }
}
