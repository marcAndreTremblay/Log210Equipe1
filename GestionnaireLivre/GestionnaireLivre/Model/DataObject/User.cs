using MySql.Data.MySqlClient;

namespace GestionnaireLivre.Model.DataObject
{
    public struct  User
    {
        public int Id;
        public string Name;
        public string Phone;
        public string Username;
        public string EmailAdress;
        public string UserTypeName;
        public int UserTypeID;
        public int CoopRefID;

        public User(MySqlDataReader dataReader)
        {
            Id = (int)dataReader.GetValue(0);
            Name = dataReader.GetValue(1).ToString();
            Phone = dataReader.GetValue(2).ToString();
            Username = dataReader.GetValue(3).ToString();
            EmailAdress = dataReader.GetValue(4).ToString();
            UserTypeName = dataReader.GetValue(5).ToString();
            UserTypeID = (int)dataReader.GetValue(6);
            CoopRefID = (int)dataReader.GetValue(7);
        }
    }


    public struct NewUser
    {
        public string Name;
        public string Phone;
        public string Password;
        public string Username;
        public string EmailAdress;
        public int UserTypeID;
        public int CoopRefID;
    }

}
