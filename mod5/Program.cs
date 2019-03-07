using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace mod5
{
    class Program
    {
        static void Main(string[] args)
        {
            task3_1();
        }
        static void task1()
        {
            //1.Перехватить исключение запроса к несуществующему 
            //    веб ресурсу и вывести сообщение о том, что 
            //    произошла ошибка.Программа должна завершиться 
            //    без ошибок.
            try
            {
                WebRequest.Create("asdasdasd");
            }
            catch
            {
                Console.WriteLine("error!");
            }
        }
        static void task2()
        {
            //2.Написать программу, которая обращается 
            //    к элементам массива по индексу и выходит 
            //    за его пределы. После обработки исключения 
            //    вывести в финальном блоке сообщение о завершении 
            //    обработки массива.
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }
            for (int i = 0; i < arr.Length+2; i++)
            {
                try
                {
                    Console.WriteLine(arr[i]);
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("array handling completed!");
                    return;
                }
                
            }
        }
        static void task3_1()
        {
            //3.Реализовать несколько методов или классов с 
            //    методами и вызвать один метод из другого. 
            //    В вызываемом методе сгенерировать исключение 
            //    и «поднять» его в вызывающий метод.
            try
            {
                task3_2();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void task3_2()
        {
            throw new Exception("Hello!");
        }

    }
}
