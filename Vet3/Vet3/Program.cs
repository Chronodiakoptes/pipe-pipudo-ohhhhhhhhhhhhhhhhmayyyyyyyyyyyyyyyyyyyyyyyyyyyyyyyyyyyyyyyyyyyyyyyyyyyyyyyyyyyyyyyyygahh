using System;

namespace Vet3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[10];
            int[] m = new int[10];
            for(int j = 0; j < n.Length; j++){
            n[j] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i < m.Length; i++){
                m[i] = int.Parse(Console.ReadLine());
            }
            for(int r = 0; r < 10; r++){
                int re = (n[r] * m[r]);
                Console.WriteLine(n[r] + "*" + m[r] + "=" + re);
            }
        }
    }
}
