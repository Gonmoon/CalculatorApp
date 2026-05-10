using Calculator;

namespace Calculator.Tests;

public class UnitTest1
{
    private readonly CalculatorService _calculator;

    public UnitTest1()
    {
        _calculator = new CalculatorService();
    }

    [Fact]
    public void Add_ShouldReturnCorrectSum()
    {
        var result = _calculator.Add(2, 3);

        Assert.Equal(5, result);
    }

    [Fact]
    public void Subtract_ShouldReturnCorrectDifference()
    {
        var result = _calculator.Subtract(10, 4);

        Assert.Equal(6, result);
    }

    [Fact]
    public void Multiply_ShouldReturnCorrectProduct()
    {
        var result = _calculator.Multiply(3, 5);

        Assert.Equal(15, result);
    }

    [Fact]
    public void Divide_ShouldReturnCorrectResult()
    {
        var result = _calculator.Divide(20, 4);

        Assert.Equal(5, result);
    }

    [Fact]
    public void Divide_ByZero_ShouldThrowException()
    {
        Assert.Throws<DivideByZeroException>(() =>
            _calculator.Divide(10, 0));
    }
}