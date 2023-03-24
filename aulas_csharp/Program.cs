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

        enum Cor { preto, azul, amarelo, vermelho }
        enum Opcao { Criar = 1, Deletar, Editar, Listar, Atualizar }

        static void Main(string[] args)
        {   
            int contador = 0;
            while (contador < 30)
            {
                Console.WriteLine(contador + 1);
                Console.WriteLine("Rodando o while!"); 
                contador++;
            }

            Console.WriteLine("Acabou papai!"); 
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
