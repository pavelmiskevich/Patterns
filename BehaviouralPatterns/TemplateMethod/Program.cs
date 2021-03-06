﻿using System;

namespace TemplateMethod
{
    //https://refactoring.guru/ru/design-patterns/template-method
    //https://ru.wikipedia.org/wiki/%D0%A8%D0%B0%D0%B1%D0%BB%D0%BE%D0%BD%D0%BD%D1%8B%D0%B9_%D0%BC%D0%B5%D1%82%D0%BE%D0%B4_(%D1%88%D0%B0%D0%B1%D0%BB%D0%BE%D0%BD_%D0%BF%D1%80%D0%BE%D0%B5%D0%BA%D1%82%D0%B8%D1%80%D0%BE%D0%B2%D0%B0%D0%BD%D0%B8%D1%8F)
    //https://metanit.com/sharp/patterns/3.4.php

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Building Cottage");
            var teamOfBuilders = new TeamOfBuilders(new Cottage());
            Console.WriteLine("Building Wigwam");
            var teamOfBuilders2 = new TeamOfBuilders(new Wigwam());
        }
    }
}
