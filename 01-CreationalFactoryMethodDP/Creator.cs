using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CreationalFactoryMethodDP
{
    public class Creator
    {

        public MobileApplication FactoryMethod(AllMobileOS OSType)
        {
            MobileApplication ma = null;
            switch (OSType)
            {
                case AllMobileOS.Android:
                    ma = new AndroidOS();
                    break;
                case AllMobileOS.IOS:
                    ma = new IOS();
                    break;
                case AllMobileOS.HarmonyOS:
                    ma = new HarmonyOS();
                    break;
                default:
                    break;
            }
            return ma;
        }
        
    }
}
