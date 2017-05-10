using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolObect
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Init Pool");
            var pool = new ConnectionPool(3,6);

            Console.WriteLine("Get Connection 1 - fast");
            var c1 = pool.GetConnection();

            Console.WriteLine("Get Connection 2 - fast");
            var c2 = pool.GetConnection();

            Console.WriteLine("Get Connection 3 - Fast");
            var c3 = pool.GetConnection();
            

            Console.WriteLine("Get Connection 4 - slow");
            var c4 = pool.GetConnection();

            Console.WriteLine("Relise Connection 3");
            pool.ReliseConnection(c3);

            Console.WriteLine("Get Connection 5 - slow");
            var c5 = pool.GetConnection();

            Console.WriteLine();

            pool.GetConnection();
            pool.GetConnection();

            Console.ReadKey();
        }
    }
}
