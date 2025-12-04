using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Address_Book_System
{
    internal class AddressBookService
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
            string zip;
            while (true)
            {
                Console.Write("Enter Zip: ");
                zip = Console.ReadLine();
                if (zipCheck(zip))
                {
                    c.Zip = zip;
                    break;

                }
                Console.WriteLine("Invalid Zip!");
            }
            string PhoneNumber;
            while (true)
            {
                Console.Write("Enter Phone Number: ");
                PhoneNumber = Console.ReadLine();
                if (NumberCheck(PhoneNumber))
                {
                    c.PhoneNumber = PhoneNumber;
                    break;
                }
                Console.WriteLine("invalid phone number atleast 10 digit should be their! ");
            }


            string Email;

            while (true)
            {
                Console.Write("Enter Email: ");
                Email = Console.ReadLine();

                if (EmailCheck(Email))
                {
                    c.Email = Email;  
                    break;
                }

                Console.WriteLine("Enter a valid email address");
            }
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
        // UC4 – Delete Contact
        public void DeleteContact(string name)
        {
            var person = contacts.FirstOrDefault(c => c.FirstName.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (person == null)
            {
                Console.WriteLine("Contact Not Found!");
                return;
            }

            contacts.Remove(person);
            Console.WriteLine("Contact Deleted Successfully!");
        }
        // UC5 – Display Contacts
        public void DisplayContacts()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("No Contacts Available.");
                return;
            }

            foreach (var c in contacts)
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine(c);
            }
        }
        // UC 6 regex 
        public bool EmailCheck(string email)
        {
            string pattern = @"^[\w.-]+@\w+\.\w{2,}$";
            return  Regex.IsMatch(email, pattern);   
        }
        public bool NumberCheck(string Phonenumber)
        {
            string pattern = @"^\d{10}$";
            return  Regex.IsMatch(Phonenumber, pattern);
        }
        public bool zipCheck(string zip)
        {
            string pattern = @"^\d{6}$";
            return Regex.IsMatch(zip, pattern);
                
        }
    }
}
