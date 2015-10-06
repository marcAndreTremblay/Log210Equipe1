using MySql.Data.MySqlClient;

namespace GestionnaireLivre.Model.DataObject
{
    public struct TransactionType
    {
        public int id;
        public string name;

        public TransactionType(MySqlDataReader dataReader)
        {
            id = (int)dataReader.GetValue(0);
            name = dataReader.GetValue(1).ToString();

        }

        public override string ToString()
        {
            return name;
        }
    }
}
