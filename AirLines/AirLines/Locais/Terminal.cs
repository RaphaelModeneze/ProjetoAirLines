using AirLines.Locais.Enum;

namespace AirLines.Locais
{
    public sealed class Terminal : Local
    {
        private static readonly Terminal instance = new Terminal();

        private Terminal() : base(EnumLocal.Terminal)
        {
        }

        public static Local GetTerminal()
        {
            return instance;
        }
    }
}
