using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericConversion
{
    public interface IConvertInteger : IConvert
    {
        int Number { get; set; }
    }
}
