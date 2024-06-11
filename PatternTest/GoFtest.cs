using Factory_Method;
using Abstract_Factory;
using Builder;
using Builder.Service;
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
        [Fact]
        public void Builder_MakeProductionResult()
        {
            AndroidDeveloper androidDeveloper = new AndroidDeveloper();
            MakeProductionPhone product = new MakeProductionPhone(androidDeveloper);
            _outputHelper.WriteLine(product.MakePhone());

            IOSDeveloper iOSDeveloper = new IOSDeveloper();
            product = new MakeProductionPhone(iOSDeveloper);
            _outputHelper.WriteLine(product.MakePhone());

            WindowsDeveloper windowsDeveloper = new WindowsDeveloper();
            product = new MakeProductionPhone(windowsDeveloper);
            _outputHelper.WriteLine(Assert.Throws<NotImplementedException>(() => _outputHelper.WriteLine(product.MakePhone())).Message);

            product = new MakeProductionPhone(null);
            _outputHelper.WriteLine(Assert.Throws<ArgumentNullException>(() => _outputHelper.WriteLine(product.MakePhone())).Message);

        }
    }
}