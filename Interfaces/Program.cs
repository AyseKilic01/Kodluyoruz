using Interfaces.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            SmsLogger smsLogger = new SmsLogger();
            smsLogger.MessageLogs();
            string color = "Mavi";
            Focus focus = new Focus();
            focus.colorCar(color);
            Console.WriteLine(" "  + focus.wheelCount()); 
            Console.ReadLine();
        }
    }

    class SmsLogger : ILogger
    {
        public void MessageLogs()
        {
            Console.WriteLine("Sms kaydedildi.");
        }
    }
    class DatabaseLogger : ILogger
    {
        public void MessageLogs()
        {
            Console.WriteLine("Database e kaydedildi.");
        }
    }
}
