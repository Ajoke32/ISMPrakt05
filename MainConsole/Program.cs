using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayOperation;

namespace MainConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("n= ");
            if (!int.TryParse(Console.ReadLine(),out n) || n <= 0)
            {
                Console.WriteLine("Помилка,введiть цiле число n або n<=0");
            }
            else
            {
                int[] arr = ArrayOp.Fix(n);
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"arr[{i}]= {arr[i]}");
                }
                int sum = ArrayOp.SumNeg(arr);
                Console.WriteLine($"Cума вiд’ємних елементiв масиву = {sum}\n");
                int max = ArrayOp.PairedMax(arr);
                Console.WriteLine($"Mаксимальний елемент серед парних = {max}\n");
                int dob = ArrayOp.DobParied(arr);
                Console.WriteLine($"Добуток елементiв масиву, що мають парнi iндекси = {dob}\n");
                int maxindex = ArrayOp.IndxeMaxvalue(arr);
                Console.WriteLine($"Iндекс максимального елемента масиву = {maxindex}\n");
                int sumindex = ArrayOp.SumIndexPositive(arr);
                Console.WriteLine($"Сума iндексiв додатнiх елементiв= {sumindex}\n");
                int numders = ArrayOp.numderNoPaired(arr);
                Console.WriteLine($"Кiлькiсть непарних елементiв масиву = {numders}\n");
                int modulmax = ArrayOp.MaxModElement(arr);
                Console.WriteLine($"Максимальний за модулем елемент масиву= {modulmax}\n");
            }

        }
        
    }
}
