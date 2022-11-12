using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Salle_Sport
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        
        public Form1()
        {
            InitializeComponent();
            String ConString = "Data Source = .\\SQLEXPRESS ;Initial Catalog=GESTION_DE_STOCK;Integrated Security=true ";
            con = new SqlConnection(ConString);
  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = " select* from  Utilisateur ";
            SqlCommand cmd = new SqlCommand(sql,con);
            SqlDataReader sqldatta = cmd.ExecuteReader();
            dataGridView1.Rows.Clear(); 
            while (sqldatta.Read())
            {
                dataGridView1.Rows.Add(sqldatta[0], sqldatta[1]);
            }
            con.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_ajt_ath_Click(object sender, EventArgs e)
        {
            panel2.Show();
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
