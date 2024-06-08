using Factory_Method.Contracts;

namespace Factory_Method.Service
{
    internal class Car : IProduction
    {
        public string Release() => "Выпущен новый легковой автомобиль";
    }
}
