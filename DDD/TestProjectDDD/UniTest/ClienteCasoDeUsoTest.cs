using Cliente.CasoDeUso.CasosDeUsos;
using Cliente.CasoDeUso.PuertaEnlace;
using Cliente.Domain.Cliente.Comandos;
using Cliente.Domain.Generico;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectDDD.Constructor;

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

            await useCase.CrearCliente(GetStudentCommand());

            //Assert
            _mockRepository.Verify(r => r.AddAsync(It.IsAny<AlmacenamientoEvento>(), It.IsAny<CancellationToken>()), Times.Exactly(2));

            _mockRepository.Verify(r => r.SaveChangesAsync(It.IsAny<CancellationToken>()), Times.Exactly(1));
        }



        private CrearClienteComand GetStudentCommand() =>
            new CrearClienteComandConstructor()
                .WithName("John")
                .WithEmail("Doe")
                .Build();



        //private AlmacenamientoEvento GetStoredEvent() =>
            //new AlmacenamientoEventoConstructor()
            //    .WithStoredId(1)
            //    .WithStoredName("StudentCreated")
            //    .WithAggregateId("Aggregate1")
            //    .WithEventBody("{\"Type\":\"datosPersonales.agregados\",\"PersonalData\":{\"Name\":\"string\",\"LastName\":\"string\",\"Age\":0,\"Gender\":\"string\"}}")
            //    .Build();
            
            



        //private List<AlmacenamientoEvento> GetListStoredEvent() =>
        //    new()
        //    {
        //        new AlmacenamientoEventoConstructor()
        //        .WithStoredId(2)
        //        .WithStoredName("PersonalDataAdded")
        //        .WithAggregateId("c11d7c42-10d5-4e77-ac50-f1ec4dc8d388")
        //        .WithEventBody("{\"Type\":\"datosPersonales.agregados\",\"PersonalData\":{\"Name\":\"string\",\"LastName\":\"string\",\"Age\":0,\"Gender\":\"string\"}}")
        //        .Build(),

        //        new AlmacenamientoEventoConstructor()
        //        .WithStoredId(3)
        //        .WithStoredName("StudentCreated")
        //        .WithAggregateId("012dfccf-ceaf-457a-a0b7-87d6b9b9b3fc")
        //        .WithEventBody("{\"Type\":\"estudiante.creado\",\"StudentID\":\"VirtualEducation.DDD.Domain.Student.ValueObjects.Student.StudentID\"}")
        //        .Build()
        //    };


        //private AddAccountCommand GetAddAccountCommand() =>
        //new AddAccountCommandBuilder()
        //        .WithStudentId("c11d7c42-10d5-4e77-ac50-f1ec4dc8d388")
        //        .WithUsername("johndoe")
        //        .WithPersonalMail("johndoe@gmail.com")
        //        .WithInstitutionalMail("johndoe@university.edu")
        //        .Build();

    }
}
