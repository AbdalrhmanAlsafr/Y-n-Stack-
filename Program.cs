using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {

        
        static void Main(string[] args)
        {
            Stack dizi = new Stack();
            dizi.Push(1);
            dizi.Push(2);
            dizi.Push(3);
            
            foreach (int i in dizi)
                Console.WriteLine(i);

            dizi.Pop();
       
            foreach (int i in dizi)
                Console.WriteLine(i);

            Console.ReadLine();
        }








    }
}
