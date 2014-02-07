using System;

namespace UnitClasses
{

	public class Point<TUnit> where TUnit:Unit
	{
		private readonly TUnit x_;
		private readonly TUnit y_;

		public Point (TUnit x, TUnit y)
		{
			x_ = x;
			y_ = y;
		}
	}
	
}
