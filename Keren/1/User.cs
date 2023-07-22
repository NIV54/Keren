using Keren._3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keren._1
{
    internal class User : IPrintable
    {
        private string UserName { get; set; }
        private string Password { get; set; }
        private int Age { get; set; }
        private ISendMail SendMailStrategy { get; set; }

        public User(string username, string password, int age, ISendMail sendMailStrategy)
        {
            this.UserName = username;
            this.Password = password;
            this.Age = age;
            this.SendMailStrategy = sendMailStrategy;
        }

        public void SendMail(string address)
        {
            Console.WriteLine(this.UserName);
            try
            {
                this.SendMailStrategy.SendMail(address);    
            }
            catch (Exception e)
            {
                Console.WriteLine("Error sending to: " + address);
            }
        }
        
        public string getPrint()
        {
            return this.UserName + " " + this.Password; 
        }
    } 

}
