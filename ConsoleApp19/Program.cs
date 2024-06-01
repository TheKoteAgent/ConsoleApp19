using System;
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
            var a = new A();
            Parn pa = a.Par;
            pa(5);
            //2
            var b = new A();
            Parn kva = b.kvad;
            kva(3);
            //3
            Parn del_2 = (int a) =>
            {
                Console.WriteLine(a*a*a);
            };
            del_2(2);
            //4
            Parn1 del_3 = (string a) =>
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
            del_3("256");
            //5
            Parn12 del_4 = (int[] a) =>
            {
                Console.WriteLine(a.Max());
            };
            del_4(numb);
            //6
            Parn12 del_5 = (int[] a) =>
            {
                Console.WriteLine(a.Min());
            };
            del_5(numb);
            //7
            Console.WriteLine("ne par v mass");
            Parn12 del_6 = (int[] a) =>
            {              
                foreach (int num in a)
                {
                    if(num%2 != 0){
                        Console.WriteLine(num);
                    }
                    
                }
            };
            del_6(numb);

            //Delegate_1 del_1 = delegate (string str)
            //{
            //    Console.WriteLine(str);
            //    return str;
            //};
            ////делегати
            //var a = new A();
            //MyDelegate del = a.Show;
            //del();
            //Delegate_1 del_1 = delegate (string str)
            //{
            //    Console.WriteLine(str);
            //    return str;
            //};
            //del_1("Hello");


            ////лямбда


            //Delegate_1 del_2 = (str) =>
            //{
            //    Console.WriteLine(str);
            //    return "Hello";
            //};
            //MyDelegate del_3 = () =>
            //{
            //    Console.WriteLine("Maksym");   
            //};
        }

    }
    public class A
    {
        public void Par(int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine("Parne");
            }
            else { Console.WriteLine("ne parne"); }
        }
        public void kvad(int a)
        {
            
           Console.WriteLine(a*a);
        }
    }
}
