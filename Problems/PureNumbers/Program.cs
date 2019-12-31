using System;
using System.Collections.Generic;

namespace PureNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            String line;

            line = Console.ReadLine();
            int T = Convert.ToInt32(line);

            for (int t_i = 0; t_i < T; t_i++)
            {
                line = Console.ReadLine();
                int N = Convert.ToInt32(line);

                String out_ = Solve(N);
                Console.Out.WriteLine(out_);

            }
            Console.ReadLine();
        }

        static string Solve(int N)
        {
            if (N == 1)
            {
                return "44";
            }

            if (N == 2)
            {
                return "55";
            }

            int i = 0;
            var list = new List<string> { "44", "55" };
            while (list.Count < N)
            {
                list.Add("4" + list[i] + "4");
                i++;
                list.Add("5" + list[i] + "5");
                i++;
            }

            return list[list.Count - 1];
        }
    }
}
