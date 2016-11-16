using System;
using System.Text;

namespace NumericConversion
{
    public class LongConverter : IConvertLong
    {
        private long number;     // number to convert
        private String result;   // result of conversion
        private int groupSize;   // number of bits in a group

        // c'tor
        public LongConverter()
        {
            this.number = 0;
            this.result = "";
            this.groupSize = 4;
        }

        // properties
        public String Result
        {
            get { return this.result; }
        }

        public long Number
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
            StringBuilder sb = new StringBuilder();

            long n = this.number;

            if (n == 0)
            {
                if (this.groupSize == 4)
                    sb.Append("0000");
                else if (this.groupSize == 8)
                    sb.Append("00000000");
                else 
                    sb.Append("0000");
            }
            else
            {
                int separator = 0;
                while (n != 0)
                {
                    long rest = n % 2;
                    n /= 2;

                    sb.Insert(0, (rest == 1) ? "1" : "0");

                    separator++;
                    if (separator % this.groupSize == 0 && n != 0)
                        sb.Insert(0, " ");
                }

                // add leading zero's
                while (separator % this.groupSize != 0)
                {
                    sb.Insert(0, "0");
                    separator++;
                }
            }

            this.result = sb.ToString();
        }

        public void ConvertHexadecimal()
        {
            StringBuilder sb = new StringBuilder();

            long n = this.number;

            if (n == 0)
            {
                if (this.groupSize == 4)
                    sb.Append("0000");
                else if (this.groupSize == 8)
                    sb.Append("00000000");
                else
                    sb.Append("0000");
            }
            else
            {
                int separator = 0;
                while (n != 0)
                {
                    long rest = n % 16;
                    n /= 16;

                    if (rest >= 0 && rest < 9)
                    {
                        sb.Insert(0, (char) ('0' + rest));
                    }
                    else
                    {
                        sb.Insert(0, (char)('A' + (rest - 10)));
                    }

                    separator++;
                    if (separator % this.groupSize == 0 && n != 0)
                        sb.Insert(0, " ");
                }

                // add leading zero's
                while (separator % this.groupSize != 0)
                {
                    sb.Insert(0, "0");
                    separator++;
                }
            }

            this.result = sb.ToString();
        }

        public void ConvertDualBCD()
        {
            StringBuilder sb = new StringBuilder();

            LongConverter conv = new LongConverter();

            for (long n = number; n != 0; n /= 10)
            {
                conv.Number = n % 10;
                conv.ConvertBinary();
                String s = conv.Result;

                // add leading zero's, if necessary
                if (s.Length == 1)
                    s = "000" + s;
                else if (s.Length == 2)
                    s = "00" + s;
                else if (s.Length == 3)
                    s = "0" + s;

                if (n != number)
                    sb.Insert(0, " ");
                sb.Insert(0, s);
            }

            this.result = sb.ToString();
        }

        // overrides
        public override String ToString()
        {
            return String.Format("{0} ==> {1}", this.number, this.result);
        }
    }
}
