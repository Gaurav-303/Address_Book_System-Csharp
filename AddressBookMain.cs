using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book_System
{
    internal class AddressBookMain
    {
         
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program!");

            Dictionary<string, AddressBookService> addressBooks = new Dictionary<string, AddressBookService>();

            while (true)
            {
                Console.WriteLine("\n1. Create New Address Book");
                Console.WriteLine("2. Add Contact");
                Console.WriteLine("3. Edit Contact");
                Console.WriteLine("4. Delete Contact");
                Console.WriteLine("5. Show Contacts");
                Console.WriteLine("6. Exit");
                Console.Write("Enter Choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Address Book Name: ");
                        string bookName = Console.ReadLine();
                        addressBooks[bookName] = new AddressBookService();
                        Console.WriteLine("New Address Book Created!");
                        break;

                    case 2:
                        Console.Write("Enter Address Book Name: ");
                        string b1 = Console.ReadLine();

                        if (addressBooks.ContainsKey(b1))
                            addressBooks[b1].AddContact();
                        else
                            Console.WriteLine("Address Book Not Found!");
                        break;

                    case 3:
                        Console.Write("Enter Address Book Name: ");
                        string b2 = Console.ReadLine();

                        Console.Write("Enter First Name of Contact to Edit: ");
                        string nameEdit = Console.ReadLine();

                        if (addressBooks.ContainsKey(b2))
                            addressBooks[b2].EditContact(nameEdit);
                        else
                            Console.WriteLine("Address Book Not Found!");
                        break;

                    case 4:
                        Console.Write("Enter Address Book Name: ");
                        string b3 = Console.ReadLine();

                        Console.Write("Enter First Name of Contact to Delete: ");
                        string nameDel = Console.ReadLine();

                        if (addressBooks.ContainsKey(b3))
                            addressBooks[b3].DeleteContact(nameDel);
                        else
                            Console.WriteLine("Address Book Not Found!");
                        break;

                    case 5:
                        Console.Write("Enter Address Book Name: ");
                        string b4 = Console.ReadLine();

                        if (addressBooks.ContainsKey(b4))
                            addressBooks[b4].DisplayContacts();
                        else
                            Console.WriteLine("Address Book Not Found!");
                        break;
                    case 6:
                        Console.Write("Enter Address Book Name: ");
                        string b5 = Console.ReadLine();

                        if (addressBooks.ContainsKey(b5))
                            addressBooks[b5].AddContactsUsingMultithreading();
                        else
                            Console.WriteLine("Address Book Not Found!");
                        break;
                    case 7:
                        Console.Write("Enter Address Book Name: ");
                        string b7 = Console.ReadLine();

                        Console.Write("Enter First Name 1 to Edit: ");
                        string e1 = Console.ReadLine();

                        Console.Write("Enter First Name 2 to Edit: ");
                        string e2 = Console.ReadLine();

                        if (addressBooks.ContainsKey(b7))
                            addressBooks[b7].EditContactsUsingMultithreading(e1, e2);
                        else
                            Console.WriteLine("Address Book Not Found!");
                        break;

                    


                    case 8:
                        return;

                    default:
                        Console.WriteLine("Invalid Option!");
                        break;
                }
            }
        }
    }
}

