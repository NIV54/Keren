using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keren._1
{
    internal class Question1Runner
    {
        private List<User> createUsers()
        {
            List<User> users = new List<User>();
            users.Add(new User("Keren", "1234", 23, new SendViaWeb()));
            users.Add(new User("Niv", "1234", 23, new SendViaBranch()));

            return users;
        }

        private void sendMails(List<User> users)
        {
            users.ForEach(user => user.SendMail("Kaplan"));
        }

        public void Run()
        {
            List<User> users = this.createUsers();
            this.sendMails(users);
        }
    }
}
