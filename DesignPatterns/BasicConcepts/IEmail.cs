using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BasicConcepts
{
    interface IEmail
    {
        void sendEmail();
    }

    class OutlookEmail: IEmail
    {
        public void sendEmail()
        {
            Console.WriteLine("send outlook email");
        }
    }

    class WebserviceEmail : IEmail
    {
        public void sendEmail()
        {
            Console.WriteLine("send webservice email");
        }
    }

}
