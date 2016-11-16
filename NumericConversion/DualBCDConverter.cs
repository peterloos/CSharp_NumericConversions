//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace NumericConversion
//{
// c'tor
//    public class DualBCDConverter : IConvertDualBCD
//    {
//        private long number;
//        private String result;

//        public DualBCDConverter()
//        {
//            this.number = 0;
//            this.result = "";
//        }

//        // properties
//        public string Result
//        {
//            get { return this.result; }
//        }

//        public long Number
//        {
//            get { return this.number; }
//            set { this.number = value; }
//        }

//        // method(s)
//        public void ConvertBCD()
//        {
//            StringBuilder sb = new StringBuilder();
//            BinaryConverter conv = new BinaryConverter();

//            for (long n = number; n != 0; n /= 10)
//            {
//                conv.Number = n % 10;
//                conv.Convert();
//                String s = conv.Result;

//                // add leading zero's, if necessary
//                if (s.Length == 1)
//                    s = "000" + s;
//                else if (s.Length == 2)
//                    s = "00" + s;
//                else if (s.Length == 3)
//                    s = "0" + s;

//                if (n != number)
//                    sb.Insert(0, " ");
//                sb.Insert(0, s);
//            }

//            this.result = sb.ToString();
//        }

//        // overrides
//        public override String ToString()
//        {
//            return String.Format("{0} ==> {1}", this.number, this.result);
//        }
//    }
//}
