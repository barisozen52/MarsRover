using System;
using System.Collections.Generic;
using MarsRover.Source;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRover.Test
{
	[TestClass]
	public class MarsRoverTest
	{
		[TestMethod]
		public void Test_MarsRover_52West_LMRRMLMRML()
		{
			Position position = new Position()
			{
				X = 5,
				Y = 2,
				Direction = Source.Enums.EnumDirection.West
			};

			var maxPoints = new List<int>() { 6, 5 };
			var tasks = "LMRRMLMRML";

			position.Step(maxPoints, tasks);

			var actualOutput = $"{position.X} {position.Y} {position.Direction.ToString()}";
			var expectedOutput = "4 3 West";

			Assert.AreEqual(expectedOutput, actualOutput);
		}

		[TestMethod]
		public void Test_MarsRover_61South_LRRMMLRRML()
		{
			Position position = new Position()
			{
				X = 6,
				Y = 1,
				Direction = Source.Enums.EnumDirection.South
			};

			var maxPoints = new List<int>() { 6, 6 };
			var tasks = "LRRMMLRRML";

			position.Step(maxPoints, tasks);

			var actualOutput = $"{position.X} {position.Y} {position.Direction.ToString()}";
			var expectedOutput = "4 2 West";

			Assert.AreEqual(expectedOutput, actualOutput);
		}

		[TestMethod]
		public void Test_MarsRover_12North_LMLMLMLMM()
		{
			Position position = new Position()
			{
				X = 1,
				Y = 2,
				Direction = Source.Enums.EnumDirection.North
			};

			var maxPoints = new List<int>() { 5, 5 };
			var tasks = "LMLMLMLMM";

			position.Step(maxPoints, tasks);

			var actualOutput = $"{position.X} {position.Y} {position.Direction.ToString()}";
			var expectedOutput = "1 3 North";

			Assert.AreEqual(expectedOutput, actualOutput);
		}

		[TestMethod]
		public void Test_MarsRover_33East_MRRMMRMRRM()
		{
			Position position = new Position()
			{
				X = 3,
				Y = 3,
				Direction = Source.Enums.EnumDirection.East
			};

			var maxPoints = new List<int>() { 5, 5 };
			var tasks = "MRRMMRMRRM";

			position.Step(maxPoints, tasks);

			var actualOutput = $"{position.X} {position.Y} {position.Direction.ToString()}";
			var expectedOutput = "2 3 South";

			Assert.AreEqual(expectedOutput, actualOutput);
		}


	}
}
