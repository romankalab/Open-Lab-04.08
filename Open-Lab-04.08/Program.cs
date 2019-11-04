using System;

namespace Open_Lab_04._08
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringarr = new string[4];
            for (var x = 0; x < stringarr.Length; x++)
                stringarr[x] = Console.ReadLine();
                

            Words words = new Words();
            string[] arr1 = words.FourChar(stringarr);
            foreach (var item in arr1)
                Console.Write(item + ", ");
        }
    }
}
