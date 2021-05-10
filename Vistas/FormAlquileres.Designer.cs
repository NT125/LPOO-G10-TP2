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
            this.btnBuscarAlq = new System.Windows.Forms.Button();
            this.txtBuscarAlq = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlquileres)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAlquileres
            // 
            this.dataGridViewAlquileres.AllowUserToAddRows = false;
            this.dataGridViewAlquileres.AllowUserToDeleteRows = false;
            this.dataGridViewAlquileres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlquileres.Location = new System.Drawing.Point(12, 39);
            this.dataGridViewAlquileres.Name = "dataGridViewAlquileres";
            this.dataGridViewAlquileres.ReadOnly = true;
            this.dataGridViewAlquileres.Size = new System.Drawing.Size(546, 150);
            this.dataGridViewAlquileres.TabIndex = 0;
            this.dataGridViewAlquileres.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAlquileres_CellContentClick);
            // 
            // btnConsultaAlquiler
            // 
            this.btnConsultaAlquiler.Location = new System.Drawing.Point(12, 10);
            this.btnConsultaAlquiler.Name = "btnConsultaAlquiler";
            this.btnConsultaAlquiler.Size = new System.Drawing.Size(123, 23);
            this.btnConsultaAlquiler.TabIndex = 1;
            this.btnConsultaAlquiler.Text = "Realizar Consulta";
            this.btnConsultaAlquiler.UseVisualStyleBackColor = true;
            this.btnConsultaAlquiler.Click += new System.EventHandler(this.btnConsultaAlquiler_Click);
            // 
            // btnBuscarAlq
            // 
            this.btnBuscarAlq.Location = new System.Drawing.Point(341, 10);
            this.btnBuscarAlq.Name = "btnBuscarAlq";
            this.btnBuscarAlq.Size = new System.Drawing.Size(123, 23);
            this.btnBuscarAlq.TabIndex = 2;
            this.btnBuscarAlq.Text = "Buscar por ID";
            this.btnBuscarAlq.UseVisualStyleBackColor = true;
            this.btnBuscarAlq.Click += new System.EventHandler(this.btnBuscarAlq_Click);
            // 
            // txtBuscarAlq
            // 
            this.txtBuscarAlq.Location = new System.Drawing.Point(470, 12);
            this.txtBuscarAlq.Name = "txtBuscarAlq";
            this.txtBuscarAlq.Size = new System.Drawing.Size(88, 20);
            this.txtBuscarAlq.TabIndex = 3;
            // 
            // FormAlquileres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 201);
            this.Controls.Add(this.txtBuscarAlq);
            this.Controls.Add(this.btnBuscarAlq);
            this.Controls.Add(this.btnConsultaAlquiler);
            this.Controls.Add(this.dataGridViewAlquileres);
            this.Name = "FormAlquileres";
            this.Text = "Consulta de Alquileres";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlquileres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAlquileres;
        private System.Windows.Forms.Button btnConsultaAlquiler;
        private System.Windows.Forms.Button btnBuscarAlq;
        private System.Windows.Forms.TextBox txtBuscarAlq;
    }
}