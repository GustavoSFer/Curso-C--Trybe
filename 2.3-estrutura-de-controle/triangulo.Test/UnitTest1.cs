using Xunit;
using FluentAssertions;

namespace triangulo.Test;

public class UnitTest1
{
    [Theory(DisplayName = "Deve classificar um triangulo")]
    [InlineData(2,2,2, "Triângulo Equilátero")]
    [InlineData(5,6,6, "Triângulo Isóscele")]
    [InlineData(6,2,6, "Triângulo Isóscele")]
    [InlineData(6,6,2, "Triângulo Isóscele")]
    [InlineData(1,2,3, "Triângulo Escaleno")]
    public void TestIdentifyTriangle(double entry1, double entry2, double entry3, string expected)
    {
        var resultName = Poli.IdentifyTriangule(entry1, entry2, entry3);
        resultName.Should().Be(expected);
    }
}