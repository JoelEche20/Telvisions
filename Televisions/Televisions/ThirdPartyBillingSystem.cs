using System;
using System.Collections.Generic;
using System.Text;

namespace Televisions
{
    class ThirdPartyBillingSystem
    {
        private ITelevisions _televisionSource;

        public ThirdPartyBillingSystem(ITelevisions televisionSource)
        {
            this._televisionSource = televisionSource;
        }

        public void ShowTelevisionsList()
        {
            List<String> televisions = _televisionSource.GetTelevisionsList();

            Console.WriteLine("---------Televisions List-------");

            foreach(var television in televisions)
            {
                Console.WriteLine(television);
            }
        }
    }
}
