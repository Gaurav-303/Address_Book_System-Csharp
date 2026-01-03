using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book_System
{
    internal class DuplicateAddressBookException : Exception
    {
        public DuplicateAddressBookException(string message) : base(message)
        {
        }
    }
}
