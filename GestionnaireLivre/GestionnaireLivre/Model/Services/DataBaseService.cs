using System;
using System.Linq;

using System.Diagnostics;
using System.Data;
using System.Collections.Generic;

using MySql.Data.MySqlClient;
using GestionnaireLivre.Model.DataObject;
using GestionnaireLivre.Model;

namespace GestionnaireLivre.Model.Services
{
    
    public class DataBaseService
    {

        //Note(Marc) : Maybe Only keep the connection string and create a connection evetry time? So we avoid the multiple connection problems?
        private MySqlConnection connection;
        private string server = "localhost";
        private string database = "gestionnairebd";
        private string uid= "root";
        private string password= "root";

        //Note(Marc) : Don't thing its a good idea to store tha here (Maybe in a serviceManager ?)
        public int loginID = -1;

        public List<BookCondition> BookCondition
        {
            get
            {
                return GetBookCondition();
            }
        }
        public List<TransactionType> BookTransactionType
        {
            get
            {
                return GetTransactionType();
            }
        }
        public List<TransactionStatus> BookTransactionStatus
        {
            get
            {
                return GetTransactionStatus();
            }
        }
        public List<UserType> UserType
        {
            get
            {
                return GetUserType();
            }
        }

        public DataBaseService()
        {
            connection = new MySqlConnection("SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";");
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        Debug.WriteLine("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        Debug.WriteLine("Cannot connect to server.  Contact administrator");
                        break;
                }
                return false;
            }
        }
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

        public bool TestConnection()
        {
            try
            {
              OpenConnection();
              CloseConnection();
            }catch(Exception e)
            {
                return false;
            }
            return true;
        }

        public int CheckLogInCredentials(string username, string password)
        {
            password = Crypting.GetSHA512Hash(password); //Encrypte the password

            MySqlCommand cmd = new MySqlCommand("ValidateUserCrendentials", connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
           
            cmd.Parameters.Add(new MySqlParameter("userPassword", password));
            cmd.Parameters.Add(new MySqlParameter("username", username));

            connection.Open();
            int id = -1;
            object obj = cmd.ExecuteScalar();
            if(obj != null)
            {
                string dataString = obj.ToString();
                bool result = Int32.TryParse(dataString, out id);

            }    
            connection.Close();

            return id;
        }


        private  List<BookCondition> GetBookCondition()
        {
            OpenConnection();

            List<BookCondition> bookCondition = new List<BookCondition>();

            MySqlCommand cmd = new MySqlCommand("GetBookCondition", connection);
            cmd.CommandType = CommandType.StoredProcedure;


            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                bookCondition.Add(new BookCondition(rdr));
            }

            CloseConnection();

            return bookCondition;
        }
        private List<TransactionType> GetTransactionType()
        {
            OpenConnection();

            List<TransactionType> bookTransactionType = new List<TransactionType>();

            MySqlCommand cmd = new MySqlCommand("GetTransactionType", connection);
            cmd.CommandType = CommandType.StoredProcedure;


            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                bookTransactionType.Add(new TransactionType(rdr));
            }

            CloseConnection();

            return bookTransactionType;
        }
        private List<TransactionStatus> GetTransactionStatus()
        {
            OpenConnection();

            List<TransactionStatus> bookTransactionStatus = new List<TransactionStatus>();

            MySqlCommand cmd = new MySqlCommand("GetTransactionStatus", connection);
            cmd.CommandType = CommandType.StoredProcedure;


            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                bookTransactionStatus.Add(new TransactionStatus(rdr));
            }

            CloseConnection();

            return bookTransactionStatus;
        }
        private List<UserType> GetUserType()
        {
            OpenConnection();

            List<UserType> userType = new List<UserType>();

            MySqlCommand cmd = new MySqlCommand("GetUserType", connection);
            cmd.CommandType = CommandType.StoredProcedure;


            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                userType.Add(new UserType(rdr));
            }

            CloseConnection();

            return userType;
        }


        public List<Cooperative> RetrieveCooperatives()
        {
            OpenConnection();

            List<Cooperative> cooperatives = new List<Cooperative>();

            MySqlCommand cmd = new MySqlCommand("RetrieveCooperatives", connection);
            cmd.CommandType = CommandType.StoredProcedure;


            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                cooperatives.Add(new Cooperative(rdr));
            }

            CloseConnection();

            return cooperatives;
        }
        public Cooperative RetrieveSpecificCooperatives(int coop_id)
        {
            OpenConnection();

            MySqlCommand cmd = new MySqlCommand("RetrieveSpecificCooperative", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("coop_id", coop_id));

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dataReader.Read();
            Cooperative coop;
            if (dataReader.HasRows == true)
            {
                coop = new Cooperative(dataReader);
            }
            else
            {
                coop = new Cooperative();
                coop.id = -1;
            }

            CloseConnection();

            return coop;
        }
       
        //somechange
        
        /// <summary>
        /// Retrive all the informations 
        /// </summary>
        /// <param name="userId"></param>
        /// <returns>If no user have this id the returned user will have a id of -1</returns>
        public User RetrieveSpecificUser(int userId)
        {
            OpenConnection();

            MySqlCommand cmd = new MySqlCommand("RetrieveSpecificUser", connection);
            
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("client_id", userId));

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dataReader.Read();
            User newUser;
           if( dataReader.HasRows == true)
           {
                newUser = new User(dataReader);
            }
           else
           {
               newUser = new User();
               newUser.Id = -1;
           }
            
            CloseConnection();
            

            return newUser;
        }
        public List<Book> RetriveBookBySellerId(int sellerId)
        {
            OpenConnection();

            List<Book> bookList = new List<Book>();

            MySqlCommand cmd = new MySqlCommand("RetrieveBooksBySellerId", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new MySqlParameter("client_id", sellerId));

            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                bookList.Add(new Book(rdr));
            }

            CloseConnection();

            return bookList;
        }


        public bool RegisterUser(NewUser newUser)
        {

            newUser.Password = Crypting.GetSHA512Hash(newUser.Password);

          
            MySqlCommand cmd = new MySqlCommand("RegisterUser", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new MySqlParameter("name", newUser.Name));
                cmd.Parameters.Add(new MySqlParameter("phone", newUser.Phone));
                cmd.Parameters.Add(new MySqlParameter("username", newUser.Username));
                cmd.Parameters.Add(new MySqlParameter("password", newUser.Password));
                cmd.Parameters.Add(new MySqlParameter("email", newUser.EmailAdress));
                cmd.Parameters.Add(new MySqlParameter("fk_usertypeid", newUser.UserTypeID));
                cmd.Parameters.Add(new MySqlParameter("fk_coop_ref", newUser.CoopRefID));

                int i = -1;
                try
                {
                    cmd.Connection.Open();
                     i= cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                }
                catch(Exception e)
                {
                    return false;
                }
           

            if (i == 1) return true;
            return false;
        }
        public bool RegisterAdminWithCoop(NewUser newUser, NewCooperative newCoop)
        {

            newUser.Password = Crypting.GetSHA512Hash(newUser.Password);

            MySqlCommand cmd = new MySqlCommand("RegisterAdminWithCoop", connection);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("name", newUser.Name));
            cmd.Parameters.Add(new MySqlParameter("phone", newUser.Phone));
            cmd.Parameters.Add(new MySqlParameter("username", newUser.Username));
            cmd.Parameters.Add(new MySqlParameter("password", newUser.Password));
            cmd.Parameters.Add(new MySqlParameter("email", newUser.EmailAdress));
            cmd.Parameters.Add(new MySqlParameter("fk_usertypeid", newUser.UserTypeID));
            cmd.Parameters.Add(new MySqlParameter("coopName", newCoop.Name));
            cmd.Parameters.Add(new MySqlParameter("coopAdress", newCoop.Adress));
            cmd.Parameters.Add(new MySqlParameter("coopContactInfo", newCoop.ContactInformation));

            cmd.Connection.Open();
            int i = cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            if (i == 1) return true;
            return false;
        }
        public bool RegisterBook(NewBook newBook)
        {

            MySqlCommand cmd = new MySqlCommand("RegisterNewBook", connection);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new MySqlParameter("bookSellerId", loginID));
                cmd.Parameters.Add(new MySqlParameter("isbn", newBook.ISBN));
                cmd.Parameters.Add(new MySqlParameter("eancode", newBook.EANcode));
                cmd.Parameters.Add(new MySqlParameter("upccode", newBook.UPCcode));
                cmd.Parameters.Add(new MySqlParameter("title", newBook.Title));
                cmd.Parameters.Add(new MySqlParameter("author", newBook.Author));
                cmd.Parameters.Add(new MySqlParameter("publishier", newBook.Publishier));
                cmd.Parameters.Add(new MySqlParameter("blanguage", newBook.Language));
                cmd.Parameters.Add(new MySqlParameter("categorie", newBook.Categorie));
                cmd.Parameters.Add(new MySqlParameter("price", newBook.price));
                cmd.Parameters.Add(new MySqlParameter("fk_bootcondition", newBook.FK_bookcondition));
                cmd.Parameters.Add(new MySqlParameter("fk_transactionType", newBook.FK_transactionType));
                cmd.Parameters.Add(new MySqlParameter("fk_cooperativeid", newBook.FK_coop_ref));
                cmd.Connection.Open();
            int i = cmd.ExecuteNonQuery();
            cmd.Connection.Close();


            if (i == 1) return true;
            return false;
        }
    }
}
