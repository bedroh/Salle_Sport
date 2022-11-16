using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salle_Sport.Gestion_des_catigories
{
    class Datacategorie
    {
        public static void Ajouter_categorie(String nomabonement , Double prix)
        {
            try
            {
                Conn.conn.Open();
                SqlCommand sql = new SqlCommand("insert into Categories Set nomcategorie='"+nomabonement+ "' , prixcategorie ='"+prix+"';" ,Conn.conn );
                sql.ExecuteNonQuery();
                Conn.conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message ,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Conn.conn.Close();
            }
        }
        public static void Modifier_categorie(String nomabonement, Double prix , int id )
        {
            try
            {
                Conn.conn.Open();
                SqlCommand sql = new SqlCommand("update  Categories Set nomcategorie='" + nomabonement + "' , prixcategorie ='" + prix + "' where idcategorie='"+id+"' ;", Conn.conn);
                sql.ExecuteNonQuery();
                Conn.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Conn.conn.Close();
            }
        }
        public static void List_des_categorie(BunifuDataGridView bunifuDataGridView , String txt)
        {
            try
            {
                Conn.conn.Open();
                SqlCommand sql = new SqlCommand("Select * from categories where nomcategorie Like %'"+txt+"'% ;", Conn.conn);
             SqlDataReader dr =    sql.ExecuteReader();
                bunifuDataGridView.Rows.Clear();
                while (dr.Read())
                {
                    bunifuDataGridView.Rows.Add(dr[0], dr[1], dr[2]);

                }
                Conn.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Conn.conn.Close();
            }
        }
        public static void Supprimer_categorie(int id)
        {
            try
            {
                Conn.conn.Open();
                SqlCommand sql = new SqlCommand("delete from categories where idcategorie ='"+id+"' ;", Conn.conn);
                sql.ExecuteNonQuery();
                Conn.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Conn.conn.Close();
            }
        }
    }
}
