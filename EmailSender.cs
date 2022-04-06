using System;
using System.Collections.Generic;
using System.Text;

namespace Task_Exception.Models
{
    class EmailSender : MessageSender
    {
        public override void SendMessage()
        {
            Console.WriteLine("Send message by email");
        }
    }
}
