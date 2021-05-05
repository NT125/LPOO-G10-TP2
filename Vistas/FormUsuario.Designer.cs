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
            this.components = new System.ComponentModel.Container();
            this.groupABM = new System.Windows.Forms.GroupBox();
            this.btnDeleteUsr = new System.Windows.Forms.Button();
            this.btnModifyUsr = new System.Windows.Forms.Button();
            this.btnAddUsr = new System.Windows.Forms.Button();
            this.groupQuery = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnShowUsr = new System.Windows.Forms.Button();
            this.btnSearchUsr = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.agenciaDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agenciaDataSet1 = new Vistas.agenciaDataSet();
            this.Usu_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usu_NombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usu_Contraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usu_ApellidoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupABM.SuspendLayout();
            this.groupQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenciaDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenciaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupABM
            // 
            this.groupABM.Controls.Add(this.btnDeleteUsr);
            this.groupABM.Controls.Add(this.btnModifyUsr);
            this.groupABM.Controls.Add(this.btnAddUsr);
            this.groupABM.Location = new System.Drawing.Point(12, 12);
            this.groupABM.Name = "groupABM";
            this.groupABM.Size = new System.Drawing.Size(280, 110);
            this.groupABM.TabIndex = 0;
            this.groupABM.TabStop = false;
            this.groupABM.Text = "ABM";
            // 
            // btnDeleteUsr
            // 
            this.btnDeleteUsr.ForeColor = System.Drawing.Color.Firebrick;
            this.btnDeleteUsr.Location = new System.Drawing.Point(7, 78);
            this.btnDeleteUsr.Name = "btnDeleteUsr";
            this.btnDeleteUsr.Size = new System.Drawing.Size(267, 23);
            this.btnDeleteUsr.TabIndex = 2;
            this.btnDeleteUsr.Text = "Eliminar Usuario";
            this.btnDeleteUsr.UseVisualStyleBackColor = true;
            // 
            // btnModifyUsr
            // 
            this.btnModifyUsr.Location = new System.Drawing.Point(7, 49);
            this.btnModifyUsr.Name = "btnModifyUsr";
            this.btnModifyUsr.Size = new System.Drawing.Size(267, 23);
            this.btnModifyUsr.TabIndex = 1;
            this.btnModifyUsr.Text = "Actualizar Usuario";
            this.btnModifyUsr.UseVisualStyleBackColor = true;
            // 
            // btnAddUsr
            // 
            this.btnAddUsr.Location = new System.Drawing.Point(7, 20);
            this.btnAddUsr.Name = "btnAddUsr";
            this.btnAddUsr.Size = new System.Drawing.Size(267, 23);
            this.btnAddUsr.TabIndex = 0;
            this.btnAddUsr.Text = "Agregar Usuario";
            this.btnAddUsr.UseVisualStyleBackColor = true;
            // 
            // groupQuery
            // 
            this.groupQuery.Controls.Add(this.txtSearch);
            this.groupQuery.Controls.Add(this.btnShowUsr);
            this.groupQuery.Controls.Add(this.btnSearchUsr);
            this.groupQuery.Location = new System.Drawing.Point(13, 144);
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
            // 
            // btnSearchUsr
            // 
            this.btnSearchUsr.Location = new System.Drawing.Point(7, 53);
            this.btnSearchUsr.Name = "btnSearchUsr";
            this.btnSearchUsr.Size = new System.Drawing.Size(260, 23);
            this.btnSearchUsr.TabIndex = 0;
            this.btnSearchUsr.Text = "Buscar Usuarios";
            this.btnSearchUsr.UseVisualStyleBackColor = true;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToOrderColumns = true;
            this.dgvUsers.AutoGenerateColumns = false;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Usu_ID,
            this.Usu_NombreUsuario,
            this.Usu_Contraseña,
            this.Usu_ApellidoNombre,
            this.Rol_Codigo});
            this.dgvUsers.DataSource = this.agenciaDataSet1BindingSource;
            this.dgvUsers.Location = new System.Drawing.Point(329, 32);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(547, 217);
            this.dgvUsers.TabIndex = 2;
            this.dgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // agenciaDataSet1BindingSource
            // 
            this.agenciaDataSet1BindingSource.DataSource = this.agenciaDataSet1;
            this.agenciaDataSet1BindingSource.Position = 0;
            // 
            // agenciaDataSet1
            // 
            this.agenciaDataSet1.DataSetName = "agenciaDataSet";
            this.agenciaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Usu_ID
            // 
            this.Usu_ID.HeaderText = "ID";
            this.Usu_ID.Name = "Usu_ID";
            this.Usu_ID.ReadOnly = true;
            // 
            // Usu_NombreUsuario
            // 
            this.Usu_NombreUsuario.HeaderText = "Usuario";
            this.Usu_NombreUsuario.Name = "Usu_NombreUsuario";
            // 
            // Usu_Contraseña
            // 
            this.Usu_Contraseña.HeaderText = "Contraseña";
            this.Usu_Contraseña.Name = "Usu_Contraseña";
            // 
            // Usu_ApellidoNombre
            // 
            this.Usu_ApellidoNombre.HeaderText = "Nombre y Apellido";
            this.Usu_ApellidoNombre.Name = "Usu_ApellidoNombre";
            // 
            // Rol_Codigo
            // 
            this.Rol_Codigo.HeaderText = "Rol";
            this.Rol_Codigo.Name = "Rol_Codigo";
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 267);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.groupQuery);
            this.Controls.Add(this.groupABM);
            this.Name = "FormUsuario";
            this.Text = "Gestión de Usuarios";
            this.Load += new System.EventHandler(this.FormUsuario_Load);
            this.groupABM.ResumeLayout(false);
            this.groupQuery.ResumeLayout(false);
            this.groupQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenciaDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenciaDataSet1)).EndInit();
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
        private System.Windows.Forms.BindingSource agenciaDataSet1BindingSource;
        private agenciaDataSet agenciaDataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usu_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usu_NombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usu_Contraseña;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usu_ApellidoNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol_Codigo;
    }
}