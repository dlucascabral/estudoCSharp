using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var scanner = new Escaneadora();
            var textoEscaneado = scanner.Escanear("The book is on the table");

            Console.WriteLine(textoEscaneado);

            var mf = new Multifuncional();
            var impressao = mf.Imprimir("Impressão OK...");
            var copia = mf.Copiar("Copia OK...");
            var escaneado = mf.Escanear("Escaneamento OK...");

            Console.WriteLine(impressao);
            Console.WriteLine(copia);
            Console.WriteLine(escaneado);
        }
    }
}
