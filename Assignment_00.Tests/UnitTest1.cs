using Xunit;
using Assignment_00;

namespace Assignment_00.Tests;

public class UnitTest1
{
    [Fact]
    public void IsLeapYearTest()
    {

        // Divisible by 4
        Assert.Equal(true, Program.IsLeapYear(4));
        Assert.Equal(true, Program.IsLeapYear(8));
        Assert.Equal(true, Program.IsLeapYear(12));
        Assert.Equal(true, Program.IsLeapYear(16));
        Assert.Equal(true, Program.IsLeapYear(20));
        // Not Divisible by 4
        Assert.Equal(false, Program.IsLeapYear(2));
        Assert.Equal(false, Program.IsLeapYear(6));
        Assert.Equal(false, Program.IsLeapYear(7));
        Assert.Equal(false, Program.IsLeapYear(14));
        Assert.Equal(false, Program.IsLeapYear(23));
        // Divisible by 100
        Assert.Equal(false, Program.IsLeapYear(1700));
        Assert.Equal(false, Program.IsLeapYear(1800));
        Assert.Equal(false, Program.IsLeapYear(1900));
        // Divisible by 400
        Assert.Equal(true, Program.IsLeapYear(1600));
        Assert.Equal(true, Program.IsLeapYear(2000));
    }

    
}