using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotov_PIbd_21_C_sharp
{
    class DepoNotFoundException : Exception
    {
        public DepoNotFoundException(int i) : base("Не найден локомотив по месту " + i)
        { }
    }
}
