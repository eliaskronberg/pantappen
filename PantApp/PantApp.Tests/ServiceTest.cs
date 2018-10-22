using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PantApp.Services;
using PantApp.Repository;

namespace PantApp.Tests
{
    [TestClass]
    public class ServiceTest
    {

        [TestMethod]
        public void CreateUser()
        {
            var name = "Elias";

            var service = new UserDataService();

            var newUser = service.CreateUser(name);

            Assert.AreEqual(newUser.Name, "Elias");
            
        }
        [TestMethod]
        public void TestUserIdIncrement()
        {
            var service = new UserDataService();

            service.CreateUser("user1");
            service.CreateUser("user2");

            Assert.AreEqual(UserRepository.Users.Last().Id, 2);
        }

        [TestMethod]
        public void TestUpdateUser()
        {
            var service = new UserDataService();

            var user = service.CreateUser("user1");

            service.UpdateUserData(user.Id, 2);
            service.UpdateUserData(user.Id, 1);

            Assert.AreEqual(service.GetUserData(user.Name).Balance, 3);
            Assert.AreEqual(service.GetUserData(user.Name).RecycledCans, 2);


        }
    }
}
