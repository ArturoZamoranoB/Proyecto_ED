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
namespace Proyecto_ED
{
    public partial class MenuBienvenida : Form
    {

        private Arreglo gestorFutbol = new Arreglo();
        public MenuBienvenida()
        {
            InitializeComponent();
            InicializarDataGridView();
        }
        public event EventHandler DatosGuardados;
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
        private void LimpiarCampos()
        {
            // Limpiar los campos de texto
            txtNombre.Text = "";
            txtEdad.Text = "";
            txtCarrera.Text = "";
            txtCuatrimestre.Text = "";
            txtCorreo.Text = "";
        }

        private void ActualizarDataGridView()
        {
            // Limpiar y luego agregar las filas al DataGridView
            dataGridView1.Rows.Clear();

            foreach (var jugador in gestorFutbol.Jugadores)
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

            // Refrescar el DataGridView
            dataGridView1.Refresh();
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void txtNombre_TextChanged(object sender, EventArgs e)
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



        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            // Obtener el ID ingresado en el TextBox
            if (int.TryParse(textBoxEliminar.Text, out int idEliminar))
            {
                // Verificar si el jugador con el ID especificado existe
                PersonaModel.Persona jugadorExistente = gestorFutbol.BuscarJugadorPorId(idEliminar);

                if (jugadorExistente != null)
                {
                    // El jugador existe, eliminarlo
                    gestorFutbol.EliminarJugador(idEliminar);

                    // Actualizar el DataGridView
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
                PersonaModel.Persona jugadorModificar = gestorFutbol.BuscarJugadorPorId(idModificar);

                // Verificar si se encontró el jugador
                if (jugadorModificar != null)
                {
                    // Cargar los datos en los TextBox para su modificación
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

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los campos de texto
            string nombre = txtNombre.Text;
            int edad = int.Parse(txtEdad.Text);
            string carrera = txtCarrera.Text;
            string cuatrimestre = txtCuatrimestre.Text;
            string correo = txtCorreo.Text;

            // Agregar o editar jugador en el gestorFutbol
            // (Puedes implementar la lógica para identificar si estás editando o guardando nuevo)
            // En este caso, siempre agregaremos un nuevo jugador
            gestorFutbol.AgregarJugador(nombre, edad, carrera, cuatrimestre, correo);

            // Actualizar el DataGridView
            ActualizarDataGridView();

            // Limpiar los campos de texto después de agregar/editar un jugador
            LimpiarCampos();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            // Obtener los valores modificados de los campos de texto
            string nombre = txtNombre.Text;
            int edad = int.Parse(txtEdad.Text);
            string carrera = txtCarrera.Text;
            string cuatrimestre = txtCuatrimestre.Text;
            string correo = txtCorreo.Text;

            // Obtener el ID ingresado en el TextBox
            if (int.TryParse(textBoxModificar.Text, out int idModificar))
            {
                // Modificar al jugador en el gestorFutbol
                gestorFutbol.ModificarJugador(idModificar, nombre, edad, carrera, cuatrimestre, correo);

                // Actualizar el DataGridView
                ActualizarDataGridView();

                // Limpiar los campos de texto después de modificar el jugador
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Ingrese un ID válido para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MenuBienvenida_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxModificar_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEliminar_TextChanged(object sender, EventArgs e)
        {

        }
    }
        
    
}
