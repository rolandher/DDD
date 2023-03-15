using Cliente.CasoDeUso.CasosDeUsos;
using Cliente.CasoDeUso.PuertaEnlace;
using Cliente.Domain.Generico;
using Moq;

namespace Test
{
    public class ClienteCasoDeUsoTest
    {
        private readonly Mock<IEventoRepositorio<AlmacenamientoEvento>> _mockRepository;

        public ClienteCasoDeUsoTest()
        {
            _mockRepository = new();
        }

        [Fact]
        public async Task Crear_Cliente()
        {
            //Arrange
            _mockRepository.Setup(repo => repo.AddAsync(It.IsAny<AlmacenamientoEvento>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(GetStoredEvent());

            _mockRepository.Setup(repo => repo.SaveChangesAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult<int>(200));

            //Act
            var useCase = new ClienteCasoDeUso(_mockRepository.Object);

            await useCase.CrearCliente(GetStudentCommand());

            //Assert
            _mockRepository.Verify(r => r.AddAsync(It.IsAny<StoredEvent>(), It.IsAny<CancellationToken>()), Times.Exactly(2));

            _mockRepository.Verify(r => r.SaveChangesAsync(It.IsAny<CancellationToken>()), Times.Exactly(1));
        }

        private AlmacenamientoEvento GetStoredEvent() =>
            new StoredEventBuilder()
                .WithStoredId("1")
                .WithStoredName("StudentCreated")
                .WithAggregateId("Aggregate1")
                .WithEventBody("{\"Type\":\"datosPersonales.agregados\",\"PersonalData\":{\"Name\":\"string\",\"LastName\":\"string\",\"Age\":0,\"Gender\":\"string\"}}")
                .Build();

        private CreateStudentCommand GetStudentCommand() =>
            new CreateStudentCommandBuilder()
                .WithName("John")
                .WithLastName("Doe")
                .WithAge(25)
                .WithGender("Male")
                .Build();

    }
}