using System.Linq;
using PantApp.Models;
using PantApp.Repository;

namespace PantApp.Services
{
    public class UserDataService
    {
        public UserModel GetUserData(string name)
        {
            if(UserRepository.Users.FirstOrDefault(x => x.Name == name) == null)
            {
                return CreateUser(name);
            }

            return UserRepository.Users.FirstOrDefault(x => x.Name == name);
        }
        public UserModel UpdateUserData(int id, int canValue)
        {
            UserRepository.Users[id - 1].RecycledCans++;
            UserRepository.Users[id - 1].Balance += canValue;

            return UserRepository.Users[id - 1];
        }
        public UserModel CreateUser(string name)
        {
            UserRepository.Users.Add(new UserModel(name));
            return UserRepository.Users.Last();
        }
    }
}