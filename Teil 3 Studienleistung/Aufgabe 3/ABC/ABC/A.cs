using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC
{
    class A
    {
        #region fields

        protected double _x;
        protected int _y;

        #endregion

        #region get/set

        public double X { get { return _x; } }
        public int Y { get { return _y; } }

        #endregion

        #region ctor

        public A(double x)
        {
            _y = (int) x;
            _x += _y;
        }

        #endregion

        #region methods

        public virtual int F(int x)
        {
            return 2;
        }

        public int F(float x)
        {
            return 3;
        }

        #endregion
    }
}
