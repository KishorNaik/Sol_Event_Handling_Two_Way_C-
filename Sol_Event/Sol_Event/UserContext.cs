using System;
using System.Collections.Generic;
using System.Text;

namespace Sol_Event
{
    public class UserContext
    {
        private readonly UserRepository userRepository = null;

        public UserContext(UserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public void Add(UserModel userModel)
        {
            Action<Object, UserModel, Action<UserModel>> eventHandler = (leSender, leUserModel, leNotify) =>
              {
                  Console.WriteLine("Send Mail");

                  leUserModel.IsEmailDone = true;

                  leNotify(leUserModel);
              };

            this.userRepository.onMailSend += eventHandler;

            this.userRepository.Add(userModel);

            this.userRepository.onMailSend -= eventHandler;
        }
    }
}