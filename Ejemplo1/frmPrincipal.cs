﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()

        {
            //le agrego un comentario
            InitializeComponent();
        }

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Form1))
                {
                    MessageBox.Show("Ya existe esta ventana abierta termine de trabajar allí");
                    return;

                }
            }  


            Form1 ventana = new Form1();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void tsbPerfilPersona_Click(object sender, EventArgs e)
        {

            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Form1))
                {
                    MessageBox.Show("Ya existe esta ventana abierta termine de trabajar allí");
                    return;

                }
            }
            Form1 ventana = new Form1();
            ventana.ShowDialog();
        }
    }
}
