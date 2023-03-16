using Cliente.CasoDeUso.CasosDeUsos;
using Cliente.CasoDeUso.PuertaEnlace;
using Cliente.Domain.Encargado.Comandos;
using Cliente.Domain.Generico;
using Cliente.Domain.Venta.Comandos;
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
    public class VentaCasoDeUsoTest
    {

        private readonly Mock<IEventoRepositorio<AlmacenamientoEvento>> _mockRepository;

        public VentaCasoDeUsoTest()
        {

            _mockRepository = new();

        }

        [Fact]
        public async Task CrearVenta()
        {
            var almacenamiento = new AlmacenamientoEvento();
            //Arrange
            _mockRepository.Setup(repo => repo.AddAsync(It.IsAny<AlmacenamientoEvento>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(almacenamiento);

            _mockRepository.Setup(repo => repo.SaveChangesAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult<int>(200));

            //Act
            var useCase = new VentaCasoDeUso(_mockRepository.Object);

            await useCase.CrearVenta(GetVentaCommand());

            //Assert
            _mockRepository.Verify(r => r.AddAsync(It.IsAny<AlmacenamientoEvento>(), It.IsAny<CancellationToken>()), Times.Exactly(2));

            _mockRepository.Verify(r => r.SaveChangesAsync(It.IsAny<CancellationToken>()), Times.Exactly(1));
        }



        private CrearVentaComand GetVentaCommand() =>
            new CrearVentaComandConstructor()
                .WithName("VIP")                
                .Build();
    }
}

