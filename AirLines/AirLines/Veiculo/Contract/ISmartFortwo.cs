using AirLines.Tripulantes;
using System.Collections.Generic;

namespace AirLines.Veiculo.Contract
{
    public interface ISmartFortwo
    {
        void Embarcar(List<Tripulante> tripulantes, Locals.Local rota);
        void Desembarcar();
        void Transportar(Locals.Local rota);
        Locals.Local ObterLocalAtual();
    }
}
