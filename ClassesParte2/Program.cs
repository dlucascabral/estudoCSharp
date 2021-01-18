using System;

namespace ClassesParte2
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Cachorro("Rex", 5);
            var g = new Gato("Ana", 3);

            Animal a = new Gato("Felix", 5);

            ExibeAnimal(c);
            ExibeAnimal(g);
            ExibeAnimal(a);
        }

        public static void ExibeAnimal(Animal animal) {
            Console.WriteLine($"Nome: {animal.Nome}");
            Console.WriteLine($"Idade: {animal.Idade}");
        }
    }
}
