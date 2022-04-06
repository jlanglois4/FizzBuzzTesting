using FizzBuzzTesting;
using Xunit;
using Assert = Xunit.Assert;

public class FizzBuzzTest
{
    FizzBuzz fb = new FizzBuzz();
    
    [Fact]
    public void One()
    {
        Assert.Equal("1",fb.DoFizzBuzz(1));
    }

    [Fact]
    public void Two()
    {
        Assert.Equal("2", fb.DoFizzBuzz(2));
    }

    [Fact]
    public void Three()
    {
        Assert.Equal("Fizz", fb.DoFizzBuzz(3));
    }
    
    [Fact]
    public void Four()
    {
        Assert.Equal("4", fb.DoFizzBuzz(4));
    }
    
    [Fact]
    public void Five()
    {
        Assert.Equal("Buzz", fb.DoFizzBuzz(5));
    }

    [Fact]
    public void Fifteen()
    {
        Assert.Equal("FizzBuzz", fb.DoFizzBuzz(15));
    }
    
    [Fact]
    public void Thirty()
    {
        Assert.Equal("FizzBuzz", fb.DoFizzBuzz(30));
    }
    
    [Fact]
    public void OneThousandFiveHundredAndSixtyThree()
    {
        Assert.Equal("Fizz", fb.DoFizzBuzz(1563));
    }


}