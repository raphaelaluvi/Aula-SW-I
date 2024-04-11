using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploParametro
{
    public class Area
    {
        public int Base { get; set; }
        public int Altura { get; set; }
        public float AreaCalculada { get; set;}

        public void Escolha(int opcao)
        {
            if (opcao == 1)
            {
                float quadrado = CalculaAQ();
                Console.WriteLine("A área do quadrado é: " + quadrado);
            }
            else if (opcao == 2)
            {
                float retangulo = CalculaAR();
                Console.WriteLine("A área do retangulo é: " + retangulo);
            }
            else
            {
                float triangulo = CalculaAT();
                Console.WriteLine("A área do triangulo é: " + triangulo);
            }
        }
        public float CalculaAQ()
        {
            int AreaCalculada = Base * Base;
            return AreaCalculada;
        }
        public float CalculaAR()
        {
            int AreaCalculada = Base * Altura;
            return AreaCalculada;
        }
        public float CalculaAT()
        {
            int AreaCalculada = Base * Altura / 2;
            return AreaCalculada;
        }
    }
}
