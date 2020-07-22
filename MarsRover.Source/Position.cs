using MarsRover.Source.Enums;
using MarsRover.Source.Interfaces;
using System;
using System.Collections.Generic;

namespace MarsRover.Source
{
	public class Position : IPosition
	{
		public int X { get; set; }
		public int Y { get; set; }
		public EnumDirection Direction { get; set; }

		private readonly Dictionary<EnumDirection, EnumDirection> Rotate90Left = new Dictionary<EnumDirection, EnumDirection>()
		{
			{EnumDirection.North, EnumDirection.West},
			{EnumDirection.South, EnumDirection.East},
			{EnumDirection.East, EnumDirection.North},
			{EnumDirection.West, EnumDirection.South}
		};

		private readonly Dictionary<EnumDirection, EnumDirection> Rotate90Right = new Dictionary<EnumDirection, EnumDirection>()
		{
			{EnumDirection.North, EnumDirection.East},
			{EnumDirection.South, EnumDirection.West},
			{EnumDirection.East, EnumDirection.South},
			{EnumDirection.West, EnumDirection.North}
		};


		public Position()
		{
			X = Y = 0;
			Direction = EnumDirection.North;
		}

		private void StepForDirection()
		{
			switch (Direction)
			{
				case EnumDirection.North:
					Y += 1;
					break;
				case EnumDirection.South:
					Y -= 1;
					break;
				case EnumDirection.East:
					X += 1;
					break;
				case EnumDirection.West:
					X -= 1;
					break;
				default:
					break;
			}
		}

		/// <summary>
		/// Gelen kordinattan başlayarak istenilen yönde hareket ettikten sonra robotun koordinatını ve yönünü hesaplamak için kullanılan metod.
		/// </summary>
		/// <param name="maxPoints">1, 2 gibi istenilen board genişliğini aşmayan sayılar olmalı</param>
		/// <param name="tasks">L,M,R Harflerinden oluşmalı</param>
		public void Step(List<int> maxPoints, string tasks)
		{
			foreach (var task in tasks)
			{
				switch (task)
				{
					case 'M':
						StepForDirection();
						break;
					case 'L':
						Direction = Rotate90Left[Direction];
						break;
					case 'R':
						Direction = Rotate90Right[Direction];
						break;
					default:
						Console.WriteLine($"Invalid Character {task}");
						break;
				}

				if (X < 0 || X > maxPoints[0] || Y < 0 || Y > maxPoints[1])
				{
					throw new Exception($"Entered position values can not be beyond bounderies (0 , 0) and ({maxPoints[0]} , {maxPoints[1]})");
				}
			}
		}
	}
}

