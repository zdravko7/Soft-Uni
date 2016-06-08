using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PhoneBook
{
    class PhoneBook
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(new char[] {'-'});

                if (input[0] == "search")
                    break;

                string name = input[0];
                string phone = input[1];

                phonebook.Add(name, phone);
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (phonebook.ContainsKey(input))
                {
                    Console.WriteLine("{0} -> {1}", input, phonebook[input]);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Contact {0} does not exist", input);
                    Console.WriteLine();
                }

                if (input == "END")
                    break;





            }
        }
    }
}
