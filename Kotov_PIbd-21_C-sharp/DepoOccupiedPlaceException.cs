using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotov_PIbd_21_C_sharp
{
    class DepoOccupiedPlaceException : Exception
    {
        public DepoOccupiedPlaceException(int i) : base("На месте " + i + " уже стоит локомотив")
        { }
    }
}
