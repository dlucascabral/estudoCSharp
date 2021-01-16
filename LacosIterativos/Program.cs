using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace LacosIterativos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateHostBuilder(args).Build().Run();

            Console.WriteLine("Laços For");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Valor de i é: " + i);
            }

            Console.WriteLine("Laços While");

            int contador = 3;
            while (contador < 5)
            {
                Console.WriteLine(contador);
                contador++;
            }

            Console.WriteLine("Laços Do-While");

            float j = 10;
            do
            {
                Console.WriteLine(j);
                j *= 1.5f;
            } while (j<50);

            Console.WriteLine("Laços Foreach");

            int[] conjunto = {1, 2, 3, 4};
            foreach (int numero in conjunto)
            {
                Console.WriteLine(numero);
            }


        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
