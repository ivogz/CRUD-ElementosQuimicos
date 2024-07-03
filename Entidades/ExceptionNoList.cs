using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ExceptionNoList : Exception
    {
        public ExceptionNoList()
        {
        }

        public ExceptionNoList(string message)
            : base(message)
        {
        }

        public ExceptionNoList(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
