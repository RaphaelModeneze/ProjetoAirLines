using AirLines.Locais;
using AirLines.Tripulantes.Contracts;
using System.Collections.Generic;

namespace AirLines.Veiculo.Contract
{
    public interface ISmartFortwo
    {
        void Embarcar(List<ITripulante> tripulantes, Local rota);
        void Desembarcar();
        void Transportar(Local rota);
        Local ObterLocalAtual();
    }
}
