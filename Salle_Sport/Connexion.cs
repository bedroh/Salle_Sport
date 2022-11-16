using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Salle_Sport
{
    public partial class Connexion : Form
    {
        SqlConnection conn;
        public Connexion()
        {
            InitializeComponent();
            String constring = "Data Source = .\\SQLEXPRESS ;Initial Catalog=Salle_Sport;Integrated Security=true ";
            conn = new SqlConnection(constring);
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LOGIN_Click(object sender, EventArgs e)
        {
            String username, password;
            username = txtusername.Text;
            password = txtPassword.Text;

            try
            {
                conn.Open();
                string qry = "select* from Utilisateur where username ='" + txtusername.Text + "' and password ='" + txtPassword.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(qry, conn);
                DataTable dta = new DataTable();
                sda.Fill(dta);
                if (dta.Rows.Count > 0)
                {
                    username = txtusername.Text;
                    password = txtPassword.Text;
                    new Form1().Show();
                    this.Hide();
                }

            }
            catch
            {
                MessageBox.Show("Erreur");
            }



        }
    }
}
