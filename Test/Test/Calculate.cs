using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Test
{
    public class Calculate : ICalculate
    {
        private int[] list;
        private int sum;
        public Calculate(int[] _list, int _sum)
        {
            list = _list;
            sum = _sum;

        }
        public Task Cal()
        {
           return findSumPar(list, sum, list[0], 1);
        }

        public Task findSumPar(int[] list, int sum, int x, int y)
        {
            if (x <= list.Length - 1 && y <= list.Length - 1)
            {
                if (y == list.Length - 1)
                {
                    Thread thready = new Thread(async() => await findSumPar(list, sum, x + 1, 0));
                    thready.Start();

                }
                else
                if ((list[x] + list[y] == sum) && x != y)
                {
                    Console.WriteLine($"{list[x]},{list[y]} ");
                }
                Thread threadx = new Thread(async () => await findSumPar(list, sum, x, y + 1));
                threadx.Start();
            }
            return Task.CompletedTask;
        }
    }
}
