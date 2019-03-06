using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorke5
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Создать индексатор для одномерного массива который при установке значения 
            //    будет возводить в квадрат передаваемое значение переменной и устанавливать 
            //    его для указанного индекса.При получении элемента массива по индексу будет 
            //    возвращаться его текущее значение

            Array array = new Array(10);
            Random rnd = new Random();          

            for (int i = 0; i < array.Size; i++)
            {
                array[i] = rnd.Next(0, 10);
            }

            for (int i = 0; i < array.Size; i++)
            {
                Console.WriteLine(i + "\t" + array[i]);
            }  
                       
            Console.ReadLine();
        }
    }
}
