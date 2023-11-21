using Proyecto_ED.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Proyecto_ED.Models.PersonaModel;


namespace Proyecto_ED
{
    public partial class FutbolFormulario : Form
    {
        public FutbolFormulario()
        {
            InitializeComponent();
        }
        public FutbolPrincipal FormPrincipal { get; set; }

        private PersonaModel.Persona[] personas = new PersonaModel.Persona[10];


        private void labelEdad_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            int indiceFila = dataGridView1.Rows.Count;

             dataGridView1.Rows.Add(
             indiceFila + 1, // Asignar la Id basada en el índice de la fila
             txtNombre.Text,
             int.Parse(txtEdad.Text),
             txtCarrera.Text,
             txtCuatrimestre.Text,
             txtCorreo.Text
          );

            MessageBox.Show("Persona guardada correctamente.");
            



        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCarrera_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCuatrimestre_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelNombre_Click(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];

                // Mostrar los datos de la fila en los TextBox
                txtNombre.Text = filaSeleccionada.Cells["ColumnNombre"].Value.ToString();
                txtEdad.Text = filaSeleccionada.Cells["ColumnEdad"].Value.ToString();
                txtCarrera.Text = filaSeleccionada.Cells["ColumnCarrera"].Value.ToString();
                txtCuatrimestre.Text = filaSeleccionada.Cells["ColumnCuatrimestre"].Value.ToString();
                txtCorreo.Text = filaSeleccionada.Cells["ColumnCorreo"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para editar.");
            }



        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Eliminar la fila seleccionada
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.");
            }
        }
    }
}
