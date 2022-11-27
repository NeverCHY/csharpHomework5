using ClassLibraryForProj04;
using System;
using System.Reflection;
namespace p04
{
    class pro
    {
        public static Assembly ass = Assembly.Load("ClassLibrary04");
        public static void getM()
        {
            foreach (var item in ass.GetModules())
            {
                Console.WriteLine(item.FullyQualifiedName);
            }
        }
        public static void getT()
        {
            foreach (var item in ass.GetTypes())
            {
                foreach (var sub in item.GetProperties())
                {
                    Console.WriteLine(item.Name + ":" + sub.Name);
                }
            }
        }
        static void Main(string[] args)
        {
            getM();
            Type t1 = ass.GetType("ClassLibrary04.Math");
            IMath m = (IMath)Activator.CreateInstance(t1);
            Console.WriteLine(m.add(3, 2).ToString());
            Console.WriteLine(m.multiply(5, 1).ToString());
        }
    }
}
