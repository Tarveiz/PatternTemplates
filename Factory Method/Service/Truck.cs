using Factory_Method.Contracts;


namespace Factory_Method.Service
{
    internal class Truck : IProduction
    {
        public string Release() => "Выпущен новый грузовик";
    }
}
