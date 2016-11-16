using System;
using System.Text;

namespace NumericConversion
{
    public class IntegerConverter : IConvertInteger
    {
        private int number;           // number to convert
        private String result;        // result of conversion
        private LongConverter conv;   // reusing LongConverter

        // c'tor
        public IntegerConverter()
        {
            this.number = 0;
            this.result = "";

            this.conv = new LongConverter();
            this.conv.GroupSize = 4;
        }

        // properties
        public String Result
        {
            get { return this.result; }
        }

        public int Number
        {
            get { return this.number; }
            set { this.number = value; }
        }

        public int GroupSize
        {
            get { return this.conv.GroupSize; }
            set { this.conv.GroupSize = value; }
        }

        // methods
        public void ConvertBinary()
        {
            this.conv.Number = this.Number;
            this.conv.ConvertBinary();
            this.result = this.conv.Result;
        }

        public void ConvertDualBCD()
        {
            this.conv.Number = this.Number;
            this.conv.ConvertDualBCD();
            this.result = this.conv.Result;
        }

        public void ConvertHexadecimal()
        {
            this.conv.Number = this.Number;
            this.conv.ConvertHexadecimal();
            this.result = this.conv.Result;
        }

        // overrides
        public override String ToString()
        {
            return String.Format("{0} ==> {1}", this.number, this.result);
        }
    }
}



