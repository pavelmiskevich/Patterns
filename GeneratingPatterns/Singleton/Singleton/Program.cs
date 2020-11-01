using System;
using System.Threading;

namespace Singleton
{
    class Program
    {
        //https://metanit.com/sharp/patterns/2.3.php
        //https://refactoring.guru/ru/design-patterns/singleton/csharp/example#example-1
        //https://professorweb.ru/my/it/blog/net/singleton_csharp.php
        //https://shwanoff.ru/singleton/amp/
        static void Main(string[] args)
        {
            (new Thread(() =>
            {
                Console.WriteLine(SingletonLock.getInstance().Date);

            })).Start();
            (new Thread(() =>
            {
                Console.WriteLine(SingletonLock.getInstance().Date);

            })).Start();
            Console.WriteLine(SingletonLock.getInstance().Date);

            (new Thread(() =>
            {
                Console.WriteLine(SingletonRO.getInstance().Date);

            })).Start();
            (new Thread(() =>
            {
                Console.WriteLine(SingletonRO.getInstance().Date);

            })).Start();
            Console.WriteLine(SingletonRO.getInstance().Date);

            Console.WriteLine(SingletonNested.text);
            (new Thread(() =>
            {
                Console.WriteLine(SingletonNested.getInstance().Date);

            })).Start();            
            (new Thread(() =>
            {
                Console.WriteLine(SingletonNested.getInstance().Date);

            })).Start();
            Console.WriteLine(SingletonNested.getInstance().Date);

            (new Thread(() =>
            {
                Console.WriteLine(SingletonROLazy.getInstance().Date);

            })).Start();
            (new Thread(() =>
            {
                Console.WriteLine(SingletonROLazy.getInstance().Date);

            })).Start();
            Console.WriteLine(SingletonROLazy.getInstance().Date);

            Console.ReadLine();            
        }
    }
}
