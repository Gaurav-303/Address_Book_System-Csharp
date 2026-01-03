using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book_System
{
    internal class AddressBookManager
    {
        private List<AddressBook> addressBooks = new List<AddressBook>();

        public void AddAddressBook(string name)
        {
            if (addressBooks.Any(ab =>
                ab.Name.Equals(name, StringComparison.OrdinalIgnoreCase)))
            {
                throw new DuplicateAddressBookException(
                    $"Address Book with name '{name}' already exists");
            }

            addressBooks.Add(new AddressBook { Name = name });
            Console.WriteLine($"Address Book '{name}' created successfully");
        }

        public void DisplayAddressBooks()
        {
            if (addressBooks.Count == 0)
            {
                Console.WriteLine("No Address Books Available");
                return;
            }

            foreach (var ab in addressBooks)
            {
                Console.WriteLine(ab.Name);
            }
        }
    }
    }
