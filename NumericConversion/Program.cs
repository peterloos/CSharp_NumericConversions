using System;

namespace NumericConversion
{
    class Program
    {
        public static void Main()
        {
            Test01();
            Test01a();
            Test01b();
            Test01c();
            Test01d();

            Test02();
            Test02a();
            Test02b();
            Test02c();
            Test02d();

            Test03a();
            Test03b();
            Test03c();

            Test04a();
            Test04b();
            Test04c();
            Test05a();
            Test05b();
        }

        private static void Test01()
        {
            IntegerConverter conv = new IntegerConverter();
            conv.Number = 65535;
            Console.WriteLine("{0}: ", conv.Number);
            conv.GroupSize = 8;
            conv.ConvertBinary();
            Console.WriteLine(conv.Result);
            conv.ConvertHexadecimal();
            Console.WriteLine(conv.Result);
            conv.Number = 65536;
            Console.WriteLine("{0}: ", conv.Number);
            conv.GroupSize = 8;
            conv.ConvertBinary();
            Console.WriteLine(conv.Result);
            conv.ConvertHexadecimal();
            Console.WriteLine(conv.Result);
            conv.Number = 255;
            Console.WriteLine("{0}: ", conv.Number);
            conv.GroupSize = 4;
            conv.ConvertBinary();
            Console.WriteLine(conv.Result);
            conv.ConvertHexadecimal();
            Console.WriteLine(conv.Result);
            conv.Number = 256;
            Console.WriteLine("{0}: ", conv.Number);
            conv.GroupSize = 4;
            conv.ConvertBinary();
            Console.WriteLine(conv.Result);
            conv.ConvertHexadecimal();
            Console.WriteLine(conv.Result);
        }

        private static void Test01a()
        {
            IntegerConverter conv = new IntegerConverter();
            conv.Number = 987654321;
            Console.WriteLine("{0}: ", conv.Number);
            conv.GroupSize = 8;
            conv.ConvertBinary();
            Console.WriteLine(conv.Result);
            conv.GroupSize = 4;
            conv.ConvertHexadecimal();
            Console.WriteLine(conv.Result);
        }

        private static void Test01b()
        {
            IntegerConverter conv = new IntegerConverter();
            conv.Number = 123456789;
            Console.WriteLine("{0}: ", conv.Number);
            conv.ConvertBinary();
            Console.WriteLine(conv.Result);
        }

        private static void Test01c()
        {
            IntegerConverter conv = new IntegerConverter();
            conv.Number = 12345678;
            Console.WriteLine("{0}: ", conv.Number);
            conv.ConvertDualBCD();
            Console.WriteLine(conv.Result);
        }

        private static void Test01d()
        {
            IntegerConverter conv = new IntegerConverter();
            Console.WriteLine("{0}: ", Int32.MaxValue);
            conv.Number = Int32.MaxValue;
            conv.ConvertDualBCD();
            Console.WriteLine(conv.Result);
        }

        private static void Test02()
        {
            LongConverter conv = new LongConverter();
            conv.Number = 123456789;
            Console.WriteLine("{0}: ", conv.Number);
            conv.GroupSize = 8;
            conv.ConvertBinary();
            Console.WriteLine(conv.Result);
            conv.GroupSize = 4;
            conv.ConvertHexadecimal();
            Console.WriteLine(conv.Result);
            conv.Number = 987654321;
            Console.WriteLine("{0}: ", conv.Number);
            conv.GroupSize = 4;
            conv.ConvertBinary();
            Console.WriteLine(conv.Result);
            conv.ConvertHexadecimal();
            Console.WriteLine(conv.Result);
        }

        private static void Test02a()
        {
            LongConverter conv = new LongConverter();
            conv.Number = 987654321;
            Console.WriteLine("{0}: ", conv.Number);
            conv.GroupSize = 8;
            conv.ConvertBinary();
            Console.WriteLine(conv.Result);
        }

        private static void Test02b()
        {
            LongConverter conv = new LongConverter();
            conv.Number = 123456789;
            Console.WriteLine("{0}: ", conv.Number);
            conv.GroupSize = 4;
            conv.ConvertBinary();
            Console.WriteLine(conv.Result);
        }

        private static void Test02c()
        {
            LongConverter conv = new LongConverter();
            conv.Number = 123456789;
            Console.WriteLine("{0}: ", conv.Number);
            conv.GroupSize = 4;
            conv.ConvertBinary();
            Console.WriteLine(conv.Result);
        }

        private static void Test02d()
        {
            LongConverter conv = new LongConverter();
            conv.Number = 12345678;
            Console.WriteLine("{0}: ", conv.Number);
            conv.ConvertDualBCD();
            Console.WriteLine(conv.Result);
        }

        private static void Test0e()
        {
            LongConverter conv = new LongConverter();
            Console.WriteLine("{0}: ", Int64.MaxValue);
            conv.Number = Int64.MaxValue;
            conv.ConvertDualBCD();
            Console.WriteLine(conv.Result);
        }

        private static void Test03a()
        {
            BigNumberConverter conv = new BigNumberConverter();
            conv.Number = new BigNumber("40613"); ;
            //conv.ConvertBinary();
            //Console.WriteLine(conv.Result);
            conv.ConvertHexadecimal();
            Console.WriteLine(conv.Result);
        }

        private static void Test03b()
        {
            BigNumberConverter conv = new BigNumberConverter();
            conv.Number = new BigNumber("12345678987654321"); ;
            //conv.ConvertBinary();
            //Console.WriteLine(conv.Result);
            conv.ConvertHexadecimal();
            Console.WriteLine(conv.Result);
        }

        private static void Test03c()
        {
            BigNumberConverter conv = new BigNumberConverter();
            conv.Number = new BigNumber("11111111111111111111111111111111111111111111111111111111111111111111111111"); ;
            conv.ConvertBinary();
            Console.WriteLine(conv.Result);
        }

        private static void Test04a()
        {
            BigNumber number;

            number = new BigNumber("0");
            Console.WriteLine(number);

            number = new BigNumber("0000");
            Console.WriteLine(number);

            number = new BigNumber("12345");
            Console.WriteLine(number);

            number = new BigNumber("012345");
            Console.WriteLine(number);

            number = new BigNumber("0000012345");
            Console.WriteLine(number);
        }

        private static void Test04b()
        {
            BigNumber number = new BigNumber("12345");
            BigNumber half = number.DivideByTwo();
            Console.WriteLine(half);
        }  

        private static void Test04c()
        {
            BigNumberConverter conv = new BigNumberConverter();
            conv.Number = new BigNumber("256");
            Console.Write("{0}: ", conv.Number);
            conv.ConvertBinary();
            Console.WriteLine(conv.Result);
            conv.Number = new BigNumber("4096");
            Console.Write("{0}: ", conv.Number);
            conv.ConvertBinary();
            Console.WriteLine(conv.Result);
            conv.Number = new BigNumber("2475880078570760549798248448");
            Console.Write("{0}: ", conv.Number);
            conv.ConvertBinary();
            Console.WriteLine(conv.Result);
        }

        private static void Test05a()
        {
            BigNumberConverter conv = new BigNumberConverter();
            conv.Number = new BigNumber("2365");
            Console.Write("{0}: ", conv.Number);
            conv.ConvertDualBCD();
            Console.WriteLine(conv.Result);
        }

        private static void Test05b()
        {
        BigNumberConverter conv = new BigNumberConverter();
        conv.Number = new BigNumber("123456789");
        Console.Write("{0}: ", conv.Number);
        conv.ConvertDualBCD();
        Console.WriteLine(conv.Result);
        }
    }
}
