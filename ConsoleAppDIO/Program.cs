using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppDIO
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaNotas = new List<float>();
            var nota = -1F;
            var novoCalculo = 1;
            do
            {
                if (listaNotas.Count == 2)
                {
                    Console.WriteLine("media = " + listaNotas.Average().ToString("N2"));

                    if (!IniciarNovaMedia())
                        break;
                    else
                        listaNotas.Clear();
                }

                nota = LerNota();
                if (nota > -1)
                    listaNotas.Add(nota);

            } while (nota == -1 || novoCalculo == 1);
        }

        static bool IniciarNovaMedia()
        {
            Console.WriteLine("novo calculo (1-sim 2-nao)");
            var input = Console.ReadLine();

            if (int.TryParse(input, out int selecao) && (selecao < 1 || selecao > 2))
                return IniciarNovaMedia();

            return (selecao == 1 ? true : false);
        }
        static float LerNota()
        {
            string input = Console.ReadLine();

            if (float.TryParse(input, out float nota) && (nota >= 0 && nota <= 10))
                return nota;

            Console.WriteLine("nota invalida");
            return -1;
        }
    }
}
