using System;

namespace ClassesParte1
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro(Cor.Branco, 4, "Gol g6");

            Console.WriteLine("O carro é um " + carro.Modelo + " de cor " + carro.Cor + " e " + carro.Portas + " portas");
            
            Console.WriteLine(carro.ligar());
            Console.WriteLine("Ligado? " + carro.Ligado);
            
            Console.WriteLine(carro.andar());

            Console.WriteLine(carro.desligar());
            Console.WriteLine("Ligado? " + carro.Ligado);

            Console.WriteLine(carro.andar());

            carro.Cor = Cor.Azul;
            Console.WriteLine("A nova cor do carro é " + carro.Cor);

        }
    }
}
