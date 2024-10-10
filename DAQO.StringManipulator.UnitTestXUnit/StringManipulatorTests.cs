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
        var input = "Hello";

        // Act
        var result = _stringManipulator.ReverseString(input);

        // Assert
        Assert.Equal("olleH", result);
    }

    [Fact]
    public void RemoveSpaces_InputHasSpaces_ShouldRemoveAllSpaces()
    {
        // Arrange
        var input = "H e l l o";

        // Act
        var result = _stringManipulator.RemoveSpaces(input);

        // Assert
        Assert.Equal("Hello", result);
    }
}

