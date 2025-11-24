using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book_System
{
    internal class AddressBook
    {
        private List<Contact> contacts = new List<Contact>();

        // UC2 – Add Contact
        public void AddContact()
        {
            Contact c = new Contact();

            Console.Write("Enter First Name: ");
            c.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            c.LastName = Console.ReadLine();

            Console.Write("Enter Address: ");
            c.Address = Console.ReadLine();

            Console.Write("Enter City: ");
            c.City = Console.ReadLine();

            Console.Write("Enter State: ");
            c.State = Console.ReadLine();

            Console.Write("Enter Zip: ");
            c.Zip = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            c.PhoneNumber = Console.ReadLine();

            Console.Write("Enter Email: ");
            c.Email = Console.ReadLine();

            contacts.Add(c);
            Console.WriteLine("Contact Added Successfully!");
        }
        // UC3 – Edit Contact
        public void EditContact(string name)
        {
            Contact contact = contacts.FirstOrDefault(c => c.FirstName.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (contact == null)
            {
                Console.WriteLine("Contact Not Found!");
                return;
            }

            Console.Write("Enter New Address: ");
            contact.Address = Console.ReadLine();

            Console.Write("Enter New City: ");
            contact.City = Console.ReadLine();

            Console.Write("Enter New State: ");
            contact.State = Console.ReadLine();

            Console.Write("Enter New Zip: ");
            contact.Zip = Console.ReadLine();

            Console.Write("Enter New Phone Number: ");
            contact.PhoneNumber = Console.ReadLine();

            Console.Write("Enter New Email: ");
            contact.Email = Console.ReadLine();

            Console.WriteLine("Contact Updated Successfully!");
        }
    }
}
