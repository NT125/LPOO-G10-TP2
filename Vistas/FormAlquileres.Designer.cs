namespace Vistas
{
    partial class FormAlquileres
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
            this.dataGridViewAlquileres = new System.Windows.Forms.DataGridView();
            this.btnConsultaAlquiler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlquileres)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAlquileres
            // 
            this.dataGridViewAlquileres.AllowUserToAddRows = false;
            this.dataGridViewAlquileres.AllowUserToDeleteRows = false;
            this.dataGridViewAlquileres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlquileres.Location = new System.Drawing.Point(12, 37);
            this.dataGridViewAlquileres.Name = "dataGridViewAlquileres";
            this.dataGridViewAlquileres.ReadOnly = true;
            this.dataGridViewAlquileres.Size = new System.Drawing.Size(546, 150);
            this.dataGridViewAlquileres.TabIndex = 0;
            this.dataGridViewAlquileres.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAlquileres_CellContentClick);
            // 
            // btnConsultaAlquiler
            // 
            this.btnConsultaAlquiler.Location = new System.Drawing.Point(23, 8);
            this.btnConsultaAlquiler.Name = "btnConsultaAlquiler";
            this.btnConsultaAlquiler.Size = new System.Drawing.Size(75, 23);
            this.btnConsultaAlquiler.TabIndex = 1;
            this.btnConsultaAlquiler.Text = "Consulta";
            this.btnConsultaAlquiler.UseVisualStyleBackColor = true;
            this.btnConsultaAlquiler.Click += new System.EventHandler(this.btnConsultaAlquiler_Click);
            // 
            // FormAlquileres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 273);
            this.Controls.Add(this.btnConsultaAlquiler);
            this.Controls.Add(this.dataGridViewAlquileres);
            this.Name = "FormAlquileres";
            this.Text = "FormAlquileres";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlquileres)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAlquileres;
        private System.Windows.Forms.Button btnConsultaAlquiler;
    }
}