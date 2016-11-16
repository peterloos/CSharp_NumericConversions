using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericConversion
{
    public interface IConvertBigNumber : IConvert
    {
        BigNumber Number { get; set; }
    }
}
