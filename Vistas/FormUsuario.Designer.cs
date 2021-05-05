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
            this.lblRol = new System.Windows.Forms.Label();
            this.lblApNom = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPasswd = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupABM.SuspendLayout();
            this.groupQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenciaDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenciaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupABM
            // 
            this.groupABM.Controls.Add(this.textBox3);
            this.groupABM.Controls.Add(this.textBox2);
            this.groupABM.Controls.Add(this.textBox1);
            this.groupABM.Controls.Add(this.comboBox1);
            this.groupABM.Controls.Add(this.lblPasswd);
            this.groupABM.Controls.Add(this.lblUsuario);
            this.groupABM.Controls.Add(this.lblApNom);
            this.groupABM.Controls.Add(this.lblRol);
            this.groupABM.Controls.Add(this.btnDeleteUsr);
            this.groupABM.Controls.Add(this.btnModifyUsr);
            this.groupABM.Controls.Add(this.btnAddUsr);
            this.groupABM.Location = new System.Drawing.Point(12, 12);
            this.groupABM.Name = "groupABM";
            this.groupABM.Size = new System.Drawing.Size(280, 176);
            this.groupABM.TabIndex = 0;
            this.groupABM.TabStop = false;
            this.groupABM.Text = "ABM";
            // 
            // btnDeleteUsr
            // 
            this.btnDeleteUsr.ForeColor = System.Drawing.Color.Firebrick;
            this.btnDeleteUsr.Location = new System.Drawing.Point(181, 140);
            this.btnDeleteUsr.Name = "btnDeleteUsr";
            this.btnDeleteUsr.Size = new System.Drawing.Size(72, 23);
            this.btnDeleteUsr.TabIndex = 2;
            this.btnDeleteUsr.Text = "Eliminar";
            this.btnDeleteUsr.UseVisualStyleBackColor = true;
            // 
            // btnModifyUsr
            // 
            this.btnModifyUsr.Location = new System.Drawing.Point(103, 140);
            this.btnModifyUsr.Name = "btnModifyUsr";
            this.btnModifyUsr.Size = new System.Drawing.Size(72, 23);
            this.btnModifyUsr.TabIndex = 1;
            this.btnModifyUsr.Text = "Actualizar";
            this.btnModifyUsr.UseVisualStyleBackColor = true;
            this.btnModifyUsr.Click += new System.EventHandler(this.btnModifyUsr_Click);
            // 
            // btnAddUsr
            // 
            this.btnAddUsr.Location = new System.Drawing.Point(25, 140);
            this.btnAddUsr.Name = "btnAddUsr";
            this.btnAddUsr.Size = new System.Drawing.Size(72, 23);
            this.btnAddUsr.TabIndex = 0;
            this.btnAddUsr.Text = "Agregar";
            this.btnAddUsr.UseVisualStyleBackColor = true;
            // 
            // groupQuery
            // 
            this.groupQuery.Controls.Add(this.txtSearch);
            this.groupQuery.Controls.Add(this.btnShowUsr);
            this.groupQuery.Controls.Add(this.btnSearchUsr);
            this.groupQuery.Location = new System.Drawing.Point(19, 194);
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
            this.btnSearchUsr.Text = "Buscar Usuario";
            this.btnSearchUsr.UseVisualStyleBackColor = true;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToOrderColumns = true;
            this.dgvUsers.AutoGenerateColumns = false;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.DataSource = this.agenciaDataSet1BindingSource;
            this.dgvUsers.Location = new System.Drawing.Point(329, 17);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(514, 282);
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
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(21, 24);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(23, 13);
            this.lblRol.TabIndex = 3;
            this.lblRol.Text = "Rol";
            // 
            // lblApNom
            // 
            this.lblApNom.AutoSize = true;
            this.lblApNom.Location = new System.Drawing.Point(21, 51);
            this.lblApNom.Name = "lblApNom";
            this.lblApNom.Size = new System.Drawing.Size(92, 13);
            this.lblApNom.TabIndex = 4;
            this.lblApNom.Text = "Apellido y Nombre";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(21, 77);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblPasswd
            // 
            this.lblPasswd.AutoSize = true;
            this.lblPasswd.Location = new System.Drawing.Point(21, 103);
            this.lblPasswd.Name = "lblPasswd";
            this.lblPasswd.Size = new System.Drawing.Size(61, 13);
            this.lblPasswd.TabIndex = 6;
            this.lblPasswd.Text = "Contraseña";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(119, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(119, 100);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(133, 20);
            this.textBox3.TabIndex = 10;
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 316);
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
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblPasswd;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblApNom;
        private System.Windows.Forms.Label lblRol;
    }
}