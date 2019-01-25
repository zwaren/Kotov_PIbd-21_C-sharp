using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotov_PIbd_21_C_sharp
{
	class DepoAlreadyHaveException : Exception
	{
		public DepoAlreadyHaveException() : base("В депо уже есть такой локомотив") { }
	}
}
