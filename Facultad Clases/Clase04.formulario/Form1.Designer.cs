namespace Clase04.formulario
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
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.txtEntero = new System.Windows.Forms.TextBox();
            this.lbl_entero = new System.Windows.Forms.Label();
            this.lbl_cadena = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.lstCosas = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnRojo = new System.Windows.Forms.Button();
            this.btnNegro = new System.Windows.Forms.Button();
            this.btnAzul = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(113, 64);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(255, 20);
            this.txtFecha.TabIndex = 0;
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(113, 38);
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(255, 20);
            this.txtCadena.TabIndex = 1;
            // 
            // txtEntero
            // 
            this.txtEntero.Location = new System.Drawing.Point(113, 12);
            this.txtEntero.Name = "txtEntero";
            this.txtEntero.Size = new System.Drawing.Size(255, 20);
            this.txtEntero.TabIndex = 2;
            // 
            // lbl_entero
            // 
            this.lbl_entero.AutoSize = true;
            this.lbl_entero.Location = new System.Drawing.Point(12, 15);
            this.lbl_entero.Name = "lbl_entero";
            this.lbl_entero.Size = new System.Drawing.Size(41, 13);
            this.lbl_entero.TabIndex = 3;
            this.lbl_entero.Text = "Entero:";
            // 
            // lbl_cadena
            // 
            this.lbl_cadena.AutoSize = true;
            this.lbl_cadena.Location = new System.Drawing.Point(12, 41);
            this.lbl_cadena.Name = "lbl_cadena";
            this.lbl_cadena.Size = new System.Drawing.Size(47, 13);
            this.lbl_cadena.TabIndex = 4;
            this.lbl_cadena.Text = "Cadena:";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Location = new System.Drawing.Point(12, 67);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(40, 13);
            this.lbl_fecha.TabIndex = 5;
            this.lbl_fecha.Text = "Fecha:";
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(15, 232);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(106, 53);
            this.btnCrear.TabIndex = 6;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // lstCosas
            // 
            this.lstCosas.FormattingEnabled = true;
            this.lstCosas.Location = new System.Drawing.Point(15, 90);
            this.lstCosas.Name = "lstCosas";
            this.lstCosas.Size = new System.Drawing.Size(353, 134);
            this.lstCosas.TabIndex = 7;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 299);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(384, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sslStatus
            // 
            this.sslStatus.Name = "sslStatus";
            this.sslStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // btnRojo
            // 
            this.btnRojo.Location = new System.Drawing.Point(6, 19);
            this.btnRojo.Name = "btnRojo";
            this.btnRojo.Size = new System.Drawing.Size(60, 23);
            this.btnRojo.TabIndex = 9;
            this.btnRojo.Text = "Rojo";
            this.btnRojo.UseVisualStyleBackColor = true;
            this.btnRojo.Click += new System.EventHandler(this.btnRojo_Click);
            // 
            // btnNegro
            // 
            this.btnNegro.Location = new System.Drawing.Point(95, 19);
            this.btnNegro.Name = "btnNegro";
            this.btnNegro.Size = new System.Drawing.Size(53, 23);
            this.btnNegro.TabIndex = 10;
            this.btnNegro.Text = "Negro";
            this.btnNegro.UseVisualStyleBackColor = true;
            this.btnNegro.Click += new System.EventHandler(this.btnNegro_Click);
            // 
            // btnAzul
            // 
            this.btnAzul.Location = new System.Drawing.Point(181, 19);
            this.btnAzul.Name = "btnAzul";
            this.btnAzul.Size = new System.Drawing.Size(54, 23);
            this.btnAzul.TabIndex = 11;
            this.btnAzul.Text = "Azul";
            this.btnAzul.UseVisualStyleBackColor = true;
            this.btnAzul.Click += new System.EventHandler(this.btnAzul_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAzul);
            this.groupBox1.Controls.Add(this.btnNegro);
            this.groupBox1.Controls.Add(this.btnRojo);
            this.groupBox1.Location = new System.Drawing.Point(127, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 53);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Background color";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 321);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lstCosas);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.lbl_cadena);
            this.Controls.Add(this.lbl_entero);
            this.Controls.Add(this.txtEntero);
            this.Controls.Add(this.txtCadena);
            this.Controls.Add(this.txtFecha);
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtCadena;
        private System.Windows.Forms.TextBox txtEntero;
        private System.Windows.Forms.Label lbl_entero;
        private System.Windows.Forms.Label lbl_cadena;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.ListBox lstCosas;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sslStatus;
        private System.Windows.Forms.Button btnRojo;
        private System.Windows.Forms.Button btnNegro;
        private System.Windows.Forms.Button btnAzul;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

