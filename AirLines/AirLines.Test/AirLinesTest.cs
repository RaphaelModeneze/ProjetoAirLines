using AirLines.Tripulantes;
using AirLines.Tripulantes.Cabine;
using AirLines.Tripulantes.Outros;
using AirLines.Tripulantes.Tecnico;
using NUnit.Framework;
using System.Collections.Generic;

namespace AirLines.Test
{
    public class Tests
    {
        public Aeroporto Aeroporto { get; set; }
        public List<Tripulante> ListaDeTripulantes { get; set; }
        public Piloto Piloto { get; set; }
        public Oficial Oficial { get; set; }
        public Policial Policial { get; set; }
        public Presidiario Presidiario { get; set; }
        public ChefeServico ChefeServico { get; set; }
        public Comissaria Comissaria { get; set; }

        [SetUp]
        public void Setup()
        {
            Piloto = new Piloto();
            Oficial = new Oficial();
            Policial = new Policial();
            Presidiario = new Presidiario();
            ChefeServico = new ChefeServico();
            Comissaria = new Comissaria();

            Aeroporto = new Aeroporto();
            Aeroporto.IniciarEmbarque(
                new List<Tripulante>
                {
                    Piloto,
                    Oficial,
                    Policial,
                    Presidiario,
                    ChefeServico,
                    Comissaria
                });
        }

        [Test]
        public void Test1()
        {
            //Arrange


            //Act
            Aeroporto.Tranferir(new List<Tripulante> { Piloto, Oficial });

            //Assert
            Assert.Pass();
        }
    }
}