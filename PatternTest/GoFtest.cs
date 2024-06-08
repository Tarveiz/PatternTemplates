using Factory_Method;
using Xunit;
using Xunit.Abstractions;

namespace PatternTest
{
    public class GoFtest
    {
        private readonly ITestOutputHelper _outputHelper;

        public GoFtest(ITestOutputHelper output)
        {
            _outputHelper = output;
        }


        [Fact]
        public void FactoryMethod_CheckProductionResult()
        {
            MakeProduction program = new MakeProduction();


            _outputHelper.WriteLine(program.MakeVehicle("Car"));
            _outputHelper.WriteLine(program.MakeVehicle("Truck"));
            _outputHelper.WriteLine(Assert.Throws<ArgumentException>(() => _outputHelper.WriteLine(program.MakeVehicle("Boat"))).Message);
            _outputHelper.WriteLine(Assert.Throws<ArgumentNullException>(() => _outputHelper.WriteLine(program.MakeVehicle(null))).Message);

        }
    }
}