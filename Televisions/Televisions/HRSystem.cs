using System;
using System.Collections.Generic;
using System.Text;

namespace Televisions
{
    class HRSystem
    {
        public string[][] GetTelevisions()
        {
            string[][] televisions = new string[4][];

            televisions[0] = new string[] { "1", "Samsung", "42 pulgadas" };
            televisions[1] = new string[] { "2", "LG", "30 pulgadas" };
            televisions[2] = new string[] { "3", "Philips", "25 pulgadas" };
            televisions[3] = new string[] { "4", "Sony", "50 pulgadas" };

            return televisions;
        }
    }
}
