using System;

namespace Proj01
{
    class Program{
        static void Main(string[] args){
            //Declaração de Variáveis
            double n1, n2, div; 
            //fim da declaração
            Console.WriteLine("Bem Vindo ao curso de C#");
            Console.WriteLine("escreva o valor da variavel numero: ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor 2: ");
            n2 = double.Parse(Console.ReadLine());
            if (n1 < 1) {
                Console.WriteLine("Não funciona");
            }
            else
            {
                div = n1 / n2;
                Console.WriteLine("resultado: " + div);
            }
        }
    }
}