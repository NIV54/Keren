using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keren._1
{
    internal class SendViaBranch : ISendMail
    {
        public void SendMail(string address)
        {
            if (address == "Kaplan")
            {
                throw new ArgumentException("Cannot send to Kaplan");
            }
            Console.WriteLine("branch: " + address);
        }
    }
}
