namespace _01_CreationalFactoryMethodDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Creator cr = new Creator();
            MobileApplication mobileAndroid = cr.FactoryMethod(AllMobileOS.Android);
            MobileApplication mobileIOS = cr.FactoryMethod(AllMobileOS.IOS);
            MobileApplication mobileHarmony = cr.FactoryMethod(AllMobileOS.HarmonyOS);


            mobileAndroid.Platform();
            mobileIOS.Platform();
            mobileHarmony.Platform();
            Console.ReadLine();
        }
    }
}