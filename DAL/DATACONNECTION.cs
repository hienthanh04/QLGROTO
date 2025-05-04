using System.Data.SqlClient;

namespace DAL
{
    public class DATACONNECTION
    {
        string constr;
        public DATACONNECTION()
        {
            constr = "Data Source = ZenBookUX425EA\SQLEXPRESS; Intial Catalog = QUANLIGARA; Intergrated Security = true";
        }
        public SqlConnection getConnect()
        {
             return new SqlConnection(constr);
        }
    }
}