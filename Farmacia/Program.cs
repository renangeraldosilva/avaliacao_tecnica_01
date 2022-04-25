using System;
using System.Collections.Generic;
using System.Linq;

namespace Farmacia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listaRemedios = new List<string>();
            listaRemedios.Add("paracetamol");
            listaRemedios.Add("metamizol");
            listaRemedios.Add("amoxicilina");
            listaRemedios.Add("betametasona");
            listaRemedios.Add("benzetacil");
            listaRemedios.Add("albumina");
            listaRemedios.Add("neosaldina");
            listaRemedios.Add("omega 3");
            listaRemedios.Add("sibutramina");
            listaRemedios.Add("saxenda");
            listaRemedios.Add("orlislat");

            Console.WriteLine($"O estoque possui {listaRemedios.Count} remedios");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Lista de remedios em ordem alfabetica.");
            listaRemedios = listaRemedios.OrderBy(x => x).ToList();

            foreach (var item in listaRemedios)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------------------------------------");
            Console.Write("Digite o nome do remedio que você procura:");
            string nomeRemedio = Console.ReadLine().ToLower().Trim().TrimEnd().TrimStart();

            List<string> listaFiltrada = listaRemedios.Where(x => x.Contains(nomeRemedio)).ToList();
            
            foreach (var item in listaFiltrada)
            {
                Console.WriteLine(item);
            }

        }
    }
}
