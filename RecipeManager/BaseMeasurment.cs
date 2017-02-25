using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe.Shared
{
    public class BaseMeasurment
    {
        #region " Private "

        #endregion
        #region " Public "
        private double _Measurment;

        public double Measurment
        {
            get { return _Measurment; }
            set { _Measurment = value; }
        }

        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }
        
        
        #endregion

    }
}
