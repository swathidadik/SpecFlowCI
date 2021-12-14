using TechTalk.SpecFlow;
using specflowrunrepository.Page_Objects;
using FluentAssertions;

namespace SpecFlowProject1.Steps
{
	[Binding]
	public class AddSteps
	{
		private readonly ScenarioContext _scenarioContext;
		private readonly Calculator clc = new Calculator();
		private int _result;
		//private readonly CalculatorPage clc;
		public AddSteps(ScenarioContext scenarioContext)
		{
			_scenarioContext = scenarioContext;
		}

		[Given(@"the first number is (.*)")]
		public void GivenIHaveEntered1IntoTheCalculator(int number)	
		{

			clc.FirstNumber=number;


		}

		[Given(@"the second number is (.*)")]

		public void GivenIHaveAlsoEntered2IntoTheCalculator(int number)
		{
			clc.SecondNumber=number;



		}
		[When("the two numbers are added")]
		public void WhenTheTwoNumbersAreAdded()
		{
			_result = clc.Add();
		}

		[Then("the result should be (.*)")]
		public void ThenTheResultShouldBe(int result)
		{
			_result.Should().Be(result);
		}

		//[When(@"I have launched the calculator")]
		//public void WhenIHaveLaunchedTheCalculator()
		//{
		//	//this.calculator = new CalculatorPage();
		//	clc.LaunchAndWaitForInputIdle();
		//}

		////[Then(@"the result should be 120")]
		////public void ThenTheResultShouldBeOnScreen(int number)
		////{
		////	Assert.IsTrue(this.calculator.ReadCurrentResult() == number);
		////}

		//[Given(@"click on add")]
		//public void GivenIHavePressedAdd()
		//{

		//	clc.PressAdd();
		//}
	}
}
