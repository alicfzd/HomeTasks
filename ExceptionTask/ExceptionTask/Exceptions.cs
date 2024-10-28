using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTask
{
    public class ReservedDateInterval : Exception
    {
        public ReservedDateInterval(string message) : base(message) { }
    }

    public class WrongDateInterval : Exception
    {
        public WrongDateInterval(string message) : base(message) { }
    }
}
