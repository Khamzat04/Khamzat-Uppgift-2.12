using System;
// Upgift 2.12
public class Program

{
	public static void Main()
	{
		int sAvgift = 300;
		Console.WriteLine("hur många dagar tänker du hyra bilen");
		int Dagar = int.Parse(Console.ReadLine());

		Console.WriteLine("hur många km ska du köra");
		int Km = int.Parse(Console.ReadLine());

		Console.WriteLine(sAvgift + Dagar * 500 - 500 + Km);
	}
}
