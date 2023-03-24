using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "fifa",
            string produto2 = "cs",
            string produto3 = "FUT",
            string produto4 = "bola",
            string produto5 = "gol",
         

            string[] produtos = new string[5] {

                "fifa",
                "cs",
                "FUT",
                "bola",
                "gol",
                          
            };

            Console.WriteLine(produtos[1]);

            Console.ReadLine();

        }

        static void ExibirMsg()
        {
            Console.WriteLine("Esse sistema é show de bola!");
            Console.WriteLine("usando funções!");
            Console.WriteLine("deu certo porra!");


            Console.ReadLine();
        }


        static void GerarPreco(int preco)
        {
            //funçção Abs para sempre trazer um resultado positivo
            int precoAbs = Math.Abs(preco);
            int valorFinal = precoAbs + (2 * precoAbs);
            Console.WriteLine("Valor final: " + valorFinal);
        }

        static int Somar (int a, int b, int c)
        {
            int resuiltadoFinal = a + b + c; 
            return resuiltadoFinal;

        }



    }
}
