using Cliente.CasoDeUso.CasosDeUsos;
using Cliente.CasoDeUso.PuertaEnlace;
using Cliente.Domain.Cliente.Comandos;
using Cliente.Domain.Encargado.Comandos;
using Cliente.Domain.Generico;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectDDD.Constructor;
using Xunit;

namespace TestProjectDDD.UniTest
{
    public class EncargadoCasoDeUsoTest
    {

        private readonly Mock<IEventoRepositorio<AlmacenamientoEvento>> _mockRepository;

        public EncargadoCasoDeUsoTest()
        {

            _mockRepository = new();

        }

        [Fact]
        public async Task CrearEncargado()
        {
            var almacenamiento = new AlmacenamientoEvento();
            //Arrange
            _mockRepository.Setup(repo => repo.AddAsync(It.IsAny<AlmacenamientoEvento>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(almacenamiento);

            _mockRepository.Setup(repo => repo.SaveChangesAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult<int>(200));

            //Act
            var useCase = new EncargadoCasoDeUso(_mockRepository.Object);

            await useCase.CrearEncargado(GetEncargadoCommand());

            //Assert
            _mockRepository.Verify(r => r.AddAsync(It.IsAny<AlmacenamientoEvento>(), It.IsAny<CancellationToken>()), Times.Exactly(2));

            _mockRepository.Verify(r => r.SaveChangesAsync(It.IsAny<CancellationToken>()), Times.Exactly(1));
        }



        private CrearEncargadoComand GetEncargadoCommand() =>
            new CrearEncargadoComandConstructor()
                .WithName("John")
                .WithSex("M")
                .WithAge(12)
                .Build();
    }
}
