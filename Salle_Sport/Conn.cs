using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salle_Sport
{
    class Conn
    {
       public static  SqlConnection conn = new SqlConnection("Data Source = .\\SQLEXPRESS ;Initial Catalog=Salle_Sport;Integrated Security=true");
    }

}
