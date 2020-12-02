using System;
using System.Reflection;

namespace Adapter
{
    class Program
    {
        //https://ru.wikipedia.org/wiki/Адаптер_(шаблон_проектирования)
        //https://refactoring.guru/ru/design-patterns/adapter
        //https://habr.com/ru/post/85095/

        static void Main(string[] args)
        {
            FastHorse fastHorse = new FastHorse();
            RedCar redCar = new RedCar();
            Console.WriteLine("True Object");
            // fastHorse.Move();
            // fastHorse.Eating();
            testAdapter<FastHorse>(fastHorse);
            testAdapter<IHorse>(fastHorse);
            // redCar.Move();
            // redCar.Refueling();
            testAdapter<RedCar>(redCar);
            testAdapter<ICar>(redCar);
            Console.WriteLine("Horse Adapter");
            HorseAdapter horseAdapter = new HorseAdapter(fastHorse);
            //horseAdapter.Move();
            //horseAdapter.Refueling();
            testAdapter<ICar>(horseAdapter);
            Console.WriteLine("Car Adapter");
            CarAdapter carAdapter = new CarAdapter(redCar);
            //carAdapter.Move();
            //carAdapter.Eating();
            testAdapter<IHorse>(carAdapter);
        }

        static void testAdapter<T>(T obj) where T : class
        {
            Type type = typeof(T);
            MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

            foreach (var item in methods)
            {
                Console.WriteLine(item.Name);
                item.Invoke(obj, null);
            }
        }
    }
}
