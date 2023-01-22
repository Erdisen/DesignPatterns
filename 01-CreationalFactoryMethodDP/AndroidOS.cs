using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CreationalFactoryMethodDP
{
    public class AndroidOS : MobileApplication
    {
        public override void Platform()
        {
            Console.WriteLine("Bu uygulama Android OS için çalışacaktır.");

        }
    }
}
