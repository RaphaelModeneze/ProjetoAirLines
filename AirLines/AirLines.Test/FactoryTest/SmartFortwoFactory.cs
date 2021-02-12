using AirLines.Veiculo;
using AirLines.Veiculo.Contract;
namespace AirLines.Test.FactoryTest
{
    public static class SmartFortwoFactory
    {
        public static ISmartFortwo MyMethod()
        {
            return new SmartFortwo();
        }
    }
}
