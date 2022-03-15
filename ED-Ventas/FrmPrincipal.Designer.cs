namespace ED_Ventas
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgVentas = new System.Windows.Forms.DataGridView();
            this.btnNuevaVenta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgVentas
            // 
            this.dtgVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVentas.Location = new System.Drawing.Point(12, 12);
            this.dtgVentas.Name = "dtgVentas";
            this.dtgVentas.RowHeadersWidth = 51;
            this.dtgVentas.RowTemplate.Height = 29;
            this.dtgVentas.Size = new System.Drawing.Size(776, 380);
            this.dtgVentas.TabIndex = 0;
            // 
            // btnNuevaVenta
            // 
            this.btnNuevaVenta.Location = new System.Drawing.Point(496, 409);
            this.btnNuevaVenta.Name = "btnNuevaVenta";
            this.btnNuevaVenta.Size = new System.Drawing.Size(292, 29);
            this.btnNuevaVenta.TabIndex = 1;
            this.btnNuevaVenta.Text = "Nueva venta";
            this.btnNuevaVenta.UseVisualStyleBackColor = true;
            this.btnNuevaVenta.Click += new System.EventHandler(this.btnNuevaVenta_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNuevaVenta);
            this.Controls.Add(this.dtgVentas);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtgVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dtgVentas;
        private Button btnNuevaVenta;
    }
}