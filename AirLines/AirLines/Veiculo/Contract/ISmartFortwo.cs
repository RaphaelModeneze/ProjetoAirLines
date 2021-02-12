using AirLines.Locals;
using AirLines.Tripulantes;
using System.Collections.Generic;

namespace AirLines.Veiculo.Contract
{
    public interface ISmartFortwo
    {
        void Embarcar(List<Tripulante> tripulantes, Local rota);
        void Desembarcar();
        void Transportar(Local rota);
        Local ObterLocalAtual();
    }
}
