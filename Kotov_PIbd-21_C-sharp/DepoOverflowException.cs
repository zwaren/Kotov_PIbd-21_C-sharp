using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotov_PIbd_21_C_sharp
{
    class DepoOverflowException : Exception
    {
        public DepoOverflowException() : base("В депо нет свободных мест")
        { }
    }
}
