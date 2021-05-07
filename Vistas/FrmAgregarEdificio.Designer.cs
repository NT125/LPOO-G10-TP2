namespace Vistas
{
    partial class FrmAgregarEdificio
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreEdificio = new System.Windows.Forms.TextBox();
            this.txtDireccionEdificio = new System.Windows.Forms.TextBox();
            this.txtAdministradorEdificio = new System.Windows.Forms.TextBox();
            this.txtTelefonoEdificio = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adminstrador";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "N° Telefóno";
            // 
            // txtNombreEdificio
            // 
            this.txtNombreEdificio.Location = new System.Drawing.Point(138, 65);
            this.txtNombreEdificio.Name = "txtNombreEdificio";
            this.txtNombreEdificio.Size = new System.Drawing.Size(173, 20);
            this.txtNombreEdificio.TabIndex = 4;
            // 
            // txtDireccionEdificio
            // 
            this.txtDireccionEdificio.Location = new System.Drawing.Point(138, 118);
            this.txtDireccionEdificio.Name = "txtDireccionEdificio";
            this.txtDireccionEdificio.Size = new System.Drawing.Size(173, 20);
            this.txtDireccionEdificio.TabIndex = 5;
            // 
            // txtAdministradorEdificio
            // 
            this.txtAdministradorEdificio.Location = new System.Drawing.Point(138, 179);
            this.txtAdministradorEdificio.Name = "txtAdministradorEdificio";
            this.txtAdministradorEdificio.Size = new System.Drawing.Size(173, 20);
            this.txtAdministradorEdificio.TabIndex = 6;
            // 
            // txtTelefonoEdificio
            // 
            this.txtTelefonoEdificio.Location = new System.Drawing.Point(138, 240);
            this.txtTelefonoEdificio.Name = "txtTelefonoEdificio";
            this.txtTelefonoEdificio.Size = new System.Drawing.Size(173, 20);
            this.txtTelefonoEdificio.TabIndex = 7;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(237, 285);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(138, 285);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Agregar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ingrese los datos del Edificio:";
            // 
            // FrmAgregarEdificio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 321);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtTelefonoEdificio);
            this.Controls.Add(this.txtAdministradorEdificio);
            this.Controls.Add(this.txtDireccionEdificio);
            this.Controls.Add(this.txtNombreEdificio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAgregarEdificio";
            this.Text = "Agregar Edificio";
            this.Load += new System.EventHandler(this.FrmAgregarEdificio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreEdificio;
        private System.Windows.Forms.TextBox txtDireccionEdificio;
        private System.Windows.Forms.TextBox txtAdministradorEdificio;
        private System.Windows.Forms.TextBox txtTelefonoEdificio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label5;
    }
}