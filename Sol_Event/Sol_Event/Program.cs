using System;

namespace Sol_Event
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var userContext = new UserContext(new UserRepository());
            userContext.Add(new UserModel()
            {
                FullName = "Kishor",
                EmailId = "Kishor.naik011.net@gmail.com"
            });
        }
    }
}