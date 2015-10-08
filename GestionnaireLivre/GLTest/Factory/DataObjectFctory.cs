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
                newUser.Username = "testclient" + DateTime.Now.Millisecond.ToString();
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
            newUser.Username = "testadmin" + DateTime.Now.Millisecond.ToString();
            newUser.UserTypeID = 2;
            newUser.CoopRefID = 1;
            return newUser;
        }

        public static NewCooperative BuildNewCoop()
        {
            NewCooperative newCoop = new NewCooperative();
            newCoop.Adress = "123 Somewhere one earth";
            newCoop.ContactInformation = "1-418-124-1234";
            newCoop.Name = "Coop test super" + DateTime.Now.Millisecond.ToString(); 
            return newCoop;
        }

        public static NewBook BuildNewBook()
        {
            NewBook newbook = new NewBook();
            newbook.ISBN = "1234";
            newbook.Language = "en";
            newbook.price = 10.45;
            newbook.Title = "testTile" + DateTime.Now.Millisecond.ToString();
            newbook.Publishier = "Test publisher";
            newbook.Author = "test author";
            newbook.FK_bookcondition = 1;
            newbook.FK_coop_ref = 1;
            newbook.FK_transactionType = 1;
            newbook.UPCcode = "3123131";

            return newbook;
        }
    }
}
