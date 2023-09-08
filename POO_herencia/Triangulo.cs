using System;
namespace POO_herencia
{
	class Triangulo: Figura
	{
		private int lado2;
		private int altura;
		private int lado3;

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


        public int Lado3
        {
            set
            {
                if (value < 0) lado3 = 0;
                else lado3 = value;
            }
            get
            {
                return lado3;
            }
        }

        public int Altura
        {
            set
            {
                if (value < 0) altura = 0;
                else altura = value;
            }
            get
            {
                return altura;
            }
        }

        public Triangulo(int tbase, int altura)
		{
			Lado1 = tbase;
			Altura = altura;
		}

        public Triangulo(int l1, int l2, int l3)
        {
            Lado1 = l1;
            Lado2 = l2;
            Lado3 = l3;
        }

        public override float area()
        {
            return (Lado1 * Altura) / 2.0F;
        }

        public override float perimetro()
        {
            return Lado1 + Lado2 + Lado3;
        }
    }
}

