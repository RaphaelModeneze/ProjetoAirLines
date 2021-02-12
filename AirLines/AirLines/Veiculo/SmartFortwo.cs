using AirLines.Tripulantes;
using AirLines.Veiculo.Contract;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AirLines.Veiculo
{
    public class SmartFortwo : ISmartFortwo
    {
        //private readonly ILocal local;

        public int Limite => 2;
        //public LocalVeiculo LocalVeiculo { get; set; }
        public Locals.Local Local { get; set; }
        public List<Tripulante> ListaTripulantesDoVeiculo { get; set; }

        public SmartFortwo()
        {
            ListaTripulantesDoVeiculo = new List<Tripulante>();
        }

        public void Embarcar(List<Tripulante> tripulantes, Locals.Local rota)
        {
            AtribuirLocalVeiculo(rota);
            ValidarTripulantes(tripulantes);
            ListaTripulantesDoVeiculo.AddRange(tripulantes);
            Local.RemoverTripulantes(ListaTripulantesDoVeiculo);
        }

        private void ValidarTripulantes(List<Tripulante> tripulantes)
        {
            var motorista = tripulantes.Find(x => x.PodeDirigir);
            if (motorista == null) { throw new Exception("Veículo sem motorista"); }

            ValidarPassageiro(tripulantes, motorista);
        }

        private void ValidarPassageiro(List<Tripulante> tripulantes, Tripulante motorista)
        {
            foreach (var tripulante in tripulantes.Where(x => !x.Equals(motorista)))
            {
                if (!tripulante.PodeFicarAcompanhadoCom(motorista))
                {
                    throw new Exception($"{tripulante.GetType()} não pode ficar sozinho com {motorista.GetType()}");
                }
            }
        }

        public void Desembarcar()
        {
            Local.AdicionarTripulantes(ListaTripulantesDoVeiculo);
            ListaTripulantesDoVeiculo.Clear();
        }

        public void Transportar(Locals.Local rota)
        {
            AtribuirLocalVeiculo(rota);
            Desembarcar();
        }

        private void AtribuirLocalVeiculo(Locals.Local local)
        {
            Local = local;
        }

        public Locals.Local ObterLocalAtual()
        {
            return Local;
        }

    }
}
