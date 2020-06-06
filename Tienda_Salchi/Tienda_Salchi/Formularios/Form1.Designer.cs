namespace Salchichoneria
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtBxUsuario = new System.Windows.Forms.TextBox();
            this.txtBxPass = new System.Windows.Forms.TextBox();
            this.picBx = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBx = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBx)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBxUsuario
            // 
            this.txtBxUsuario.Location = new System.Drawing.Point(179, 201);
            this.txtBxUsuario.Name = "txtBxUsuario";
            this.txtBxUsuario.Size = new System.Drawing.Size(132, 20);
            this.txtBxUsuario.TabIndex = 0;
            // 
            // txtBxPass
            // 
            this.txtBxPass.Location = new System.Drawing.Point(179, 253);
            this.txtBxPass.Name = "txtBxPass";
            this.txtBxPass.PasswordChar = '*';
            this.txtBxPass.Size = new System.Drawing.Size(132, 20);
            this.txtBxPass.TabIndex = 1;
            // 
            // picBx
            // 
            this.picBx.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picBx.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBx.Image = ((System.Drawing.Image)(resources.GetObject("picBx.Image")));
            this.picBx.Location = new System.Drawing.Point(179, 12);
            this.picBx.Name = "picBx";
            this.picBx.Size = new System.Drawing.Size(132, 130);
            this.picBx.TabIndex = 2;
            this.picBx.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(137, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = "Entrar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.Location = new System.Drawing.Point(255, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 47);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancelar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBx
            // 
            this.checkBx.AutoSize = true;
            this.checkBx.Location = new System.Drawing.Point(179, 279);
            this.checkBx.Name = "checkBx";
            this.checkBx.Size = new System.Drawing.Size(61, 17);
            this.checkBx.TabIndex = 7;
            this.checkBx.Text = "Mostrar";
            this.checkBx.UseVisualStyleBackColor = true;
            this.checkBx.CheckedChanged += new System.EventHandler(this.checkBx_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(472, 467);
            this.ControlBox = false;
            this.Controls.Add(this.checkBx);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBx);
            this.Controls.Add(this.txtBxPass);
            this.Controls.Add(this.txtBxUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.picBx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxUsuario;
        private System.Windows.Forms.TextBox txtBxPass;
        private System.Windows.Forms.PictureBox picBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBx;
    }
}

