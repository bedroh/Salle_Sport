using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Salle_Sport
{
    public partial class Form1 : Form
    {
#pragma warning disable CS0169 // Le champ 'Form1.con' n'est jamais utilisé
        SqlConnection con;
#pragma warning restore CS0169 // Le champ 'Form1.con' n'est jamais utilisé

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void btn_ajt_ath_Click(object sender, EventArgs e)
        {

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            listdesathlete1.Show();
            listdesathlete1.BringToFront();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            listdespaiment1.Show();
            listdespaiment1.BringToFront();
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            liste_des_catigories1.Show();
            liste_des_catigories1.BringToFront();
        }
    }
}
