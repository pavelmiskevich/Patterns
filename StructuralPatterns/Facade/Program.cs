﻿using System;

namespace Facade
{
    class Program
    {
        //https://refactoring.guru/ru/design-patterns/facade
        //https://ru.wikipedia.org/wiki/%D0%A4%D0%B0%D1%81%D0%B0%D0%B4_(%D1%88%D0%B0%D0%B1%D0%BB%D0%BE%D0%BD_%D0%BF%D1%80%D0%BE%D0%B5%D0%BA%D1%82%D0%B8%D1%80%D0%BE%D0%B2%D0%B0%D0%BD%D0%B8%D1%8F)
        //https://metanit.com/sharp/patterns/4.3.php

        static void Main(string[] args)
        {
            Facade facade = new Facade(new Kitty(), new Light(), new Music());
            facade.Enter();
            facade.Exit();
        }
    }
}
