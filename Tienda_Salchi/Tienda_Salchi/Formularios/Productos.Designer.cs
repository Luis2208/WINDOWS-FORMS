namespace Salchichoneria.Formularios
{
    partial class Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCate = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblPre = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.TxtBxCantidad = new System.Windows.Forms.TextBox();
            this.lblImagen = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bttnBuscar = new System.Windows.Forms.Button();
            this.txtbxMosBus = new System.Windows.Forms.TextBox();
            this.txtBxEnlace = new System.Windows.Forms.TextBox();
            this.bttnEliminar = new System.Windows.Forms.Button();
            this.bttnEditar = new System.Windows.Forms.Button();
            this.bttNuevo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(205, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(116, 31);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(63, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCate
            // 
            this.lblCate.AutoSize = true;
            this.lblCate.Location = new System.Drawing.Point(116, 78);
            this.lblCate.Name = "lblCate";
            this.lblCate.Size = new System.Drawing.Size(76, 16);
            this.lblCate.TabIndex = 3;
            this.lblCate.Text = "Categoría";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Queso.",
            "Carnes Frías.",
            "Empacados."});
            this.comboBox1.Location = new System.Drawing.Point(205, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // lblPre
            // 
            this.lblPre.AutoSize = true;
            this.lblPre.Location = new System.Drawing.Point(116, 125);
            this.lblPre.Name = "lblPre";
            this.lblPre.Size = new System.Drawing.Size(53, 16);
            this.lblPre.TabIndex = 5;
            this.lblPre.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(205, 122);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 22);
            this.txtPrecio.TabIndex = 6;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(116, 170);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(70, 16);
            this.lblCantidad.TabIndex = 7;
            this.lblCantidad.Text = "Cantidad";
            // 
            // TxtBxCantidad
            // 
            this.TxtBxCantidad.Location = new System.Drawing.Point(205, 163);
            this.TxtBxCantidad.Name = "TxtBxCantidad";
            this.TxtBxCantidad.Size = new System.Drawing.Size(100, 22);
            this.TxtBxCantidad.TabIndex = 8;
            this.TxtBxCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxCantidad_KeyPress);
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Location = new System.Drawing.Point(116, 211);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(95, 16);
            this.lblImagen.TabIndex = 9;
            this.lblImagen.Text = "Descripcion ";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Image = global::Tienda_Salchi.Properties.Resources.Guardar;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(608, 194);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 47);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Guardar";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 331);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(797, 201);
            this.dataGridView1.TabIndex = 13;
            // 
            // bttnBuscar
            // 
            this.bttnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("bttnBuscar.Image")));
            this.bttnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnBuscar.Location = new System.Drawing.Point(125, 19);
            this.bttnBuscar.Name = "bttnBuscar";
            this.bttnBuscar.Size = new System.Drawing.Size(91, 38);
            this.bttnBuscar.TabIndex = 14;
            this.bttnBuscar.Text = "Buscar";
            this.bttnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnBuscar.UseVisualStyleBackColor = false;
            this.bttnBuscar.Click += new System.EventHandler(this.bttnBuscar_Click);
            // 
            // txtbxMosBus
            // 
            this.txtbxMosBus.Location = new System.Drawing.Point(6, 35);
            this.txtbxMosBus.Name = "txtbxMosBus";
            this.txtbxMosBus.Size = new System.Drawing.Size(100, 22);
            this.txtbxMosBus.TabIndex = 15;
            this.txtbxMosBus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxMosBus_KeyPress);
            // 
            // txtBxEnlace
            // 
            this.txtBxEnlace.Location = new System.Drawing.Point(205, 204);
            this.txtBxEnlace.Name = "txtBxEnlace";
            this.txtBxEnlace.Size = new System.Drawing.Size(100, 22);
            this.txtBxEnlace.TabIndex = 16;
            this.txtBxEnlace.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxEnlace_KeyPress);
            // 
            // bttnEliminar
            // 
            this.bttnEliminar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("bttnEliminar.Image")));
            this.bttnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnEliminar.Location = new System.Drawing.Point(276, 17);
            this.bttnEliminar.Name = "bttnEliminar";
            this.bttnEliminar.Size = new System.Drawing.Size(91, 38);
            this.bttnEliminar.TabIndex = 17;
            this.bttnEliminar.Text = "Eliminar";
            this.bttnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnEliminar.UseVisualStyleBackColor = false;
            this.bttnEliminar.Click += new System.EventHandler(this.bttnEliminar_Click);
            // 
            // bttnEditar
            // 
            this.bttnEditar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnEditar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttnEditar.Image = ((System.Drawing.Image)(resources.GetObject("bttnEditar.Image")));
            this.bttnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnEditar.Location = new System.Drawing.Point(419, 17);
            this.bttnEditar.Name = "bttnEditar";
            this.bttnEditar.Size = new System.Drawing.Size(91, 38);
            this.bttnEditar.TabIndex = 18;
            this.bttnEditar.Text = "Editar";
            this.bttnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnEditar.UseVisualStyleBackColor = false;
            this.bttnEditar.Click += new System.EventHandler(this.bttnEditar_Click);
            // 
            // bttNuevo
            // 
            this.bttNuevo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttNuevo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttNuevo.Image = ((System.Drawing.Image)(resources.GetObject("bttNuevo.Image")));
            this.bttNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttNuevo.Location = new System.Drawing.Point(6, 26);
            this.bttNuevo.Name = "bttNuevo";
            this.bttNuevo.Size = new System.Drawing.Size(89, 47);
            this.bttNuevo.TabIndex = 19;
            this.bttNuevo.Text = "Nuevo";
            this.bttNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttNuevo.UseVisualStyleBackColor = false;
            this.bttNuevo.Click += new System.EventHandler(this.bttNuevo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Bisque;
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.bttNuevo);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.lblCate);
            this.groupBox1.Controls.Add(this.lblImagen);
            this.groupBox1.Controls.Add(this.txtBxEnlace);
            this.groupBox1.Controls.Add(this.lblCantidad);
            this.groupBox1.Controls.Add(this.TxtBxCantidad);
            this.groupBox1.Controls.Add(this.lblPre);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(787, 245);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formulario Productos";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.txtbxMosBus);
            this.groupBox2.Controls.Add(this.bttnBuscar);
            this.groupBox2.Controls.Add(this.bttnEliminar);
            this.groupBox2.Controls.Add(this.bttnEditar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(12, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(787, 61);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu Editar";
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCate;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblPre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox TxtBxCantidad;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bttnBuscar;
        private System.Windows.Forms.TextBox txtbxMosBus;
        private System.Windows.Forms.TextBox txtBxEnlace;
        private System.Windows.Forms.Button bttnEliminar;
        private System.Windows.Forms.Button bttnEditar;
        private System.Windows.Forms.Button bttNuevo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}