using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SingleTone
{
    class Program
    {
        static void Main(string[] args)
        {
            //Classic SingleTone
            var stc = SingletoneClassic.GetInstanse();

            stc.Loger();
            Thread.Sleep(10000);
            Console.WriteLine("First Loger() finished work");
            stc.Loger();
            Thread.Sleep(10000);
            Console.WriteLine("Second Loger() finished work");
            stc.Loger();
            Thread.Sleep(10000);
            Console.WriteLine("Third Loger() finished work");

            var stc1 = SingletoneClassic.GetInstanse();

            Console.WriteLine(ReferenceEquals(stc, stc1));


            //Loker SingleTone
            var stl = SingleToneLoker.GetInstanse();

            stl.Loger();
            Thread.Sleep(10000);
            Console.WriteLine("First Loger() finished work");
            stl.Loger();
            Thread.Sleep(10000);
            Console.WriteLine("Second Loger() finished work");
            stl.Loger();
            Thread.Sleep(10000);
            Console.WriteLine("Third Loger() finished work");

            var stl1 = SingleToneLoker.GetInstanse();

            Console.WriteLine(ReferenceEquals(stl, stl1));


            //Static SingleTone
            var sts = SingleToneStatic.GetInstanse();

            sts.Loger();
            Thread.Sleep(10000);
            Console.WriteLine("First Loger() finished work");
            sts.Loger();
            Thread.Sleep(10000);
            Console.WriteLine("Second Loger() finished work");
            sts.Loger();
            Thread.Sleep(10000);
            Console.WriteLine("Third Loger() finished work");

            var sts1 = SingleToneStatic.GetInstanse();

            Console.WriteLine(ReferenceEquals(sts, sts1));


            //Lazy SingleTone
            var stlz = SingleToneLazy.GetInstanse();

            stlz.Loger();
            Thread.Sleep(10000);
            Console.WriteLine("First Loger() finished work");
            stlz.Loger();
            Thread.Sleep(10000);
            Console.WriteLine("Second Loger() finished work");
            stlz.Loger();
            Thread.Sleep(10000);
            Console.WriteLine("Third Loger() finished work");

            var stlz1 = SingleToneLazy.GetInstanse();

            Console.WriteLine(ReferenceEquals(stlz, stlz1));

            Console.ReadKey();
        }
    }
}
