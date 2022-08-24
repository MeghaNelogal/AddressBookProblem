﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBook
    {
        List<Contact> addressBook = new List<Contact>();
        Dictionary<string, List<Contact>> dictionaryName = new Dictionary<string, List<Contact>>();
        public AddressBook()
        {
            Contact address1 = new Contact()
            {
                FirstName = "megha",
                LastName = "nelogal",
                Address = "Gomatinagar",
                City = "Luck",
                State = "UP",
                EmailAddress = "megha123@gmail.com",
                PostalCode = 226026,
                MobileNumber = 9721954611
            };
            Contact address2 = new Contact()
            {
                FirstName = "savita",
                LastName = "patil",
                Address = "Haryana",
                City = "Luck",
                State = "Delhi",
                EmailAddress = "savita123@gmail.com",
                PostalCode = 400009,
                MobileNumber = 9722945611
            };
            //Console.WriteLine("Enter the FirstName LastName Address City State Email postalCode mobile Number");
            //Contact address3 = new Contact()
            //{
            //    FirstName = Console.ReadLine(),
            //    LastName = Console.ReadLine(),
            //    Address = Console.ReadLine(),
            //    City = Console.ReadLine(),
            //    State = Console.ReadLine(),
            //    EmailAddress = Console.ReadLine(),
            //    PostalCode = Convert.ToInt32(Console.ReadLine()),
            //    MobileNumber = Convert.ToInt64(Console.ReadLine())
            //};           
            addressBook.Add(address1);
            addressBook.Add(address2);
            // addressBook.Add(address3);
        }
        //public void AddContactToAddressBook(Contact contact)
        //{
        //    addressBook.Add(contact);
        //}
        public void Display()
        {
            foreach (var contact in addressBook)
            {
                Console.WriteLine(contact.FirstName + " " + contact.LastName + " " + contact.Address + " " + contact.City + " " + contact.State + " " + contact.EmailAddress + " " + " " + contact.PostalCode + " " + contact.MobileNumber);
            }
        }
        public void EditContactInAddressBook(string name)
        {
            foreach (var contact in addressBook)
            {
                if (contact.FirstName.Equals(name))
                {
                    Console.WriteLine("Enter the Option To Update");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter the FirstName to Update");
                            contact.FirstName = Console.ReadLine(); break;
                        case 2:
                            Console.WriteLine("Enter the LastName to Update");
                            contact.LastName = Console.ReadLine(); break;
                        case 3:
                            Console.WriteLine("Enter the Address to Update");
                            contact.Address = Console.ReadLine(); break;
                        case 4:
                            Console.WriteLine("Enter the City to Update");
                            contact.City = Console.ReadLine(); break;
                        case 5:
                            Console.WriteLine("Enter the State to Update");
                            contact.State = Console.ReadLine(); break;
                        case 6:
                            Console.WriteLine("Enter the Email to Update");
                            contact.EmailAddress = Console.ReadLine(); break;
                        case 7:
                            Console.WriteLine("Enter the Postal to Update");
                            contact.PostalCode = Convert.ToInt32(Console.ReadLine()); break;
                        case 8:
                            Console.WriteLine("Enter the MobileNumber to Update");
                            contact.MobileNumber = Convert.ToInt64(Console.ReadLine()); break;
                    }
                }
                Display();
            }
        }
        public void DeletingContactINAddressBook(string name)
        {
            Contact delete = new Contact();
            foreach (var contact in addressBook)
            {
                if (contact.FirstName.Equals(name))
                {
                    delete = contact;
                }
            }
            addressBook.Remove(delete);
            Display();
        }
        public void AddDictionary(string name)
        {
            if (dictionaryName == null)
            {
                dictionaryName.Add(name, addressBook);
            }
            if (NameExists(name) == false)
            {
                dictionaryName.Add(name, addressBook);
            }

        }
        public void EditingDictionary(string name, string contactName)
        {
            foreach (var data in dictionaryName)
            {
                if (dictionaryName.Keys.Equals(name))
                {
                    addressBook = data.Value;
                    EditContactInAddressBook(contactName);
                }
            }
        }
        public void DeleteDictionaryData(string name)
        {
            foreach (var data in dictionaryName)
            {
                if (data.Key.Equals(name))
                {
                    addressBook = data.Value;
                    DeletingContactINAddressBook(name);
                }
            }
            dictionaryName.Remove(name);
        }
        public bool NameExists(string name)
        {
            foreach (var data in dictionaryName.Keys)
            {
                if (data.Equals(name))
                {
                    return true;
                }
            }
            return false;
        }
        public void SearchingPersonInCity(string cityName)
        {
            foreach (var contact in addressBook)
            {
                if (contact.City.Equals(cityName))
                {
                    Console.WriteLine(contact.FirstName + " " + contact.LastName + " " + contact.Address + " " + contact.City + " " + contact.State + " " + contact.EmailAddress + " " + " " + contact.PostalCode + " " + contact.MobileNumber);
                }

            }
        }
    }
}
