using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book_System
{
    internal class AddressBook
    {
        public string Name { get; set; }
        public AddressBookService Service { get; set; } = new AddressBookService();
    }
}
