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
            GerarPreco(500);
            GerarPreco(50);
            GerarPreco(5);
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

            Console.WriteLine(preco);
        }



    }
}
