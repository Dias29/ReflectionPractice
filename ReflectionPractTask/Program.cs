using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionPractTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string str= "Не ищите идеального человека. Сегодня я дома. (с) А. Челентано";

            Type type = typeof(String);
            
            MethodInfo method = type.GetMethod("Substring", new Type[] {typeof(int), typeof(int)});

            object methodValue = method.Invoke(str, new object[] { 30, 14 });

            Console.WriteLine(methodValue);

            Console.ReadLine();
        }
    }
}
