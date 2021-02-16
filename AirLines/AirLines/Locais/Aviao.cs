using AirLines.Locais.Enum;

namespace AirLines.Locais
{
    public sealed class Aviao : Local
    {
        private static readonly Aviao instance = new Aviao();

        private Aviao() : base(EnumLocal.Aviao)
        {
        }

        public static Aviao GetAviao()
        {
            return instance;
        }
    }
}
