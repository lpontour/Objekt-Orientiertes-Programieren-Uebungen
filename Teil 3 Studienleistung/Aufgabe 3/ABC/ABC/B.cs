using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC
{
    class B : A
    {
        #region fields

        #endregion

        #region get/set

        #endregion

        #region ctor
        public B(double x) : base(x)
        {
            _y = 2 * (int) x;
        }
        #endregion

        #region methods
        public override int F(int x)
        {
            return(4);
        }

        public void G(double value)
        {
            _x = _x + value;
        }
        #endregion
    }
}
