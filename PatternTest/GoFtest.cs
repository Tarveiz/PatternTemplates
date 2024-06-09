using Factory_Method;
using Abstract_Factory;
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

        [Fact]
        public void AbstractFactory_SpawnUnitsResult()
        {
            SpawnUnits program = new SpawnUnits();

            _outputHelper.WriteLine(program.Play("Red", "Rogue"));
            _outputHelper.WriteLine(program.Play("Blue", "Mage"));
            _outputHelper.WriteLine(program.Play("Red", "Warrior"));
            _outputHelper.WriteLine(program.Play("Blue", "Warrior"));

            _outputHelper.WriteLine(Assert.Throws<ArgumentException>(() => _outputHelper.WriteLine(program.Play("Green","Warrior"))).Message);
            _outputHelper.WriteLine(Assert.Throws<ArgumentException>(() => _outputHelper.WriteLine(program.Play("Red", "Archer"))).Message);
            _outputHelper.WriteLine(Assert.Throws<ArgumentNullException>(() => _outputHelper.WriteLine(program.Play(null, "Archer"))).Message);
            _outputHelper.WriteLine(Assert.Throws<ArgumentNullException>(() => _outputHelper.WriteLine(program.Play("Red", null))).Message);
            _outputHelper.WriteLine(Assert.Throws<ArgumentNullException>(() => _outputHelper.WriteLine(program.Play(null, null))).Message);
        }
    }
}