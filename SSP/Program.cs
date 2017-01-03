using System;
// Камень, ножницы, бумага.
//
namespace SSP
{
    enum MyEnum
    {
        stone = 3,
        scissors = 2,
        paper = 1,
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Inter:
     3 - stone
     2 - scissors
     1 - paper
     0 - exit");

            Random ran = new Random();
            int win = 0;
            int st = 0;
            int sc = 0;
            int pp = 0;
            while (true)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int m = ran.Next(1, 4);
                switch (n)
                {
                    case 3:
                        st++;
                        break;
                    case 2:
                        sc++;
                        break;
                    case 1:
                        pp++;
                        break;
                }

                if (n == m)
                {
                    Console.WriteLine("Draw!");
                }

                if (n == (int)MyEnum.paper || m == (int)MyEnum.paper && n != m)
                {
                    if (m == (int)MyEnum.stone)
                    {
                        Console.WriteLine("You won!");
                        win++;
                    }
                    if (n == (int)MyEnum.stone)
                    {
                        Console.WriteLine("You lost!");
                    }
                    if (m == (int)MyEnum.scissors)
                    {
                        Console.WriteLine("You lost!");
                    }
                    if (n == (int)MyEnum.scissors)
                    {
                        Console.WriteLine("You won!");
                        win++;
                    }
                }
                else
                {
                    if (!(n < m))
                    {
                        if (n > m)
                        {
                            Console.WriteLine("You won!");
                            win++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("You lost!");
                    }
                }

                if (n == 0)
                {
                    break;
                }
            }
            Console.WriteLine();
            Console.WriteLine("You won {0} times", win);
            Console.WriteLine();
            Console.WriteLine("stone: {0}", st);
            Console.WriteLine("scissors: {0}", sc);
            Console.WriteLine("paper: {0}", pp);
            Console.ReadLine();
        }
    }
}
