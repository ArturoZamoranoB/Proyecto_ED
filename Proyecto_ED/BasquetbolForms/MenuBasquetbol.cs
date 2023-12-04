using Proyecto_ED.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_ED.Models;
using Proyecto_ED.Clases;

namespace Proyecto_ED.BasquetbolForms
{
    public partial class MenuBasquetbol : Form
    {
        private ListaJugadores listaBasquetbol = new ListaJugadores();
        public MenuBasquetbol()
        {
            InitializeComponent();
            InicializarDataGridView();
        }
        private void InicializarDataGridView()
        {
            // Configurar las columnas del DataGridView
            dataGridView1.Columns.Add("ColumnID", "Id");
            dataGridView1.Columns.Add("ColumnNombre", "Nombre");
            dataGridView1.Columns.Add("ColumnEdad", "Edad");
            dataGridView1.Columns.Add("ColumnCarrera", "Carrera");
            dataGridView1.Columns.Add("ColumnCuatrimestre", "Cuatrimestre");
            dataGridView1.Columns.Add("ColumnCorreo", "Correo");
        }
        private void ActualizarDataGridView()
        {
            dataGridView1.Rows.Clear();

            foreach (var jugador in listaBasquetbol.ObtenerJugadores())
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
        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtEdad.Text = "";
            txtCarrera.Text = "";
            txtCuatrimestre.Text = "";
            txtCorreo.Text = "";
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void MenuBasquetbol_Load(object sender, EventArgs e)
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
             
                listaBasquetbol.ModificarJugador(idModificar, nombre, edad, carrera, cuatrimestre, correo);

           
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

     
                Persona nuevoJugador = new Persona
                {
                    Id = listaBasquetbol.ObtenerNuevoId(),
                    Nombre = nombre,
                    Edad = edad,
                    Carrera = carrera,
                    Cuatrimestre = cuatrimestre,
                    Correo = correo
                };

                listaBasquetbol.AgregarJugador(nuevoJugador);

         
                ActualizarDataGridView();

              
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Ingrese una edad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            // Obtener el ID ingresado en el TextBoxEliminar
            if (int.TryParse(textBoxEliminar.Text, out int idEliminar))
            {
                // Verificar si el jugador con el ID especificado existe
                Persona jugadorExistente = listaBasquetbol.BuscarJugadorPorId(idEliminar);

                if (jugadorExistente != null)
                {
                    // El jugador existe, eliminarlo
                    listaBasquetbol.EliminarJugador(idEliminar);
                    ActualizarDataGridView();
                    MessageBox.Show($"Jugador con ID {idEliminar} eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // El jugador no existe
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
            // Obtener el ID ingresado en el TextBox
            if (int.TryParse(textBoxModificar.Text, out int idModificar))
            {
                // Buscar el jugador con el ID ingresado
                Persona jugadorModificar = listaBasquetbol.BuscarJugadorPorId(idModificar);

                // Verificar si se encontró el jugador
                if (jugadorModificar != null)
                {
                    // Cargar los datos en los TextBoxModificar para su modificación
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


        private void textBoxEliminar_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxModificar_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        
        
        
        
        
        
        }
    }
}
