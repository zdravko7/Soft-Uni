using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chat_Logger
{
    class ChatLogger
    {
        static void Main(string[] args)
        {
            //Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("bg - BG");
            CultureInfo bg = new CultureInfo("de-CH");
            Thread.CurrentThread.CurrentCulture = bg;
            //Thread.CurrentThread.CurrentCulture = c"bg-BG";

            DateTime currentTime = DateTime.Parse(Console.ReadLine());
            SortedDictionary<DateTime, string> chat = new SortedDictionary<DateTime, string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                    break;

                string[] splitInput = input.Split(new string[] {" / "}, StringSplitOptions.RemoveEmptyEntries);

                DateTime dateOfChat = DateTime.Parse(splitInput[splitInput.Length-1]);

                chat[dateOfChat] = splitInput[0];

                
            }
            string lastActive = LastActive(currentTime, chat.Keys.Last());
            foreach (var item in chat)
            {
                Console.WriteLine(@"<div>{0}</div>", item.Value);
            }
            Console.WriteLine("<p>Last active: <time>{0}</time></p>", lastActive);
        }

        public static string LastActive(DateTime now, DateTime lastMessage)
        {
            TimeSpan difference = now - lastMessage;

            if (difference.Days >= 1)
            {
                return lastMessage.ToString("dd-MM-yyyy");
            }
            else if (now.Day != lastMessage.Day)
            {
                return "yesterday";
            }
            else if (difference.Hours >= 1)
            {
                return difference.Hours + " hour(s) ago";
            }
            else if (difference.Minutes >= 1)
            {
                return difference.Minutes + " minute(s) ago";
            }
            else
            {
                return "a few moments ago";
            }
        }
    }
}
