namespace F26W3IntroToInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BaseClass objBase = new BaseClass();
            //objBase.myPrivateVar = 1;
            //objBase.myProtectedVar = 2;
            //objBase.myPublicVar = 3;

            DerivedClass objDerived = new DerivedClass("hello");
            //objDerived.myPublicVar = 3;
        }
    }
}
