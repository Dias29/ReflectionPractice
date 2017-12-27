using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Type list = typeof(List<>);
            Type[] types = new Type[1];
            types[0] = typeof(object);

            ConstructorInfo info = list.GetConstructor(new Type[] {typeof(object)});

            Console.WriteLine("Конструкторы класса List<object> : " + info.ToString());
            Console.ReadLine();
        }
    }
}
