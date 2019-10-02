namespace Clase06
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.paletaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearPaletaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temperaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lboxTempera = new System.Windows.Forms.ListBox();
            this.gboxPaleta = new System.Windows.Forms.GroupBox();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.paletaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.gboxPaleta.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paletaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // paletaToolStripMenuItem
            // 
            this.paletaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearPaletaToolStripMenuItem});
            this.paletaToolStripMenuItem.Name = "paletaToolStripMenuItem";
            this.paletaToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.paletaToolStripMenuItem.Text = "Administración";
            // 
            // crearPaletaToolStripMenuItem
            // 
            this.crearPaletaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.temperaToolStripMenuItem,
            this.paletaToolStripMenuItem1});
            this.crearPaletaToolStripMenuItem.Name = "crearPaletaToolStripMenuItem";
            this.crearPaletaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.crearPaletaToolStripMenuItem.Text = "Crear paleta";
            // 
            // temperaToolStripMenuItem
            // 
            this.temperaToolStripMenuItem.Name = "temperaToolStripMenuItem";
            this.temperaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.temperaToolStripMenuItem.Text = "Tempera";
            this.temperaToolStripMenuItem.Click += new System.EventHandler(this.temperaToolStripMenuItem_Click);
            // 
            // lboxTempera
            // 
            this.lboxTempera.FormattingEnabled = true;
            this.lboxTempera.Location = new System.Drawing.Point(12, 19);
            this.lboxTempera.Name = "lboxTempera";
            this.lboxTempera.Size = new System.Drawing.Size(316, 212);
            this.lboxTempera.TabIndex = 0;
            // 
            // gboxPaleta
            // 
            this.gboxPaleta.Controls.Add(this.btnMod);
            this.gboxPaleta.Controls.Add(this.btnPlus);
            this.gboxPaleta.Controls.Add(this.btnMinus);
            this.gboxPaleta.Controls.Add(this.lboxTempera);
            this.gboxPaleta.Location = new System.Drawing.Point(0, 27);
            this.gboxPaleta.Name = "gboxPaleta";
            this.gboxPaleta.Size = new System.Drawing.Size(334, 349);
            this.gboxPaleta.TabIndex = 2;
            this.gboxPaleta.TabStop = false;
            this.gboxPaleta.Text = "Paleta";
            this.gboxPaleta.Visible = false;
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(12, 293);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(316, 50);
            this.btnMod.TabIndex = 6;
            this.btnMod.Text = "Modificar";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(12, 237);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(155, 50);
            this.btnPlus.TabIndex = 4;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(173, 237);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(155, 50);
            this.btnMinus.TabIndex = 5;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            // 
            // paletaToolStripMenuItem1
            // 
            this.paletaToolStripMenuItem1.Name = "paletaToolStripMenuItem1";
            this.paletaToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.paletaToolStripMenuItem1.Text = "Paleta";
            this.paletaToolStripMenuItem1.Click += new System.EventHandler(this.paletaToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gboxPaleta);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Paleta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gboxPaleta.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem paletaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearPaletaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temperaToolStripMenuItem;
        private System.Windows.Forms.ListBox lboxTempera;
        private System.Windows.Forms.GroupBox gboxPaleta;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.ToolStripMenuItem paletaToolStripMenuItem1;
    }
}

