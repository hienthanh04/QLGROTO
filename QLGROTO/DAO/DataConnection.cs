using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGROTO.DAO
{
    internal class DataConnection
    {
        string constr = "Data Source=DESKTOP-68MTOFF\\SQLEXPRESS;Initial Catalog=QUANLIGARA;Integrated Security=True";
        public SqlConnection getConnect()
        {
            return new SqlConnection(constr);
        }
    }
    
}
