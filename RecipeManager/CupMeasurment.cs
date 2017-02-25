using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe.Shared
{
    public class CupMeasurment : BaseMeasurment
    {
        #region " Private "
        private double _Quantity;
        #endregion  
        public override double Quantity
        {
            get
            {
                return _Quantity;
            }
            set
            {
                _Quantity = value;
            }
        }

        public override string Symbol
        {
            get { return "Cup"; }
        }

        public override string SymbolShort
        {
            get { return "C"; }
        }

        //public override string ToString
        //{
        //    get { throw new NotImplementedException(); }
        //}
    }
}
