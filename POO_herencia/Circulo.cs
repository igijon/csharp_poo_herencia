using System;
namespace POO_herencia
{
	class Circulo: Figura
	{
		public Circulo(int radio)
		{
			Lado1 = radio;
		}

        public override float area()
        {
			return (float)(Math.PI * Lado1 * Lado1);
        }

        public override float perimetro()
        {
            return (float)(Math.PI * 2 * Lado1);
        }
    }
}

