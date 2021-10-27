using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=0; i<99; i++)
			{
				int zeb= i%10;
				int acharat = i/10;
				int test = 0;
				test = (zeb * 10) + acharat;
				if(zeb == acharat)
					continue;
				else if(test < i)
					continue;
				else
					Console.Write("{0} ", i);
			}
        }
    }
}
