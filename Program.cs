using System;

namespace degiskenler
{

    class Program
    {

        static void Main(string[] args)
        {

            byte b = 2;
            sbyte s = 3;

            short sh = -3;
            ushort us = 3;
            int i = 1;
            Int16 i16 = 12;
            Int32 i32 = 15;
            Int64 i64 = 16;
            uint ui = 121;
            long l = 132;
            ulong ul = 264;
            float f = 887;
            double d = 8.98;
            decimal de = 1512;
            char c = 'b';
            string st = "Alican ZEYBEL";
            bool b1 = true;
            bool b2 = false;
            DateTime dt = DateTime.Now;

            object obj1 = 'a';
            int i23 = 28;
            string str23 = "362";

            int int21 = i23 + Convert.ToInt32(str23);

            Console.WriteLine(int21);

            string str22 = "25";
            int i12 = 12;

            int toplam = i12 + Int16.Parse(str22);

            Console.WriteLine(toplam);

        }
    }
}