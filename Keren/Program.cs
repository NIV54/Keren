using Keren._1;
using Keren._3;

namespace Keren
{
    public class Program
    {

        public static void Main(String[] args)
        {
            // question 4, regarding exception handling, is baked into User.cs
            Question1Runner quetion1Runner = new Question1Runner();
            quetion1Runner.Run();
            Question3Runner quetion3Runner = new Question3Runner();
            quetion3Runner.Run();
        }
    }
}