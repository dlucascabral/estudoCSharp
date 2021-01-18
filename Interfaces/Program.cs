using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = new ImpressoraComum();
            var i2 = new ImpressoraCopiadora();

            Console.WriteLine(i.Imprimir("Estou estudando C#"));
            Console.WriteLine(i2.Copiar("Estou estudando C# e estou gostando"));

            CopiarDocumento(new Copiadora(), "Hello, World!");
        }

        public static void CopiarDocumento(ICopiadora copiadora, string texto) {
            Console.WriteLine($"Estou copiando o texto a seguir: {copiadora.Copiar(texto)}");
        }
    }
}
