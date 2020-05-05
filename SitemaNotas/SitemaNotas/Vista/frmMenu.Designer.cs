namespace SitemaNotas.Vista
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoDeEstudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoDeNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDeMateriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarNotasDeEstudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.ingresoDeEstudiantesToolStripMenuItem,
            this.materiasToolStripMenuItem,
            this.ingresoDeNotasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // ingresoDeEstudiantesToolStripMenuItem
            // 
            this.ingresoDeEstudiantesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosToolStripMenuItem});
            this.ingresoDeEstudiantesToolStripMenuItem.Name = "ingresoDeEstudiantesToolStripMenuItem";
            this.ingresoDeEstudiantesToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.ingresoDeEstudiantesToolStripMenuItem.Text = "Ingreso de Estudiantes";
            // 
            // materiasToolStripMenuItem
            // 
            this.materiasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoDeMateriasToolStripMenuItem});
            this.materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
            this.materiasToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.materiasToolStripMenuItem.Text = "Materias";
            // 
            // ingresoDeNotasToolStripMenuItem
            // 
            this.ingresoDeNotasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarNotasDeEstudiantesToolStripMenuItem});
            this.ingresoDeNotasToolStripMenuItem.Name = "ingresoDeNotasToolStripMenuItem";
            this.ingresoDeNotasToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.ingresoDeNotasToolStripMenuItem.Text = "Ingreso de Notas";
            // 
            // datosToolStripMenuItem
            // 
            this.datosToolStripMenuItem.Name = "datosToolStripMenuItem";
            this.datosToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.datosToolStripMenuItem.Text = "Datos De Estudiantes";
            this.datosToolStripMenuItem.Click += new System.EventHandler(this.datosToolStripMenuItem_Click);
            // 
            // mantenimientoDeMateriasToolStripMenuItem
            // 
            this.mantenimientoDeMateriasToolStripMenuItem.Name = "mantenimientoDeMateriasToolStripMenuItem";
            this.mantenimientoDeMateriasToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.mantenimientoDeMateriasToolStripMenuItem.Text = "Mantenimiento De Materias";
            this.mantenimientoDeMateriasToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoDeMateriasToolStripMenuItem_Click);
            // 
            // ingresarNotasDeEstudiantesToolStripMenuItem
            // 
            this.ingresarNotasDeEstudiantesToolStripMenuItem.Name = "ingresarNotasDeEstudiantesToolStripMenuItem";
            this.ingresarNotasDeEstudiantesToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.ingresarNotasDeEstudiantesToolStripMenuItem.Text = "Ingresar Notas de Estudiantes";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 281);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ingresoDeEstudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDeMateriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoDeNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarNotasDeEstudiantesToolStripMenuItem;
    }
}