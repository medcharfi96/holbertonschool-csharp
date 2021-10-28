using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
		int resultat  =  number % 10;
		if (resultat > 0)
		{
			Console.Write("{0}", resultat);
			return(resultat);
		}
		Console.Write("{0}", (resultat * (-1)));
		return((resultat*(-1)));
	}
}