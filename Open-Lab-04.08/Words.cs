using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_04._08
{
    class Words
    {
        public string[] FourChar(string[] stringarr)
        {
            var lis = new List<string> { };
            foreach (var item in stringarr)
                if (item.ToCharArray().Length == 4)
                    lis.Add(item);
            return lis.ToArray();

        }
    }
}
