using System;

namespace _9_print_specifiers
{
    class Program
    {
        static void Main(string[] args)
        {
			double percent = .7553;
			double currency = 98765.4321;
			Console.WriteLine("percent: {0}", percent*100);
			Console.WriteLine("currency: ${0:N2}",currency);

        }
    }
}
