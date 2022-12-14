using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBook
    {
        Contact contacts = new Contact();
        List<Contact> addressBook = new List<Contact>();
        Dictionary<string, List<Contact>> dictionaryName = new Dictionary<string, List<Contact>>();
        Dictionary<string, string> cityPerson = new Dictionary<string, string>();
        List<string> firstName = new List<string>();
        List<string> cityState = new List<string>();
        const string EXPORT_JSON_FILE_PATH = @"D:\BridgelabzPracticeProblems\AddressBookProblem\AddressBookProblem\AddressBook\AddressBook\AddressBook.Json";
        const string FILE_PATH = @"D:\BridgelabzPracticeProblems\AddressBookProblem\AddressBookProblem\AddressBook\AddressBook\AddressBook.txt";
        const string IMPORT_CSV_FILE_PATH = @"D:\BridgelabzPracticeProblems\AddressBookProblem\AddressBookProblem\AddressBook\AddressBook\AddressBook.CSV";
        const string EXPORT_CSV_FILE_PATH = @"D:\BridgelabzPracticeProblems\AddressBookProblem\AddressBookProblem\AddressBook\AddressBook\AddressBookExport.CSV";
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
        public void MaintingDictionaryWithCityAndPerson(string cityName)
        {
            cityPerson.Add("Ajay", "Basti");
            cityPerson.Add("Vijay", "Basti");
            cityPerson.Add("Raj", "Lucknow");
            cityPerson.Add("Ritesh", "Allahabad");
            cityPerson.Add("Aman", "Basti");
            cityPerson.Add("Anuragh", "Banaras");
            foreach (var contact in cityPerson)
            {
                if (contact.Value.Equals(cityName))
                {
                    Console.WriteLine(contact.Key + " " + contact.Value);
                }
            }
        }
        public void GetPhoneNumberByCity(string cityName)
        {
            foreach (var contact in addressBook)
            {
                if (contact.City.Equals(cityName))
                {
                    Console.WriteLine("Mobile Number is" + contact.MobileNumber);
                }
            }
        }
        public void SortingByPersonName()
        {
            var result = this.addressBook.OrderBy(x => x.City).ToList();
            foreach (var contact in result)
            {
                Console.WriteLine(contact.FirstName + " " + contact.LastName + " " + contact.Address + " " + contact.City + " " + contact.State + " " + contact.EmailAddress + " " + " " + contact.PostalCode + " " + contact.MobileNumber);

            }
        }
        public void ReaderReadingFileUsingIO()
        {
            if (File.Exists(FILE_PATH))
            {
                StreamReader read = new StreamReader(FILE_PATH);
                try
                {
                    string s = "";
                    while ((s = read.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public void ReadingAndWritingDataFromTheCSVFile()
        {
            using (var reader = new StreamReader(IMPORT_CSV_FILE_PATH))
            {
                using (var Csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = Csv.GetRecords<Contact>().ToList();
                    foreach (var contact in records)
                    {
                        Console.WriteLine(contact.FirstName + " " + contact.LastName + " " + contact.Address + " " + contact.City + " " + contact.State + " " + contact.EmailAddress + " " + " " + contact.PostalCode + " " + contact.MobileNumber);
                    }
                    using (var writer = new StreamWriter(EXPORT_CSV_FILE_PATH))
                    {
                        using (var CsvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
                        {
                            CsvExport.WriteRecords(records);

                        }
                    }
                }
            }
        }
        public void ReadingDataFromCSVAndWritingDataIntoJSONFile()
        {
            using (var reader = new StreamReader(IMPORT_CSV_FILE_PATH))
            {
                using (var Csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = Csv.GetRecords<Contact>().ToList();
                    foreach (var contact in records)
                    {
                        Console.WriteLine(contact.FirstName + " " + contact.LastName + " " + contact.Address + " " + contact.City + " " + contact.State + " " + contact.EmailAddress + " " + " " + contact.PostalCode + " " + contact.MobileNumber);
                    }
                    JsonSerializer serializer = new JsonSerializer();
                    using (var writer = new StreamWriter(EXPORT_JSON_FILE_PATH))
                    {
                        using (var jsonWriter = new JsonTextWriter(writer))
                        {
                            serializer.Serialize(writer, records);

                        }
                    }
                }
            }
        }
    }
}



