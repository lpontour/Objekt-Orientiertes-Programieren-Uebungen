using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC
{
    class C : B
    {
        #region fields

        #endregion

        #region get/set

        #endregion

        #region ctor

        public C(double x) : base(x)
        {
            _y = 3 * (int)x;
        }

        #endregion

        #region methods
        public override int F(int x)
        {
            return(5);
        }
        #endregion
    }
}
