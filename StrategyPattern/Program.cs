using StrategyPattern.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            Context context = new Context(new OperationAdd());
            Console.WriteLine(String.Format("5 + 10 = {0}", context.ExecuteStrategy(5, 10)));

            context = new Context(new OperationSubstract());
            Console.WriteLine(String.Format("5 - 10 = {0}", context.ExecuteStrategy(5, 10)));

            context = new Context(new OperationMultiply());
            Console.WriteLine(String.Format("5 * 10 = {0}", context.ExecuteStrategy(5, 10)));

            Console.ReadLine();
        }
    }
}
