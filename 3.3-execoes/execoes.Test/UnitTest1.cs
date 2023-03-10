using System;
using Xunit;
using FluentAssertions;

namespace execoes.Test;

public class UnitTest1
{
    [Theory(DisplayName = "Teste para lançamento de exceções em divisão entre dois numeros")]
    [InlineData(2, 0)]
    [InlineData(12, 0)]
    [InlineData(23, 0)]
    [InlineData(343, 0)]
    public void TestDivideNumbersException(int entry1, int entry2)
    {
        var classe = new Program();
        Action act = () => classe.DivideNumbers(entry1, entry2);

        act.Should().Throw<DivideByZeroException>().WithMessage("O numero não pode ser dividido por 0");
    }
}