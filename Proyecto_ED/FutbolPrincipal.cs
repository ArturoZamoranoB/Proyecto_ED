using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_ED
{
    public partial class FutbolPrincipal : Form
    {
        public FutbolPrincipal()
        {
            InitializeComponent();
        }
        
        private void btnModificar_Click(object sender, EventArgs e)
        {
            FutbolFormulario fbp = new FutbolFormulario();
            if (dataGridView1.SelectedRows.Count > 0)
            {
              
                fbp.txtNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                fbp.txtEdad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                fbp.txtCarrera.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                fbp.txtCuatrimestre.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                fbp.txtCorreo.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                fbp.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar la fila");
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FutbolPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
