﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CreationalFactoryMethodDP
{
    public class HarmonyOS : MobileApplication
    {
        public override void Platform()
        {
            Console.WriteLine("Bu uygulama Harmony OS için çalışacaktır.");
        }
    }
}
