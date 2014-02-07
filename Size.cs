using System;

namespace UnitClasses
{

	public class Size<TUnit> where TUnit:Unit
	{
		private readonly TUnit width_;
		private readonly TUnit height_;
		
		public Size (TUnit width, TUnit height)
		{
			width_ = width;
			height_ = height;
		}
	}
	
}
