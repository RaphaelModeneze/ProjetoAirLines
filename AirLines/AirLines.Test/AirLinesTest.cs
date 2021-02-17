using AirLines.Resources;
using AirLines.Test.FactoryTest;
using AirLines.Tripulantes.Cabine;
using AirLines.Tripulantes.Contracts;
using AirLines.Tripulantes.Outros;
using AirLines.Tripulantes.Tecnico;
using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace AirLines.Test
{
    public class Tests
    {
        public Aeroporto Aeroporto { get; set; }
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

            Aeroporto = new Aeroporto(SmartFortwoFactory.MyMethod());

            Aeroporto.IniciarEmbarque(
                new List<ITripulante>
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
        public void Transferir_piloto_oficial_com_sucesso()
        {
            //Arrange
            //Act
            var result = Aeroporto.Tranferir(new List<ITripulante> { Piloto, Oficial });

            //Assert
            result.Should().Be(true);
            Assert.That(Aeroporto.Terminal.TripulantesNoLocal.Count.Equals(4));
            Assert.That(Aeroporto.Aviao.TripulantesNoLocal.Count.Equals(2));
        }

        [Test]
        public void Transferir_Comissaria_presidiario_com_erro()
        {
            //Arrange
            //Act
            var ex = Assert.Throws<Exception>(() => Aeroporto.Tranferir(new List<ITripulante> { Comissaria, Presidiario }));

            //Assert
            Assert.That(ex.Message, Is.EqualTo(Resource.SemMotorista));
        }

        [Test]
        public void Transferir_chefe_presidiario_com_erro()
        {
            //Arrange
            //Act
            var ex = Assert.Throws<Exception>(() => Aeroporto.Tranferir(new List<ITripulante> { ChefeServico, Presidiario }));

            //Assert
            Assert.That(ex.Message, Is.EqualTo(Resource.NaoAutorizado));
        }

        [Test]
        public void Transferir_policial_presidiario_com_sucesso()
        {
            //Arrange
            //Act
            var result = Aeroporto.Tranferir(new List<ITripulante> { Policial, Presidiario });

            //Assert
            result.Should().Be(true);
            Assert.That(Aeroporto.Terminal.TripulantesNoLocal.Count.Equals(4));
            Assert.That(Aeroporto.Aviao.TripulantesNoLocal.Count.Equals(2));
        }
    }
}