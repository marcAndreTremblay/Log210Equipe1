using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GestionnaireLivre.Model.DataObject;

namespace GLTest.Factory
{
    public static class DataObjectFctory
    {
        public static NewUser BuildNewUserClient()
        {
            NewUser newUser = new NewUser();
                newUser.EmailAdress = "test@test.com";
                newUser.Name = "testClientName";
                newUser.Phone = "4186936607";
                newUser.Password = "test3";
                newUser.Username = "test3";
                newUser.UserTypeID = 1;
                newUser.CoopRefID = -1;
            return newUser;
        }
        public static NewUser BuildNewUserAdmin()
        {
            NewUser newUser = new NewUser();
            newUser.EmailAdress = "test@test.com";
            newUser.Name = "testAdminName";
            newUser.Phone = "4186936607";
            newUser.Password = "test3";
            newUser.Username = "test3";
            newUser.UserTypeID = 2;
            newUser.CoopRefID = 1;
            return newUser;
        }
    }
}
