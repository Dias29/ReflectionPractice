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
            //Type list = typeof(List<>);
            //Type[] types = new Type[1];
            //types[0] = typeof(object);

            //ConstructorInfo info = list.GetConstructors()

            //Console.WriteLine("Конструкторы класса List<object> : " + info.ToString());
            //Console.ReadLine();

            //void ConstructorReflectInfo<T> (T obj) where T : List<>
            //{
                Type t = typeof(List<>);
                ConstructorInfo con = t.GetConstructor(Type.EmptyTypes);
                Console.WriteLine(t.ToString());
            //}

            Console.ReadLine();
        }
    }
}
