using Microsoft.Data.SqlClient;

namespace Test.Classes
{
    public class TestClass
    {

    
        public void DotThis(string id, string culture)
        {

            using (var sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = "SELECT * FROM TABLE WHERE ANSWER = " + id;
                sqlCommand.ExecuteNonQuery();
            }

        }
    }
}
