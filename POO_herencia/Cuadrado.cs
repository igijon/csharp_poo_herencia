using System;
namespace POO_herencia
{
	class Cuadrado: Figura
	{
		public Cuadrado(int lado1)
		{
			this.Lado1 = lado1;
		}

        public override float area()
        {
			return Lado1 * Lado1;
        }

        public override float perimetro()
        {
            return 4 * Lado1;
        }
    }
}

