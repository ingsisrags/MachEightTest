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
           return findSumPar(list, sum, 0, 1);
        }

        public Task findSumPar(int[] list, int sum, int x, int y)
        {
          
            if (x < list.Length  && y < list.Length )
            {
                if ((list[x] + list[y] == sum))
                {
                    Console.WriteLine($"{list[x]},{list[y]} ");
                }
                if (y == list.Length-1)
                {
                    Thread thready = new Thread(async() => await findSumPar(list, sum, x + 1, x+2));
                    thready.Start();
                }

                findSumPar(list, sum, x, y + 1);
            }
            return Task.CompletedTask;
        }
    }
}
