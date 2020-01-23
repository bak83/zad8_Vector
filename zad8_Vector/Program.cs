using System;

namespace zad8_Vector
{
	class Program
	{
		static void Main(string[] args)
		{
			var v1 = new Vector(5);
			var v2 = new Vector(5);
			v1.fillMatrix();
			v2.fillMatrix();
			Console.WriteLine("Hello World!");
			Console.WriteLine(v2.V.Length);
			Console.WriteLine(v2.V[0]);
		}
	}
}
