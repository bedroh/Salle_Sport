using System;
using System.Windows.Forms;

namespace Salle_Sport.Gestion_des_catigories
{
    public partial class Modifier : Form
    {

        public Modifier(string nom, string prix)
        {
            InitializeComponent();
            bunifuTextBox1.Text = nom;
            bunifuTextBox2.Text = prix;
        }

        private void Modifier_Load(object sender, EventArgs e)
        {

        }
    }
}
