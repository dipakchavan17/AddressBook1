using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBookImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to address book");
            CreateAddressBook createAddressBook = new CreateAddressBook();
            createAddressBook.ReadInput();
            Console.ReadLine();
        }
    }
}
