using System;

class Program
{
    static void Main(string[] args)
    {
        string[] meses = {"Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho",
            "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"
        };
        int m = int.Parse(Console.ReadLine());
        Console.WriteLine(meses[m-1]);
    }
}
