using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireLivre.Model.DataObject
{
    public struct Book
    {
        public int id;
        public string ISBN;
        public string Title;
        public string Author;
        public string Publishier;
        public string Language;
        public string Categorie;
        public int price;
        public int NewUserId;
        public bool IsTransactionDone;
        public TimeSpan timeCreated;
        public string bookcondition;
        public string bookstate;
    }

    public struct NewBook
    {
        public string ISBN;
        public string Title;
        public string Author;
        public string Publishier;
        public string Language;
        public string Categorie;
        public int price;

        public int FK_bookcondition;
        public int FK_transactionType;
        public int FK_coop_ref;
    }
}
