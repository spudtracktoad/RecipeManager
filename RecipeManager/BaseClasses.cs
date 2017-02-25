using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe.Shared
{
    abstract public class BaseUnits
    {
        abstract public string Symbol { get; }
        abstract public string SymbolShort { get; }
    }

    abstract public class BaseMeasurment : BaseUnits
    {
        abstract public double Quantity { get; set; }
        //abstract new public string ToString { get; }
    }

}
