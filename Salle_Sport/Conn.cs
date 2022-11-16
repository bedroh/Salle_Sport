using System.Data.SqlClient;

namespace Salle_Sport
{
    class Conn
    {
        public static SqlConnection conn = new SqlConnection("Data Source = .\\SQLEXPRESS ;Initial Catalog=Salle_Sport;Integrated Security=true");
    }

}
