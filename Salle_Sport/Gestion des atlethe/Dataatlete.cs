using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salle_Sport.Gestion_des_atlethe
{
    class Dataatlete
    {
        public static void getlist(Guna2DataGridView guna2DataGridView , String text )
        {
            try
            {
                Conn.conn.Open();
                SqlCommand sql = new SqlCommand("select * from Athlete "  , Conn.conn);
                SqlDataReader dr = sql.ExecuteReader();
                guna2DataGridView.Rows.Clear();
                while (dr.Read())
                {
                    guna2DataGridView.Rows.Add(dr[0], dr[1], dr[2], dr[3] );
                }
                Conn.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void ajourtathlete(string nom , string prenom , string pathphoto)
        {
            try
            {
                Conn.conn.Open();
                SqlCommand sql = new SqlCommand("insert into athlete values (N'"+nom+ "',N'" + prenom + "',N'" + pathphoto + "' ) ", Conn.conn);
                sql.ExecuteNonQuery();
              
             
                Conn.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
