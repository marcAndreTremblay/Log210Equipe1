using System;
using System.Text;

using MySql.Data.MySqlClient;

namespace GestionnaireLivre.Model.DataObject
{
    public struct Book
    {
        public int id;
        public string ISBN;
        public string EANcode;
        public string UPCcode;
        public string Title;
        public string Author;
        public string Publishier;
        public string Language;
        public string Categorie;
        public double price;
        public int NewUserId;
        public bool IsTransactionDone;
        public DateTime timeCreated;
     
        public int FK_bookcondition;
        public int FK_transactionType;
        public int FK_transactionStatus;
        public int FK_coop_ref;

        public string bookconditionDescription;
        public string transactionTypeName;
        public string transactionStatusName;

        public Book(MySqlDataReader dataReader)
        {
            id = (int)dataReader.GetValue(0);
            ISBN = dataReader.GetValue(1).ToString();
            EANcode = dataReader.GetValue(2).ToString();
            UPCcode = dataReader.GetValue(3).ToString();
            Title = dataReader.GetValue(4).ToString();
            Author = dataReader.GetValue(5).ToString();
            Publishier = dataReader.GetValue(6).ToString();
            Language = dataReader.GetValue(7).ToString();
            Categorie = dataReader.GetValue(8).ToString();
            price = (double)dataReader.GetValue(9);

            
            NewUserId = -1;
            if (dataReader.IsDBNull(10) != true)
            {
                NewUserId = (int)dataReader.GetValue(10);
            }
            IsTransactionDone = (bool)dataReader.GetValue(11);
            timeCreated = (DateTime)dataReader.GetValue(12);

            FK_bookcondition = (int)dataReader.GetValue(13);
            FK_transactionType = (int)dataReader.GetValue(14);
            FK_transactionStatus = (int)dataReader.GetValue(15);
            FK_coop_ref = (int)dataReader.GetValue(16);

            bookconditionDescription = dataReader.GetValue(17).ToString();
            transactionTypeName = dataReader.GetValue(18).ToString();
            transactionStatusName = dataReader.GetValue(19).ToString();
        }
    }

    public struct NewBook
    {
        public string ISBN;
        public string EANcode;
        public string UPCcode;
        public string Title;
        public string Author;
        public string Publishier;
        public string Language;
        public string Categorie;
        public double price;

        public int FK_bookcondition;
        public int FK_transactionType;
        public int FK_coop_ref;
    }
}
