using System;

namespace TiposEVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 10;
            int numero2 = 20;
            var soma = numero1 + numero2;

            Console.WriteLine("10 + 20 = " + soma);

            int copiaDeNumero1 = numero1;
            copiaDeNumero1 = 11;

            Console.WriteLine(numero1);
            Console.WriteLine(copiaDeNumero1);

            var quadrado1 = new Quadrado();
            quadrado1.lado = 10;
            var quadrado2 = quadrado1; //Nesse caso foi passada somente a referencia, então ao alterar o quadrado2.lado também ateraremos o lado do quadrado1
            quadrado2.lado = 11;
            var quadrado3 = new Quadrado();
            quadrado3.lado = 15;
            Console.WriteLine(quadrado1.lado);
            Console.WriteLine(quadrado2.lado);
            Console.WriteLine(quadrado3.lado);
        }

        class Quadrado
        {
            public int lado;
        }
    }
}
