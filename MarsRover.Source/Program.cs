﻿using MarsRover.Source.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Source
{
	public class Program
	{
		static void Main(string[] args)
		{
			var maxPoints = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
			var startPositions = Console.ReadLine().Trim().Split(' ');
			Position position = new Position();

			if (startPositions.Count() == 3)
			{
				position.X = Convert.ToInt32(startPositions[0]);
				position.Y = Convert.ToInt32(startPositions[1]);
				position.Direction = (EnumDirection)Enum.Parse(typeof(EnumDirection), startPositions[2]);
			}

			var moves = Console.ReadLine().ToUpper();

			try
			{
				position.Step(maxPoints, moves);
				Console.WriteLine($"{position.X} {position.Y} {position.Direction.ToString()}");
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

			Console.ReadLine();
		}
	}
}
