using System;
namespace POO_herencia
{
	class Rectangulo: Figura
	{
		private int lado2;

		public int Lado2
		{
			set
			{
				if (value < 0) lado2 = 0;
				else lado2 = value;
			}
			get
			{
				return lado2;
			}
		}
		public Rectangulo(int lado1, int lado2)
		{
			this.Lado1 = lado1;
			this.Lado2 = lado2;
		}

        public override float area()
        {
			return Lado1 * Lado2;
        }

        public override float perimetro()
        {
			return (2 * Lado1) + (2 * Lado2);
        }
    }
}

