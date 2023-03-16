using Cliente.CasoDeUso.CasosDeUsos;
using Cliente.CasoDeUso.PuertaEnlace;
using Cliente.Domain.Cliente.Comandos;
using Cliente.Domain.ComandosDDD;
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
    public class ClienteCasoDeUsoTest
    {

        private readonly Mock<IEventoRepositorio<AlmacenamientoEvento>> _mockRepository;

        public ClienteCasoDeUsoTest()
        {

            _mockRepository = new();

        }

        [Fact]
        public async Task CrearCliente()
        {
            var almacenamiento = new AlmacenamientoEvento();
            //Arrange
            _mockRepository.Setup(repo => repo.AddAsync(It.IsAny<AlmacenamientoEvento>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(almacenamiento);

            _mockRepository.Setup(repo => repo.SaveChangesAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult<int>(200));

            //Act
            var useCase = new ClienteCasoDeUso(_mockRepository.Object);

            await useCase.CrearCliente(GetClienteCommand());

            //Assert
            _mockRepository.Verify(r => r.AddAsync(It.IsAny<AlmacenamientoEvento>(), It.IsAny<CancellationToken>()), Times.Exactly(2));

            _mockRepository.Verify(r => r.SaveChangesAsync(It.IsAny<CancellationToken>()), Times.Exactly(1));
        }

        [Fact]
        public async Task AnadirPedido()
        {

            _mockRepository.Setup(repo => repo.GetEventosAgregadoId(It.IsAny<string>()))
                .Returns(Task.FromResult(GetListaALmacenamientoEvento()));

            _mockRepository.Setup(repo => repo.AddAsync(It.IsAny<AlmacenamientoEvento>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(GetAlmacenamientoEvento());

            _mockRepository.Setup(repo => repo.SaveChangesAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(200));

            var useCase = new ClienteCasoDeUso(_mockRepository.Object);

            await useCase.AnadirPedido(GetAnadirPedidoComand());

            _mockRepository.Verify(r => r.AddAsync(It.IsAny<AlmacenamientoEvento>(), It.IsAny<CancellationToken>()), Times.Exactly(2));

            _mockRepository.Verify(r => r.GetEventosAgregadoId(It.IsAny<string>()), Times.Once);

            _mockRepository.Verify(r => r.SaveChangesAsync(It.IsAny<CancellationToken>()), Times.Exactly(1));
        }




        private CrearClienteComand GetClienteCommand() =>
            new CrearClienteComandConstructor()
                .WithName("John")
                .WithEmail("lemon")
                .Build();




        private AnadirPedidoComand GetAnadirPedidoComand() =>
            new AnadirPedidoComandConstructor()
               .WithCLienteId("c11d7c42-10d5-4e77-ac50-f1ec4dc8d388")
               .WithCantidad(1)
               .Build();

        private AlmacenamientoEvento GetAlmacenamientoEvento() =>
           new AlmacenamientoEventoConstructor()
               .WithStoredId(1)
               .WithStoredName("ClienteCreado")
               .WithAggregateId("Agregado1")
               .WithEventBody("{\"Type\":\"datosPersonales.agregados\",\"DatosPersonales\":{\"Nombre\":\"string\",\"Correo\":\"string\"}}")
               .Build();


        private List<AlmacenamientoEvento> GetListaALmacenamientoEvento() =>
            new()
            {
                new AlmacenamientoEventoConstructor()
                .WithStoredId(2)
                .WithStoredName("DatosPersonalesAnadidos")
                .WithAggregateId("c11d7c42-10d5-4e77-ac50-f1ec4dc8d388")
                .WithEventBody("{\"Type\":\"datosPersonales.agregados\",\"DatosPersonales\":{\"Nombre\":\"string\",\"Correo\":\"string\"}}")
                .Build(),

                new AlmacenamientoEventoConstructor()
                .WithStoredId(3)
                .WithStoredName("ClienteCreado")
                .WithAggregateId("012dfccf-ceaf-457a-a0b7-87d6b9b9b3fc")
                .WithEventBody("{\"Type\":\"cliente.creado\",\"ClienteId\":\"VirtualEducation.DDD.Domain.cliente.ValueObjects.Cliente.ClienteId\"}")
                .Build()
            };


    }
}
