using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Source.Interfaces
{
	public interface IPosition
	{
		void Step(List<int> maxPoints, string moves);
	}
}
