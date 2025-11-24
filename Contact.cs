using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book_System
{
    internal class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}\nAddress: {Address}, {City}, {State}, {Zip}\nPhone: {PhoneNumber}\nEmail: {Email}";
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
