using System;
using System.Collections.Generic;
using System.Text;

namespace ExException.Entities.Exceptions
{
    class DomainExeception : ApplicationException
    {
        public DomainExeception(string message) : base(message)
        {
        }
    }
}
