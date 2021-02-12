using AirLines.Locals;
using AirLines.Locals.Contracts;

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
