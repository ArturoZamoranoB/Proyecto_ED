using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Proyecto_ED.BasquetbolForms;
using Proyecto_ED.BeisbolForms;

namespace Proyecto_ED
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int Iparam);

        //----------------------------------------------------------
        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGriRectangle;

        protected override void WndProc(ref Message m)
        {
            switch(m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGriRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc (ref m);
                    break;      
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e); 
            var region = new Region(new Rectangle(0,0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGriRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGriRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(55,61,69));
            e.Graphics.FillRectangle(blueBrush, sizeGriRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Blue, sizeGriRectangle);
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Restaurar.Visible = true;
            Maximizar.Visible = false;
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            Maximizar.Visible = true;
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnDeplegable_Click(object sender, EventArgs e)
        {
            if (panelDesplegable.Width == 220)
            {
                panelDesplegable.Width = 66;
            }
            else
            {
                panelDesplegable.Width = 220;
            }
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void panelDesplegable_Paint(object sender, PaintEventArgs e)
        {

        }
        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
            
                this.panelContenedor.Controls.RemoveAt(0);
                Form fh = Formhijo as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.panelContenedor.Controls.Add(fh);
                this.panelContenedor.Tag = fh;
                fh.Show();

            
        }
        private void btn_Menu_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new MenuBienvenida());
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Futbol_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new MenuBienvenida());
        }

        private void btn_Basquetbol_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new MenuBasquetbol());
        }

        private void btn_Beisbol_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new MenuBeisbol());
        }
    }
}
