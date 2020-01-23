using System;

namespace zad8_Vector
{
	class Vector
	{
		public double[] V;
		
		
		public void fillMatrix()
		{
			for (int i = 0; i < V.Length; i++)
			{
				Console.WriteLine("Enter number: " + i+1);
				V[i] = int.Parse(Console.ReadLine());
			}

		}
		public Vector(int v)
		{
			V = new double[v];
		}

		public double add(double[] v1,double []v2)
		{
			return 0;
		}
	}
}
