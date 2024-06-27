using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio.Entities.Exceptions
{
    internal class WithdrawExceedsLimitException : Exception
    {
        public WithdrawExceedsLimitException(string msg) : base(msg) { }
    }
}
