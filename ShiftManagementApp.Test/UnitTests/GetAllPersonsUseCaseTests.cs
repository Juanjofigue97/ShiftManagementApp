using Moq;
using ShiftManagementApp.Application.Interfaces;
using ShiftManagementApp.Application.UseCases.PersonsCases;
using ShiftManagementApp.Library.Entities;

namespace ShiftManagementApp.Test.UnitTests;

public class GetAllPersonsUseCaseTests
{
    [Fact]
    public async Task ExecuteAsync_ShouldReturnListOfPersons_WhenCalled()
    {
        var mockPersonRepository = new Mock<IPersonRepository>();

        var expectedPersons = new List<Person>
        {
            new Person { Id = 1, FirstName = "John", LastName = "Doe" },
            new Person { Id = 2, FirstName = "Jane", LastName = "Smith" }
        };

        mockPersonRepository.Setup(repo => repo.GetAllPersons())
            .ReturnsAsync(expectedPersons);

        var useCase = new GetAllPersonsUseCase(mockPersonRepository.Object);

        var result = await useCase.ExecuteAsync();

        Assert.NotNull(result);
        Assert.Equal(2, result.Count());
        Assert.Equal(expectedPersons, result);
    }
}