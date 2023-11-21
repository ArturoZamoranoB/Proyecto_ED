namespace Proyecto_ED
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.panelDesplegable = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.btnDeplegable = new System.Windows.Forms.PictureBox();
            this.Cerrar = new System.Windows.Forms.PictureBox();
            this.Maximizar = new System.Windows.Forms.PictureBox();
            this.Restaurar = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.btn_Futbol = new System.Windows.Forms.Button();
            this.btn_Voleibol = new System.Windows.Forms.Button();
            this.btn_Beisbol = new System.Windows.Forms.Button();
            this.btn_Basquetbol = new System.Windows.Forms.Button();
            this.panelDesplegable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeplegable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDesplegable
            // 
            this.panelDesplegable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panelDesplegable.Controls.Add(this.btn_Basquetbol);
            this.panelDesplegable.Controls.Add(this.btn_Beisbol);
            this.panelDesplegable.Controls.Add(this.btn_Voleibol);
            this.panelDesplegable.Controls.Add(this.btn_Futbol);
            this.panelDesplegable.Controls.Add(this.btn_Menu);
            this.panelDesplegable.Controls.Add(this.pictureBox2);
            this.panelDesplegable.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDesplegable.Location = new System.Drawing.Point(0, 0);
            this.panelDesplegable.Name = "panelDesplegable";
            this.panelDesplegable.Size = new System.Drawing.Size(220, 650);
            this.panelDesplegable.TabIndex = 0;
            this.panelDesplegable.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesplegable_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(211, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelTitulo.Controls.Add(this.btnDeplegable);
            this.panelTitulo.Controls.Add(this.Cerrar);
            this.panelTitulo.Controls.Add(this.Maximizar);
            this.panelTitulo.Controls.Add(this.Restaurar);
            this.panelTitulo.Controls.Add(this.Minimizar);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(220, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1080, 50);
            this.panelTitulo.TabIndex = 1;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
            // 
            // btnDeplegable
            // 
            this.btnDeplegable.Image = ((System.Drawing.Image)(resources.GetObject("btnDeplegable.Image")));
            this.btnDeplegable.Location = new System.Drawing.Point(6, 8);
            this.btnDeplegable.Name = "btnDeplegable";
            this.btnDeplegable.Size = new System.Drawing.Size(42, 36);
            this.btnDeplegable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDeplegable.TabIndex = 8;
            this.btnDeplegable.TabStop = false;
            this.btnDeplegable.Click += new System.EventHandler(this.btnDeplegable_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Cerrar.Image")));
            this.Cerrar.Location = new System.Drawing.Point(1051, 12);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(17, 17);
            this.Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Cerrar.TabIndex = 7;
            this.Cerrar.TabStop = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // Maximizar
            // 
            this.Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximizar.Image = ((System.Drawing.Image)(resources.GetObject("Maximizar.Image")));
            this.Maximizar.Location = new System.Drawing.Point(1015, 12);
            this.Maximizar.Name = "Maximizar";
            this.Maximizar.Size = new System.Drawing.Size(17, 17);
            this.Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Maximizar.TabIndex = 6;
            this.Maximizar.TabStop = false;
            this.Maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // Restaurar
            // 
            this.Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Restaurar.Image = ((System.Drawing.Image)(resources.GetObject("Restaurar.Image")));
            this.Restaurar.Location = new System.Drawing.Point(1015, 12);
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.Size = new System.Drawing.Size(17, 17);
            this.Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Restaurar.TabIndex = 5;
            this.Restaurar.TabStop = false;
            this.Restaurar.Click += new System.EventHandler(this.Restaurar_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.Location = new System.Drawing.Point(977, 12);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(17, 17);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimizar.TabIndex = 4;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(220, 50);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1080, 600);
            this.panelContenedor.TabIndex = 2;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // btn_Menu
            // 
            this.btn_Menu.FlatAppearance.BorderSize = 0;
            this.btn_Menu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Menu.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Menu.ForeColor = System.Drawing.Color.White;
            this.btn_Menu.Image = ((System.Drawing.Image)(resources.GetObject("btn_Menu.Image")));
            this.btn_Menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Menu.Location = new System.Drawing.Point(0, 111);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(220, 34);
            this.btn_Menu.TabIndex = 0;
            this.btn_Menu.Text = "Menu";
            this.btn_Menu.UseVisualStyleBackColor = true;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // btn_Futbol
            // 
            this.btn_Futbol.FlatAppearance.BorderSize = 0;
            this.btn_Futbol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_Futbol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Futbol.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Futbol.ForeColor = System.Drawing.Color.White;
            this.btn_Futbol.Image = ((System.Drawing.Image)(resources.GetObject("btn_Futbol.Image")));
            this.btn_Futbol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Futbol.Location = new System.Drawing.Point(0, 171);
            this.btn_Futbol.Name = "btn_Futbol";
            this.btn_Futbol.Size = new System.Drawing.Size(220, 34);
            this.btn_Futbol.TabIndex = 2;
            this.btn_Futbol.Text = "Futbol";
            this.btn_Futbol.UseVisualStyleBackColor = true;
            this.btn_Futbol.Click += new System.EventHandler(this.btn_Futbol_Click);
            // 
            // btn_Voleibol
            // 
            this.btn_Voleibol.FlatAppearance.BorderSize = 0;
            this.btn_Voleibol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_Voleibol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Voleibol.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Voleibol.ForeColor = System.Drawing.Color.White;
            this.btn_Voleibol.Image = ((System.Drawing.Image)(resources.GetObject("btn_Voleibol.Image")));
            this.btn_Voleibol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Voleibol.Location = new System.Drawing.Point(3, 341);
            this.btn_Voleibol.Name = "btn_Voleibol";
            this.btn_Voleibol.Size = new System.Drawing.Size(217, 34);
            this.btn_Voleibol.TabIndex = 3;
            this.btn_Voleibol.Text = "Voleibol";
            this.btn_Voleibol.UseVisualStyleBackColor = true;
            // 
            // btn_Beisbol
            // 
            this.btn_Beisbol.FlatAppearance.BorderSize = 0;
            this.btn_Beisbol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_Beisbol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Beisbol.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Beisbol.ForeColor = System.Drawing.Color.White;
            this.btn_Beisbol.Image = ((System.Drawing.Image)(resources.GetObject("btn_Beisbol.Image")));
            this.btn_Beisbol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Beisbol.Location = new System.Drawing.Point(0, 281);
            this.btn_Beisbol.Name = "btn_Beisbol";
            this.btn_Beisbol.Size = new System.Drawing.Size(220, 34);
            this.btn_Beisbol.TabIndex = 4;
            this.btn_Beisbol.Text = "Beisbol";
            this.btn_Beisbol.UseVisualStyleBackColor = true;
            // 
            // btn_Basquetbol
            // 
            this.btn_Basquetbol.FlatAppearance.BorderSize = 0;
            this.btn_Basquetbol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_Basquetbol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Basquetbol.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Basquetbol.ForeColor = System.Drawing.Color.White;
            this.btn_Basquetbol.Image = ((System.Drawing.Image)(resources.GetObject("btn_Basquetbol.Image")));
            this.btn_Basquetbol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Basquetbol.Location = new System.Drawing.Point(0, 228);
            this.btn_Basquetbol.Name = "btn_Basquetbol";
            this.btn_Basquetbol.Size = new System.Drawing.Size(220, 34);
            this.btn_Basquetbol.TabIndex = 5;
            this.btn_Basquetbol.Text = "Basquetbol";
            this.btn_Basquetbol.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelDesplegable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipal";
            this.Text = "Form1";
            this.panelDesplegable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnDeplegable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesplegable;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.PictureBox Restaurar;
        private System.Windows.Forms.PictureBox Maximizar;
        private System.Windows.Forms.PictureBox Cerrar;
        private System.Windows.Forms.PictureBox btnDeplegable;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.Button btn_Basquetbol;
        private System.Windows.Forms.Button btn_Beisbol;
        private System.Windows.Forms.Button btn_Voleibol;
        private System.Windows.Forms.Button btn_Futbol;
    }
}