using System;
using System.Collections.Generic;
using System.Text;
using FlaUI.UIA3;
using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using TechTalk.SpecFlow;

namespace specflowrunrepository.Page_Objects
{

	//public class CalculatorPage : IDisposable
	//{


	//	public CalculatorPage()
	//	{ }

	//	public void LaunchAndWaitForInputIdle()
	//	{
	//		Constants.app = FlaUI.Core.Application.LaunchStoreApp("Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");

	//		Constants.app.WaitWhileMainHandleIsMissing();

	//		Constants.automation = new UIA3Automation();
	//		Constants.window = Constants.app.GetMainWindow(Constants.automation);
	//	}

	//	public void Dispose()
	//	{

	//		if (Constants.app != null)
	//		{
	//			if (Constants.app.HasExited == false)
	//				Constants.app.Kill();

	//			Constants.app.Dispose();
	//		}

	//		if (Constants.automation != null)
	//			Constants.automation.Dispose();
	//	}

	//	public CalculatorPage PressAdd()
	//	{
	//		var button = Constants.window.FindFirstDescendant(cf => cf.ByAutomationId("plusButton"))?.AsButton();

	//		button.Click(true);

	//		return this;
	//	}

	//	public CalculatorPage PressNumberOne()
	//	{
	//		var button = Constants.window.FindFirstDescendant(cf => cf.ByAutomationId("num1Button"))?.AsButton();

	//		button.Click(true);

	//		return this;
	//	}

	//	public CalculatorPage PressEquals()
	//	{
	//		var button = Constants.window.FindFirstDescendant(cf => cf.ByAutomationId("equalButton"))?.AsButton();

	//		button.Click(true);

	//		return this;
	//	}

	//	public decimal ReadCurrentResult()
	//	{
	//		throw new NotImplementedException();
	//		//todo: get the UI element for the result textbox and return the value of it here...
	//	}

	//}

	public class Calculator
	{
		public int FirstNumber { get; set; }
		public int SecondNumber { get; set; }

		public int Add()
		{
			return FirstNumber + SecondNumber;
		}
	}
}
