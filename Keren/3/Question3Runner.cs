using Keren._1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keren._3
{
    internal class Question3Runner
    {
        public void Run()
        {
            User user = new User("Keren", "1234", 23, new SendViaWeb());
            Printer<User> userPrinter = new Printer<User>();
            userPrinter.Print(user);
        }
    }
}
