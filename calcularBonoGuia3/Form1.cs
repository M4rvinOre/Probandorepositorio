using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcularBonoGuia3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtSalario.Text = "";
            txtBono.Text = "";
            cmbBoxPuesto.SelectedIndex = -1;
            txtNombre.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (cmbBoxPuesto.SelectedIndex == -1)
            {
                MessageBox.Show("No ha seleccionado un Puesto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int puesto = cmbBoxPuesto.SelectedIndex + 1;
                switch (puesto)
                {
                    case 1:
                        txtBono.Text = "$500";
                        break;
                    case 2:
                        txtBono.Text = "$300";
                        break;
                    case 3:
                        txtBono.Text = "$200";
                        break;
                    case 4:
                        txtBono.Text = "$100";
                        break;
                }
            }

        }
    }
}
