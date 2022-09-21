using System;

namespace HackerChallengeDay4
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.In.ReadLine());
            
            for (int i = 0; i < T; i++)
            {
                int age = int.Parse(Console.In.ReadLine());
                Person p = new Person(age);
                p.AmIOld();
                
                for (int j = 0; j < 3; j++)
                {
                    p.YearPasses();
                }
                p.AmIOld();
                Console.WriteLine();
            }
        }
    }
}
