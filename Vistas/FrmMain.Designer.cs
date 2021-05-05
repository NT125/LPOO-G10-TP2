namespace Vistas
{
    partial class FrmMain
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
            this.btnExit = new System.Windows.Forms.Button();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edificiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirEdificioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inquilinosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirInquilinoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarDepartamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alquilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(402, 55);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 24);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarUsuarioToolStripMenuItem,
            this.toolStripMenuItem1,
            this.salirDelSistemaToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // agregarUsuarioToolStripMenuItem
            // 
            this.agregarUsuarioToolStripMenuItem.Name = "agregarUsuarioToolStripMenuItem";
            this.agregarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.agregarUsuarioToolStripMenuItem.Text = "Gestionar Usuarios";
            this.agregarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.agregarUsuarioToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(169, 6);
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            this.salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            this.salirDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.salirDelSistemaToolStripMenuItem.Text = "Salir del Sistema";
            // 
            // edificiosToolStripMenuItem
            // 
            this.edificiosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirEdificioToolStripMenuItem});
            this.edificiosToolStripMenuItem.Name = "edificiosToolStripMenuItem";
            this.edificiosToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.edificiosToolStripMenuItem.Text = "Edificios";
            // 
            // añadirEdificioToolStripMenuItem
            // 
            this.añadirEdificioToolStripMenuItem.Name = "añadirEdificioToolStripMenuItem";
            this.añadirEdificioToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.añadirEdificioToolStripMenuItem.Text = "Agregar Edificio";
            this.añadirEdificioToolStripMenuItem.Click += new System.EventHandler(this.añadirEdificioToolStripMenuItem_Click);
            // 
            // inquilinosToolStripMenuItem
            // 
            this.inquilinosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirInquilinoToolStripMenuItem});
            this.inquilinosToolStripMenuItem.Name = "inquilinosToolStripMenuItem";
            this.inquilinosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.inquilinosToolStripMenuItem.Text = "Inquilinos";
            // 
            // añadirInquilinoToolStripMenuItem
            // 
            this.añadirInquilinoToolStripMenuItem.Name = "añadirInquilinoToolStripMenuItem";
            this.añadirInquilinoToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.añadirInquilinoToolStripMenuItem.Text = "Agregar Inquilino";
            this.añadirInquilinoToolStripMenuItem.Click += new System.EventHandler(this.añadirInquilinoToolStripMenuItem_Click);
            // 
            // departamentosToolStripMenuItem
            // 
            this.departamentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarDepartamentoToolStripMenuItem});
            this.departamentosToolStripMenuItem.Name = "departamentosToolStripMenuItem";
            this.departamentosToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.departamentosToolStripMenuItem.Text = "Departamentos";
            // 
            // agregarDepartamentoToolStripMenuItem
            // 
            this.agregarDepartamentoToolStripMenuItem.Name = "agregarDepartamentoToolStripMenuItem";
            this.agregarDepartamentoToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.agregarDepartamentoToolStripMenuItem.Text = "Agregar Departamento";
            this.agregarDepartamentoToolStripMenuItem.Click += new System.EventHandler(this.agregarDepartamentoToolStripMenuItem_Click);
            // 
            // alquilerToolStripMenuItem
            // 
            this.alquilerToolStripMenuItem.Name = "alquilerToolStripMenuItem";
            this.alquilerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.alquilerToolStripMenuItem.Text = "Alquiler";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.edificiosToolStripMenuItem,
            this.inquilinosToolStripMenuItem,
            this.departamentosToolStripMenuItem,
            this.alquilerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(502, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 95);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Sistema Principal";
            this.Load += new System.EventHandler(this.FrmMain_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edificiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirEdificioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inquilinosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirInquilinoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarDepartamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alquilerToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirDelSistemaToolStripMenuItem;
    }
}