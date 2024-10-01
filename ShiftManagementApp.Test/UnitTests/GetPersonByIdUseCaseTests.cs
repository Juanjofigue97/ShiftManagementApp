using Moq;
using ShiftManagementApp.Application.Interfaces;
using ShiftManagementApp.Application.UseCases.PersonsCases;
using ShiftManagementApp.Library.Entities;

namespace ShiftManagementApp.Test.UnitTests;

public class GetPersonByIdUseCaseTests
{
    private readonly Mock<IPersonRepository> _mockPersonRepository;
    private readonly GetPersonByIdUseCase _getPersonByIdUseCase;

    public GetPersonByIdUseCaseTests()
    {
        _mockPersonRepository = new Mock<IPersonRepository>();
        _getPersonByIdUseCase = new GetPersonByIdUseCase(_mockPersonRepository.Object);
    }

    [Fact]
    public async Task ExecuteAsync_ShouldReturnPerson_WhenPersonExists()
    {
        // Arrange
        var person = new Person { Id = 1, FirstName = "John", LastName = "Doe" };
        _mockPersonRepository.Setup(repo => repo.GetPersonById(1)).ReturnsAsync(person);

        // Act
        var result = await _getPersonByIdUseCase.ExecuteAsync(1);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(1, result.Id);
        Assert.Equal("John", result.FirstName);
    }

    [Fact]
    public async Task ExecuteAsync_ShouldThrowException_WhenPersonDoesNotExist()
    {
        // Arrange
        _mockPersonRepository.Setup(repo => repo.GetPersonById(1)).ReturnsAsync((Person)null);

        // Act & Assert
        await Assert.ThrowsAsync<KeyNotFoundException>(() => _getPersonByIdUseCase.ExecuteAsync(1));
    }

    [Fact]
    public async Task ExecuteAsync_ShouldThrowArgumentException_WhenIdIsInvalid()
    {
        // Act & Assert
        await Assert.ThrowsAsync<ArgumentException>(() => _getPersonByIdUseCase.ExecuteAsync(0));
    }
}
