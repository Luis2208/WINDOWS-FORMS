namespace Tienda_Salchi.Formularios
{
    partial class DetalleVenta
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
            this.GridDetalle = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // GridDetalle
            // 
            this.GridDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDetalle.Location = new System.Drawing.Point(92, 114);
            this.GridDetalle.Name = "GridDetalle";
            this.GridDetalle.Size = new System.Drawing.Size(613, 277);
            this.GridDetalle.TabIndex = 0;
            // 
            // DetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GridDetalle);
            this.Name = "DetalleVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetalleVenta";
            this.Load += new System.EventHandler(this.DetalleVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridDetalle;
    }
}