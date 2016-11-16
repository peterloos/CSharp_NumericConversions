using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericConversion
{
    public interface IConvertLong : IConvert
    {
        long Number { get; set; }
    }
}
