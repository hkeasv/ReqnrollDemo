using Reqnroll;
using Xunit;

namespace Calculator.Specs.StepDefinitions;

[Binding]
public sealed class CalculatorStepDefinitions
{
    // For additional details on Reqnroll step definitions see https://go.reqnroll.net/doc-stepdef

    private readonly Calculator _calculator = new Calculator();
    private int _result;

    [Given("the first number is (.*)")]
    public void GivenTheFirstNumberIs(int number)
    {
        _calculator.FirstNumber = number;
    }

    [Given("the second number is {int}")]
    public void GivenTheSecondNumberIs(int number)
    {
        _calculator.SecondNumber = number;
    }

    [When("the two numbers are added")]
    public void WhenTheTwoNumbersAreAdded()
    {
        _result = _calculator.Add();
    }

    [Then("the result should be {int}")]
    public void ThenTheResultShouldBe(int result)
    {
        Assert.Equal(result, _result);
    }
}