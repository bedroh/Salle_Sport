﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salle_Sport.Gestion_des_atlethe
{
    public partial class Listdesathlete : UserControl
    {
        public Listdesathlete()
        {
            InitializeComponent();
        }

        private void Listdesathlete_Load(object sender, EventArgs e)
        {
            Dataatlete.getlist(guna2DataGridView1 , guna2TextBox1.Text);
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}