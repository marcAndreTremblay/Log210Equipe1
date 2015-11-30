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
        public int PageCpt;
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
        public string coopName;
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
            PageCpt = (int)dataReader.GetValue(9);
            price = (double)dataReader.GetValue(10);

            
            NewUserId = -1;
            if (dataReader.IsDBNull(11) != true)
            {
                NewUserId = (int)dataReader.GetValue(11);
            }
            IsTransactionDone = (bool)dataReader.GetValue(12);
            timeCreated = (DateTime)dataReader.GetValue(13);

            FK_bookcondition = (int)dataReader.GetValue(14);
            FK_transactionType = (int)dataReader.GetValue(15);
            FK_transactionStatus = (int)dataReader.GetValue(16);
            FK_coop_ref = (int)dataReader.GetValue(17);

             transactionTypeName = dataReader.GetValue(19).ToString();
             bookconditionDescription = dataReader.GetValue(20).ToString();
             transactionStatusName = dataReader.GetValue(21).ToString();
            coopName = dataReader.GetValue(22).ToString();
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
        public int PageCpt;
        public double price;

        public int FK_bookcondition;
        public int FK_transactionType;
        public int FK_coop_ref;
    }
}
