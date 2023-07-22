using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keren._1
{
    internal class SendViaWeb : ISendMail
    {
        public void SendMail(string address)
        {
            Console.WriteLine("web: " + address);
        }
    }
}
