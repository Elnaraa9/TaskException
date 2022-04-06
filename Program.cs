using System;
using Task_Exception.Models;

namespace Task_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            EmailSender email = new EmailSender();
            SmsSender sms = new SmsSender();
            Console.WriteLine("1.Send message by Email\n2.Send message by SMS\n0.Quit");
            int message=Int32.Parse(Console.ReadLine());
            switch (message)
            {
                case 1:
                    email.SendMessage();
                    break;
                case 2:
                    sms.SendMessage();
                    break;
                case 3:
                    System.Environment.Exit(0);
                    break;
                default:
                    break;
            }           
        }
    }
}
