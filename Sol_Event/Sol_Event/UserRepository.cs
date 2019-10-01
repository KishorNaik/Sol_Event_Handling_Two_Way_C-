using System;
using System.Collections.Generic;
using System.Text;

namespace Sol_Event
{
    public class UserRepository
    {
        public event Action<Object, UserModel, Action<UserModel>> onMailSend;

        public void Add(UserModel userModel)
        {
            Console.WriteLine("Database Code");

            onMailSend?.Invoke(this, userModel, (leUserModel) =>
            {
                if (leUserModel.IsEmailDone)
                {
                    Console.WriteLine("Generate log in Database");
                }
            });
        }
    }
}