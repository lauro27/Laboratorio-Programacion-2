namespace Clase09.formulario
{
    partial class frmCentral
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
            this.lboxLlamadas = new System.Windows.Forms.ListBox();
            this.cboxOrden = new System.Windows.Forms.ComboBox();
            this.btnLocal = new System.Windows.Forms.Button();
            this.btnAgregarProvincial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lboxLlamadas
            // 
            this.lboxLlamadas.FormattingEnabled = true;
            this.lboxLlamadas.Location = new System.Drawing.Point(12, 12);
            this.lboxLlamadas.Name = "lboxLlamadas";
            this.lboxLlamadas.Size = new System.Drawing.Size(679, 238);
            this.lboxLlamadas.TabIndex = 0;
            // 
            // cboxOrden
            // 
            this.cboxOrden.FormattingEnabled = true;
            this.cboxOrden.Location = new System.Drawing.Point(467, 256);
            this.cboxOrden.Name = "cboxOrden";
            this.cboxOrden.Size = new System.Drawing.Size(224, 21);
            this.cboxOrden.TabIndex = 1;
            // 
            // btnLocal
            // 
            this.btnLocal.Location = new System.Drawing.Point(12, 256);
            this.btnLocal.Name = "btnLocal";
            this.btnLocal.Size = new System.Drawing.Size(197, 23);
            this.btnLocal.TabIndex = 2;
            this.btnLocal.Text = "Agregar llamada Local";
            this.btnLocal.UseVisualStyleBackColor = true;
            // 
            // btnAgregarProvincial
            // 
            this.btnAgregarProvincial.Location = new System.Drawing.Point(215, 256);
            this.btnAgregarProvincial.Name = "btnAgregarProvincial";
            this.btnAgregarProvincial.Size = new System.Drawing.Size(246, 23);
            this.btnAgregarProvincial.TabIndex = 3;
            this.btnAgregarProvincial.Text = "Agregar Llamada Provincial";
            this.btnAgregarProvincial.UseVisualStyleBackColor = true;
            // 
            // frmCentral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 287);
            this.Controls.Add(this.btnAgregarProvincial);
            this.Controls.Add(this.btnLocal);
            this.Controls.Add(this.cboxOrden);
            this.Controls.Add(this.lboxLlamadas);
            this.Name = "frmCentral";
            this.Text = "frmCentral";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lboxLlamadas;
        private System.Windows.Forms.ComboBox cboxOrden;
        private System.Windows.Forms.Button btnLocal;
        private System.Windows.Forms.Button btnAgregarProvincial;
    }
}