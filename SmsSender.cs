using System;
using System.Collections.Generic;
using System.Text;

namespace Task_Exception.Models
{
    class SmsSender : MessageSender
    {
        public override void SendMessage()
        {
            Console.WriteLine("Send message by sms");
        }
    }
}
