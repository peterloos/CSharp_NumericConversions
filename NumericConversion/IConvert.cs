using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericConversion
{
    public interface IConvert
    {
        String Result { get; }
        int GroupSize { get; set; }

        void ConvertBinary();
        void ConvertDualBCD();
        void ConvertHexadecimal();
    }
}
