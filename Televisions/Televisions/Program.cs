using System;

namespace Televisions
{
    class Program
    {
        static void Main(string[] args)
        {
            ITelevisions Itelevision = new TelevisionAdapter();
            ThirdPartyBillingSystem client = new ThirdPartyBillingSystem(Itelevision);
            client.ShowTelevisionsList();

            Console.ReadKey();
        }
    }
}
