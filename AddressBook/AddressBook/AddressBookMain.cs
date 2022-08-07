﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBookMain
    {
        List<Contact> addressBook = new List<Contact>();
        Contact contact = new Contact();
        public AddressBookMain()
        {
            Contact contact1 = new Contact()
            {
                ID = "101",
                FirstName = "megha",
                LastName = "nelogal",
                Address = "basaveshwar nagar",
                Email = "meghapn@gmail.com",
                PhoneNumber = "6360139273",
                City = "banglore",
                State = "karnataka",
                ZipCode = "521104"
            };
            Contact contact2 = new Contact()
            {
                ID = "102",
                FirstName = "savita",
                LastName = "Patil",
                Address = "rajaji nagar",
                Email = "savitapn@gmail.com",
                PhoneNumber = "9008088513",
                City = "dharwad",
                State = "karnataka",
                ZipCode = "667788"
            };
            addressBook.Add(contact1);
            addressBook.Add(contact2);
        }
        public void CreateContact()
        {
            Console.WriteLine("Enter Your ID: ");
            contact.ID = Console.ReadLine();
            Console.WriteLine("Enter Your First: ");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Your Last Name: ");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("Enter Your Address: ");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter Your Email Id: ");
            contact.Email = Console.ReadLine();
            Console.WriteLine("Enter Your PhoneNumber: ");
            contact.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Your City: ");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter Your State: ");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter Your Zip Code: ");
            contact.ZipCode = Console.ReadLine();
            addressBook.Add(contact);
        }
        public void Display()
        {
            foreach (var contact in addressBook)
            {
                Console.WriteLine(contact.ID + "\n" + contact.FirstName + "\n" + contact.LastName + "\n" + contact.Address + "\n" + contact.Email + "\n" + contact.PhoneNumber + "\n" + contact.City + "\n" + contact
                    .State + "\n" + contact.ZipCode);
                Console.WriteLine("\n");
            }
        }
        public void EditContact()
        {
            Console.WriteLine("Edit a contact list enter firstName");
            string FirstName = Console.ReadLine();
            foreach (var contact in addressBook)
            {
                if (contact.FirstName.Equals(FirstName))
                {
                    Console.WriteLine("Edit a Contact\n1.FirstName\n2.LastName\n3.Address\n4.Email\n5.PhoneNumber\n6.City\n7.State\n8.ZipCode\n");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            string firstName = Console.ReadLine();
                            contact.FirstName = firstName;
                            break;
                        case 2:
                            string lastName = Console.ReadLine();
                            contact.LastName = lastName;
                            break;
                        case 3:
                            string address = Console.ReadLine();
                            contact.Address = address;
                            break;
                        case 4:
                            string email = Console.ReadLine();
                            contact.Email = email;
                            break;
                        case 5:
                            string phoneNumber = Console.ReadLine();
                            contact.PhoneNumber = phoneNumber;
                            break;
                        case 6:
                            string city = Console.ReadLine();
                            contact.City = city;
                            break;
                        case 7:
                            string state = Console.ReadLine();
                            contact.State = state;
                            break;
                        case 8:
                            string zipCode = Console.ReadLine();
                            contact.ZipCode = zipCode;
                            break;
                        default:
                            Console.WriteLine("Enter Correct option");
                            break;
                    }
                }

            }
            Console.WriteLine("\nEdit Successfully\n");
            Display();
        }
        public void DeleteContact()
        {
            Contact delete = new Contact();
            Console.WriteLine("To Delet Contact List Enter FirstName");
            string FirstName = Console.ReadLine();
            foreach (var contact in addressBook)
            {

                if (contact.FirstName.Equals(FirstName))
                {
                    delete = contact;
                }
            }
            addressBook.Remove(delete);
            Console.WriteLine("\nContact Deleted SuccessFully\n");
            Display();
        }
    }
}
    

