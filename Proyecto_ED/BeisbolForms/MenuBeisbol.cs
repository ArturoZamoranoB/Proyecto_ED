using Proyecto_ED.Clases;
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

namespace Proyecto_ED.BeisbolForms
{
    public partial class MenuBeisbol : Form
    {
        private PilaLista listaBeisbol = new PilaLista();
        public MenuBeisbol()
        {
            InitializeComponent();
            InicializarDataGridView();
        }
        private void InicializarDataGridView()
        {
            
            dataGridView1.Columns.Add("ColumnID", "Id");
            dataGridView1.Columns.Add("ColumnNombre", "Nombre");
            dataGridView1.Columns.Add("ColumnEdad", "Edad");
            dataGridView1.Columns.Add("ColumnCarrera", "Carrera");
            dataGridView1.Columns.Add("ColumnCuatrimestre", "Cuatrimestre");
            dataGridView1.Columns.Add("ColumnCorreo", "Correo");
        }
        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtEdad.Text = "";
            txtCarrera.Text = "";
            txtCuatrimestre.Text = "";
            txtCorreo.Text = "";
        }
        private void ActualizarDataGridView()
        {
            dataGridView1.Rows.Clear();

            foreach (var jugador in listaBeisbol.ObtenerJugadores())
            {
                if (jugador != null)
                {
                    dataGridView1.Rows.Add(
                        jugador.Id,
                        jugador.Nombre,
                        jugador.Edad,
                        jugador.Carrera,
                        jugador.Cuatrimestre,
                        jugador.Correo
                    );
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            
            string nombre = txtNombre.Text;
            int edad = int.Parse(txtEdad.Text);
            string carrera = txtCarrera.Text;
            string cuatrimestre = txtCuatrimestre.Text;
            string correo = txtCorreo.Text;

        
            if (int.TryParse(textBoxModificar.Text, out int idModificar))
            {
              
                listaBeisbol.ModificarJugadorPila(idModificar, nombre, edad, carrera, cuatrimestre, correo);

                
                ActualizarDataGridView();

             
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Ingrese un ID válido para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
         
            string nombre = txtNombre.Text;
            int edad;

            if (int.TryParse(txtEdad.Text, out edad))
            {
                string carrera = txtCarrera.Text;
                string cuatrimestre = txtCuatrimestre.Text;
                string correo = txtCorreo.Text;

         
                listaBeisbol.AgregarJugadorPila(nombre, edad, carrera, cuatrimestre, correo);

        
                ActualizarDataGridView();


                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Ingrese una edad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void textBoxEliminar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
           
            if (int.TryParse(textBoxEliminar.Text, out int idEliminar))
            {

                Persona jugadorExistente = listaBeisbol.BuscarJugadorPorId(idEliminar);

                if (jugadorExistente != null)
                {
       
                    listaBeisbol.EliminarJugadorPila(idEliminar);
                    ActualizarDataGridView();
                    MessageBox.Show($"Jugador con ID {idEliminar} eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
       
                    MessageBox.Show($"No se encontró un jugador con ID {idEliminar}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un ID válido para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            
            if (int.TryParse(textBoxModificar.Text, out int idModificar))
            {

                Persona jugadorModificar = listaBeisbol.BuscarJugadorPorId(idModificar);

               
                if (jugadorModificar != null)
                {
                  
                    txtNombre.Text = jugadorModificar.Nombre;
                    txtEdad.Text = jugadorModificar.Edad.ToString();
                    txtCarrera.Text = jugadorModificar.Carrera;
                    txtCuatrimestre.Text = jugadorModificar.Cuatrimestre;
                    txtCorreo.Text = jugadorModificar.Correo;
                }
                else
                {
                    MessageBox.Show("No se encontró ningún jugador con el ID ingresado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un ID válido para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxModificar_TextChanged(object sender, EventArgs e)
        {

        }

        private void MenuBeisbol_Load(object sender, EventArgs e)
        {

        }
    }
}
