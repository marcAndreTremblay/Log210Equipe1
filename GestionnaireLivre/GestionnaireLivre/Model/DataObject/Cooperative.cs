using MySql.Data.MySqlClient;

namespace GestionnaireLivre.Model.DataObject
{
    public struct Cooperative
    {
        public int id;
        public string Name;
        public string Adress;
        public string ContactInformation;


        public Cooperative(MySqlDataReader dataReader)
        {
            id = (int)dataReader.GetValue(0);
            Name = dataReader.GetValue(1).ToString();
            Adress = dataReader.GetValue(2).ToString();
            ContactInformation = dataReader.GetValue(3).ToString();
        }


        public override string ToString()
        {
            return Name + " (" + Adress+")";
        }
    }

    public struct NewCooperative
    {
        public string Name;
        public string Adress;
        public string ContactInformation;

    }
}
