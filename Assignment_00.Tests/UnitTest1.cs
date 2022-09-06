using Xunit;
using Assignment_00;

namespace Assignment_00.Tests;

public class UnitTest1
{
    [Fact]
    public void AddTest()
    {
        Assert.Equal(4, Program.Add(2,2));
    }
}