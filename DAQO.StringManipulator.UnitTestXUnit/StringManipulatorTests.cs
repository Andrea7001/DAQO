using DAQO;
using Xunit;

public class StringManipulatorTests
{
    private readonly StringManipulator _stringManipulator;

    public StringManipulatorTests()
    {
        _stringManipulator = new StringManipulator();
    }

    [Fact]
    public void ReverseString_InputIsHello_ShouldReturnOlleh()
    {
        // Arrange
        var input = "Hola";

        // Act
        var result = _stringManipulator.ReverseString(input);

        // Assert
        Assert.Equal("aloH", result);
    }

    [Fact]
    public void RemoveSpaces_InputHasSpaces_ShouldRemoveAllSpaces()
    {
        // Arrange
        var input = "H o l a";

        // Act
        var result = _stringManipulator.RemoveSpaces(input);

        // Assert
        Assert.Equal("Hola", result);
    }
}

