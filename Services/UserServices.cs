using System;
using AuthMicroservice.Models;


namespace AuthMicroservice.Services {
    public class UserServices {

        public string EncryptPassword (string Password) {

            return Password;
        }


        public bool RegisterUser(UserDto userDto) {

            User NewUser = new User();

            NewUser.FirstName = userDto.FirstName;
            NewUser.LastName = userDto.LastName;
            NewUser.Email = userDto.Email;
            NewUser.EncryptedPassword = EncryptPassword(userDto.Password);
            NewUser.Status = UserStatus.Pending;

            Console.WriteLine(userDto);
            return true;
        }


    }
}