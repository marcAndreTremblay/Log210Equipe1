using MySql.Data.MySqlClient;

namespace GestionnaireLivre.Model.DataObject
{
    public struct BookCondition
    {
        public int id;
        public string description;
        public int reduction;

        public BookCondition(MySqlDataReader dataReader)
        {
            id = (int)dataReader.GetValue(0);
            description = dataReader.GetValue(1).ToString();
            reduction = (int)dataReader.GetValue(2);
        }

        public override string ToString()
        {
            return description;
        }
    }
}
