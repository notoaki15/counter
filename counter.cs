using System;
namespace Application
{
	public class EmptyClass
	{
		public EmptyClass()
		{
			Counter c1 = new Counter();
			while(true)
			{
				Console.Writeline(c1.totalCount); 
			}
		}
	}

	public class Counter
	{
		private int _count;
		private static int _totalCount;

		public int GetNextValue()
		{
			_count += 1;
			_totalCount += 1;
			return _count;
		}
		public static int TotalCount
		{
			get
			{
				return _totalCount;
			}
		}
	}
	}


}
