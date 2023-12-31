﻿using Proyecto_ED.Clases;
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
        private void LimpiarCamposId()
        {
       
            textBoxEliminar.Text = "";
            textBoxModificar.Text = "";
        }

        private void ActualizarDataGridView()
        {

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
       
            if (int.TryParse(textBoxEliminar.Text, out int idEliminar))
            {
      
                Persona jugadorExistente = gestorFutbol.BuscarJugadorPorId(idEliminar);

                if (jugadorExistente != null)
                {
  
                    gestorFutbol.EliminarJugador(idEliminar);

              
                    ActualizarDataGridView();
                    LimpiarCamposId();

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
      
               Persona jugadorModificar = gestorFutbol.BuscarJugadorPorId(idModificar);

       
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

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            
            string nombre = txtNombre.Text;
            int edad = int.Parse(txtEdad.Text);
            string carrera = txtCarrera.Text;
            string cuatrimestre = txtCuatrimestre.Text;
            string correo = txtCorreo.Text;

            gestorFutbol.AgregarJugador(nombre, edad, carrera, cuatrimestre, correo);

            
            ActualizarDataGridView();

     
            LimpiarCampos();
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
            
                gestorFutbol.ModificarJugador(idModificar, nombre, edad, carrera, cuatrimestre, correo);

             
                ActualizarDataGridView();

                
                LimpiarCampos();
                LimpiarCamposId();
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void labelCorreo_Click(object sender, EventArgs e)
        {

        }

        private void labelCuatrimestre_Click(object sender, EventArgs e)
        {

        }

        private void labelEdad_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelNombre_Click(object sender, EventArgs e)
        {

        }

        private void LabelTitulo_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
        
    
}
