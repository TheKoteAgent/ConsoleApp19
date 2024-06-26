﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        public delegate void Parn(int a);
        public delegate void Parn12(int[] a);
        public delegate void Parn1(string a);
        public delegate void MyDelegate();
        public delegate string Delegate_1(string str);

        static void Main(string[] args)
        {
            int[] numb = { 5,1,2,3 };

            //1
            Parn pa = delegate (int a)
            {
                if (a % 2 == 0)
                {
                    Console.WriteLine("Parne");
                }
                else
                {
                    Console.WriteLine("ne parne");
                }
            };
            pa(5);
            //2
            Parn kva = delegate (int a)
            {
                Console.WriteLine(a * a);
            };
            kva(3);
            //3
            Parn del_3 = (int a) =>
            {
                Console.WriteLine(a*a*a);
            };
            del_3(2);
            //4
            Parn1 del_4 = (string a) =>
            {
                if (int.TryParse(a, out int day))
                {
                    if (day == 256)
                    {
                        Console.WriteLine("day");
                    }
                    else
                    {
                        Console.WriteLine("not a day");
                    }
                }
            };
            del_4("256");
            //5
            Parn12 del_5 = (int[] a) =>
            {
                Console.WriteLine(a.Max());
            };
            del_5(numb);
            //6
            Parn12 del_6 = (int[] a) =>
            {
                Console.WriteLine(a.Min());
            };
            del_6(numb);
            //7
            Console.WriteLine("ne par v mass");
            Parn12 del_7 = (int[] a) =>
            {              
                foreach (int num in a)
                {
                    if(num%2 != 0){
                        Console.WriteLine(num);
                    }
                    
                }
            };
            del_7(numb);
        }

    }
}
