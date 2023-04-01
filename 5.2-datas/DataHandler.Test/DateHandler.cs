using Xunit;
using FluentAssertions;
using DateHandler;

namespace DateHandler.Test;

public class DateHandlerTest
{
    [Theory(DisplayName = "Deve retornar string de não há eventos")]
    [InlineData("Não há eventos marcados")]
    public void TestNextEventWithoutEvents(string expected)
    {
        Schedule instance = new Schedule();
        var result = instance.NextEvent();

        result.Should().Be(expected);
    }
}