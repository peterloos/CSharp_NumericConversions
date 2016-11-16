using System;
using System.Text;

namespace NumericConversion
{
    class BigNumberConverter : IConvertBigNumber
    {
        private BigNumber number; // number to convert
        private String result;    // result of conversion
        private int groupSize;    // number of bits in a group 

        // c'tor
        public BigNumberConverter()
        {
            this.result = "";
            this.groupSize = 4;
        }

        // properties
        public String Result
        {
            get { return this.result; }
        }

        public BigNumber Number
        {
            get { return this.number; }
            set { this.number = value; }
        }

        public int GroupSize
        {
            get { return this.groupSize; }
            set { this.groupSize = value; }
        }

        // methods
        public void ConvertBinary()
        {
            StringBuilder sb = new StringBuilder("");

            int separator = 0;

            while (!number.IsNull)
            {
                sb.Insert(0, (number.RemainderModulusTwo() == 1) ? "1" : "0");
                number = number.DivideByTwo();

                separator++;
                if (separator % this.groupSize == 0 && !number.IsNull)
                    sb.Insert(0, " ");
            }

            this.result = sb.ToString();
        }

        public void ConvertDualBCD()
        {
            StringBuilder sb = new StringBuilder();
            IntegerConverter conv = new IntegerConverter();

            for (int i = 0; i < this.Number.Length; i++)
            {
                conv.Number = this.Number[i];
                conv.ConvertDualBCD();

                if (i > 0)
                    sb.Append (" ");

                sb.Append (conv.Result);
            }

            this.result = sb.ToString();
        }

        //public void ConvertHexadecimal()
        //{
        //    StringBuilder sb = new StringBuilder("");

        //    int separator = 0;

        //    while (!number.IsNull)
        //    {
        //        sb.Insert(0, (number.RemainderModulusTwo() == 1) ? "1" : "0");
        //        number = number.DivideByTwo();

        //        separator++;
        //        if (separator % this.groupSize == 0 && !number.IsNull)
        //            sb.Insert(0, " ");
        //    }

        //    this.result = sb.ToString();
        //}

        public void ConvertHexadecimal()
        {
            StringBuilder sb = new StringBuilder("");

            int separator = 0;

            while (!number.IsNull)
            {
                int remainder = 0;

                remainder = 2 * remainder + number.RemainderModulusTwo();
                remainder = 2 * remainder + number.RemainderModulusTwo();
                remainder = 2 * remainder + number.RemainderModulusTwo();
                remainder = 2 * remainder + number.RemainderModulusTwo();

                if (remainder >= 0 && remainder < 9)
                {
                    sb.Insert(0, (char)('0' + remainder));
                }
                else
                {
                    sb.Insert(0, (char)('A' + (remainder - 10)));
                }

                number = number.DivideByTwo();
                number = number.DivideByTwo();
                number = number.DivideByTwo();
                number = number.DivideByTwo();

                separator++;
                if (separator % this.groupSize == 0 && !number.IsNull)
                    sb.Insert(0, " ");
            }

            this.result = sb.ToString();
        }
    }
}
