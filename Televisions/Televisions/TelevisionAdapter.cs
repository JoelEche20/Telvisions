using System;
using System.Collections.Generic;
using System.Text;

namespace Televisions
{
    class TelevisionAdapter : HRSystem, ITelevisions
    {
        public List<string> GetTelevisionsList()
        {
            List<string> televisionsList = new List<string>();
            string[][] televisions = GetTelevisions();
            foreach (string[] television in televisions)
            {
                televisionsList.Add(television[0]);
                televisionsList.Add(",");
                televisionsList.Add(television[1]);
                televisionsList.Add(",");
                televisionsList.Add(television[2]);
                televisionsList.Add("\n");
            }

            return televisionsList;
        }
    }
}
