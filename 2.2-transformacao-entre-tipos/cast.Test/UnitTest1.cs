using Xunit;
using FluentAssertions;

namespace cast.Test;

public class UnitTest1
{
    // [Fact]
    // public void TestVariableCreation()
    // {
    //     Class1 instance = new();
    //     var response = instance.someString is string;
    //     response.Should().Be(true);
    // }

    [Theory(DisplayName = "Verificando se o tipo é 'double'")]
    [InlineData(1, 1)]
    [InlineData(21, 21)]
    [InlineData(123, 123)]
    public void TestCastDoublo(int entry, double expected)
    {
        Class1 cast = new();
        var numberDouble = cast.Transform(entry);
        numberDouble.Should().Be(expected);

        var checkDouble = numberDouble is double;
        checkDouble.Should().Be(true);
    }
}