using AirLines.Locais;
using AirLines.Locais.Contracts;

namespace AirLines.Test.FactoryTest
{
    public static class LocalFactory
    {
        public static ILocal CriarLocalInicial()
        {
            return new Terminal();
        }
    }
}
