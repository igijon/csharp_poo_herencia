using System;
namespace POO_herencia
{
	abstract class Figura
	{
		private int lado1;

		public int Lado1
		{
			set
			{
				if (value < 0)
				{
					lado1 = 0;
				}
				else
				{
					lado1 = value;
				}
			}
			get
			{
				return lado1;
			}
		}

		public abstract float area();
		public abstract float perimetro();
	}
}

