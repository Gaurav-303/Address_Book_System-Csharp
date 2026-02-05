using System;
using System.Collections.Generic;

namespace Address_Book_System
{
    internal class AddressBookMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program!");

            Dictionary<string, AddressBookService> addressBooks =
                new Dictionary<string, AddressBookService>(StringComparer.OrdinalIgnoreCase);

            while (true)
            {
                Console.WriteLine("\n1. Create New Address Book");
                Console.WriteLine("2. Add Contact");
                Console.WriteLine("3. Edit Contact");
                Console.WriteLine("4. Delete Contact");
                Console.WriteLine("5. Show Contacts");
                Console.WriteLine("6. Add Contacts (Multithreading)");
                Console.WriteLine("7. Edit Contacts (Multithreading)");
                Console.WriteLine("8. Exit");
                Console.Write("Enter Choice: ");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                try
                {
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter Address Book Name: ");
                            string bookName = Console.ReadLine();

                            if (addressBooks.ContainsKey(bookName))
                                throw new DuplicateAddressBookException(
                                    $"Address Book '{bookName}' already exists");

                            addressBooks.Add(bookName, new AddressBookService());
                            Console.WriteLine("New Address Book Created!");
                            break;

                        case 2:
                            ExecuteIfBookExists(addressBooks,
                                ab => ab.AddContact());
                            break;

                        case 3:
                            ExecuteIfBookExists(addressBooks,
                                ab =>
                                {
                                    Console.Write("Enter First Name to Edit: ");
                                    ab.EditContact(Console.ReadLine());
                                });
                            break;

                        case 4:
                            ExecuteIfBookExists(addressBooks,
                                ab =>
                                {
                                    Console.Write("Enter First Name to Delete: ");
                                    ab.DeleteContact(Console.ReadLine());
                                });
                            break;

                        case 5:
                            ExecuteIfBookExists(addressBooks,
                                ab => ab.DisplayContacts());
                            break;

                        case 6:
                            ExecuteIfBookExists(addressBooks,
                                ab => ab.AddContactsUsingMultithreading());
                            break;

                        case 7:
                            ExecuteIfBookExists(addressBooks,
                                ab =>
                                {
                                    Console.Write("Enter First Name 1: ");
                                    string n1 = Console.ReadLine();
                                    Console.Write("Enter First Name 2: ");
                                    string n2 = Console.ReadLine();
                                    ab.EditContactsUsingMultithreading(n1, n2);
                                });
                            break;

                        case 8:
                            return;

                        default:
                            Console.WriteLine("Invalid Option!");
                            break;
                    }
                }
                catch (DuplicateAddressBookException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ResetColor();
                }
            }
        }

      
        private static void ExecuteIfBookExists(
            Dictionary<string, AddressBookService> addressBooks,
            Action<AddressBookService> action)
        {
            Console.Write("Enter Address Book Name: ");
            string name = Console.ReadLine();

            if (addressBooks.ContainsKey(name))
                action(addressBooks[name]);
            else
                Console.WriteLine("Address Book Not Found!");
        }
    }
}
