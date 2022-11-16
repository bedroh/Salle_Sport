using System;
using System.Windows.Forms;

namespace Salle_Sport.Gestion_des_catigories
{
    public partial class Liste_des_catigories : UserControl
    {
        public Liste_des_catigories()
        {
            InitializeComponent();
        }

        private void Liste_des_catigories_Load(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Ajouter_catégorie ajtC = new Ajouter_catégorie();
            ajtC.ShowDialog();
        }
    }
}
