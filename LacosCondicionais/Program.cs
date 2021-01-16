using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace LacosCondicionais
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateHostBuilder(args).Build().Run();

            int hora = 15;

            /* if (hora <= 15)
            {
                Console.WriteLine("Menos de 15 horas.");
            } else if (hora <= 17) {
                Console.WriteLine("Ainda não são 17 horas.");
            } else {
                if (hora == 18)
                {
                    Console.WriteLine("São 18h!");
                } else
                {
                    Console.WriteLine("Já passou das 18h!")
                }
            } */

            switch (hora)
            {
                case 15:
                    Console.WriteLine("São 15h!");
                    break;
                
                case 18:
                    Console.WriteLine("São 18h!");
                    break;

                default:
                    Console.WriteLine("Não estou preocupado com o horário!");
                    break;
            }

            PrimeiroSemestre mes = PrimeiroSemestre.Maio;

            switch (mes)
            {
                case PrimeiroSemestre.Janeiro:
                    Console.WriteLine("Estamos em Janeiro");
                    break;
                case PrimeiroSemestre.Fevereiro:
                    Console.WriteLine("Estamos em Fevereiro");
                    break;
                case PrimeiroSemestre.Marco:
                    Console.WriteLine("Estamos em Março");
                    break;
                case PrimeiroSemestre.Abril:
                    Console.WriteLine("Estamos em Abril");
                    break;
                case PrimeiroSemestre.Maio:
                    Console.WriteLine("Estamos em Maio");
                    break;
                case PrimeiroSemestre.Junho:
                    Console.WriteLine("Estamos em Junho");
                    break;
            }

        }

        public enum PrimeiroSemestre{
            Janeiro, Fevereiro, Marco, Abril, Maio, Junho
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
