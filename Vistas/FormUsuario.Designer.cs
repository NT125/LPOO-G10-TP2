namespace Vistas
{
    partial class FormUsuario
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
            this.groupABM = new System.Windows.Forms.GroupBox();
            this.btnDeleteUsr = new System.Windows.Forms.Button();
            this.btnModifyUsr = new System.Windows.Forms.Button();
            this.btnAddUsr = new System.Windows.Forms.Button();
            this.groupQuery = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnShowUsr = new System.Windows.Forms.Button();
            this.btnSearchUsr = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblApNom = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPasswd = new System.Windows.Forms.Label();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.txtApeNom = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.txtNombreBuscado = new System.Windows.Forms.TextBox();
            this.groupABM.SuspendLayout();
            this.groupQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // groupABM
            // 
            this.groupABM.Controls.Add(this.txtNombreBuscado);
            this.groupABM.Controls.Add(this.lblUpdate);
            this.groupABM.Controls.Add(this.txtPasswd);
            this.groupABM.Controls.Add(this.txtUsuario);
            this.groupABM.Controls.Add(this.txtApeNom);
            this.groupABM.Controls.Add(this.cmbRoles);
            this.groupABM.Controls.Add(this.lblPasswd);
            this.groupABM.Controls.Add(this.lblUsuario);
            this.groupABM.Controls.Add(this.lblApNom);
            this.groupABM.Controls.Add(this.lblRol);
            this.groupABM.Controls.Add(this.btnDeleteUsr);
            this.groupABM.Controls.Add(this.btnModifyUsr);
            this.groupABM.Controls.Add(this.btnAddUsr);
            this.groupABM.Location = new System.Drawing.Point(12, 12);
            this.groupABM.Name = "groupABM";
            this.groupABM.Size = new System.Drawing.Size(280, 214);
            this.groupABM.TabIndex = 0;
            this.groupABM.TabStop = false;
            this.groupABM.Text = "ABM";
            // 
            // btnDeleteUsr
            // 
            this.btnDeleteUsr.ForeColor = System.Drawing.Color.Firebrick;
            this.btnDeleteUsr.Location = new System.Drawing.Point(183, 174);
            this.btnDeleteUsr.Name = "btnDeleteUsr";
            this.btnDeleteUsr.Size = new System.Drawing.Size(72, 23);
            this.btnDeleteUsr.TabIndex = 2;
            this.btnDeleteUsr.Text = "Eliminar";
            this.btnDeleteUsr.UseVisualStyleBackColor = true;
            this.btnDeleteUsr.Click += new System.EventHandler(this.btnDeleteUsr_Click);
            // 
            // btnModifyUsr
            // 
            this.btnModifyUsr.Location = new System.Drawing.Point(105, 174);
            this.btnModifyUsr.Name = "btnModifyUsr";
            this.btnModifyUsr.Size = new System.Drawing.Size(72, 23);
            this.btnModifyUsr.TabIndex = 1;
            this.btnModifyUsr.Text = "Actualizar";
            this.btnModifyUsr.UseVisualStyleBackColor = true;
            this.btnModifyUsr.Click += new System.EventHandler(this.btnModifyUsr_Click);
            // 
            // btnAddUsr
            // 
            this.btnAddUsr.Location = new System.Drawing.Point(27, 174);
            this.btnAddUsr.Name = "btnAddUsr";
            this.btnAddUsr.Size = new System.Drawing.Size(72, 23);
            this.btnAddUsr.TabIndex = 0;
            this.btnAddUsr.Text = "Agregar";
            this.btnAddUsr.UseVisualStyleBackColor = true;
            this.btnAddUsr.Click += new System.EventHandler(this.btnAddUsr_Click);
            // 
            // groupQuery
            // 
            this.groupQuery.Controls.Add(this.txtSearch);
            this.groupQuery.Controls.Add(this.btnShowUsr);
            this.groupQuery.Controls.Add(this.btnSearchUsr);
            this.groupQuery.Location = new System.Drawing.Point(19, 232);
            this.groupQuery.Name = "groupQuery";
            this.groupQuery.Size = new System.Drawing.Size(273, 111);
            this.groupQuery.TabIndex = 1;
            this.groupQuery.TabStop = false;
            this.groupQuery.Text = "Consultas";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(7, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(259, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // btnShowUsr
            // 
            this.btnShowUsr.Location = new System.Drawing.Point(6, 82);
            this.btnShowUsr.Name = "btnShowUsr";
            this.btnShowUsr.Size = new System.Drawing.Size(260, 23);
            this.btnShowUsr.TabIndex = 1;
            this.btnShowUsr.Text = "Listar todos los Usuarios";
            this.btnShowUsr.UseVisualStyleBackColor = true;
            this.btnShowUsr.Click += new System.EventHandler(this.btnShowUsr_Click);
            // 
            // btnSearchUsr
            // 
            this.btnSearchUsr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSearchUsr.Location = new System.Drawing.Point(7, 53);
            this.btnSearchUsr.Name = "btnSearchUsr";
            this.btnSearchUsr.Size = new System.Drawing.Size(260, 23);
            this.btnSearchUsr.TabIndex = 0;
            this.btnSearchUsr.Text = "Buscar Usuario";
            this.btnSearchUsr.UseVisualStyleBackColor = true;
            this.btnSearchUsr.Click += new System.EventHandler(this.btnSearchUsr_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToOrderColumns = true;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(329, 17);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(532, 282);
            this.dgvUsers.TabIndex = 2;
            this.dgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(22, 24);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(23, 13);
            this.lblRol.TabIndex = 3;
            this.lblRol.Text = "Rol";
            // 
            // lblApNom
            // 
            this.lblApNom.AutoSize = true;
            this.lblApNom.Location = new System.Drawing.Point(22, 51);
            this.lblApNom.Name = "lblApNom";
            this.lblApNom.Size = new System.Drawing.Size(92, 13);
            this.lblApNom.TabIndex = 4;
            this.lblApNom.Text = "Apellido y Nombre";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(22, 77);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblPasswd
            // 
            this.lblPasswd.AutoSize = true;
            this.lblPasswd.Location = new System.Drawing.Point(22, 103);
            this.lblPasswd.Name = "lblPasswd";
            this.lblPasswd.Size = new System.Drawing.Size(61, 13);
            this.lblPasswd.TabIndex = 6;
            this.lblPasswd.Text = "Contraseña";
            // 
            // cmbRoles
            // 
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Location = new System.Drawing.Point(119, 21);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(133, 21);
            this.cmbRoles.TabIndex = 7;
            // 
            // txtApeNom
            // 
            this.txtApeNom.Location = new System.Drawing.Point(119, 48);
            this.txtApeNom.Name = "txtApeNom";
            this.txtApeNom.Size = new System.Drawing.Size(133, 20);
            this.txtApeNom.TabIndex = 8;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(119, 74);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(133, 20);
            this.txtUsuario.TabIndex = 9;
            // 
            // txtPasswd
            // 
            this.txtPasswd.Location = new System.Drawing.Point(119, 100);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.Size = new System.Drawing.Size(133, 20);
            this.txtPasswd.TabIndex = 10;
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Location = new System.Drawing.Point(24, 129);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(179, 13);
            this.lblUpdate.TabIndex = 11;
            this.lblUpdate.Text = "Nombre a Actualizar (Sólo UPDATE)";
            // 
            // txtNombreBuscado
            // 
            this.txtNombreBuscado.Location = new System.Drawing.Point(27, 145);
            this.txtNombreBuscado.Name = "txtNombreBuscado";
            this.txtNombreBuscado.Size = new System.Drawing.Size(228, 20);
            this.txtNombreBuscado.TabIndex = 12;
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 355);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.groupQuery);
            this.Controls.Add(this.groupABM);
            this.Name = "FormUsuario";
            this.Text = "Gestión de Usuarios";
            this.Load += new System.EventHandler(this.FormUsuario_Load);
            this.groupABM.ResumeLayout(false);
            this.groupABM.PerformLayout();
            this.groupQuery.ResumeLayout(false);
            this.groupQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupABM;
        private System.Windows.Forms.Button btnDeleteUsr;
        private System.Windows.Forms.Button btnModifyUsr;
        private System.Windows.Forms.Button btnAddUsr;
        private System.Windows.Forms.GroupBox groupQuery;
        private System.Windows.Forms.Button btnShowUsr;
        private System.Windows.Forms.Button btnSearchUsr;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.TextBox txtPasswd;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtApeNom;
        private System.Windows.Forms.ComboBox cmbRoles;
        private System.Windows.Forms.Label lblPasswd;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblApNom;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.TextBox txtNombreBuscado;
        private System.Windows.Forms.Label lblUpdate;
    }
}