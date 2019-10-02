namespace Clase08.form
{
    partial class frmCatedra
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
            this.lboxAlumno = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCalificar = new System.Windows.Forms.Button();
            this.lboxCalificado = new System.Windows.Forms.ListBox();
            this.cboxOrden = new System.Windows.Forms.ComboBox();
            this.gboxAlumnos = new System.Windows.Forms.GroupBox();
            this.gboxAlucal = new System.Windows.Forms.GroupBox();
            this.gboxAlumnos.SuspendLayout();
            this.gboxAlucal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lboxAlumno
            // 
            this.lboxAlumno.FormattingEnabled = true;
            this.lboxAlumno.Location = new System.Drawing.Point(12, 19);
            this.lboxAlumno.Name = "lboxAlumno";
            this.lboxAlumno.Size = new System.Drawing.Size(433, 173);
            this.lboxAlumno.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 200);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(135, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(163, 200);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(135, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCalificar
            // 
            this.btnCalificar.Location = new System.Drawing.Point(310, 200);
            this.btnCalificar.Name = "btnCalificar";
            this.btnCalificar.Size = new System.Drawing.Size(135, 23);
            this.btnCalificar.TabIndex = 3;
            this.btnCalificar.Text = "Calificar";
            this.btnCalificar.UseVisualStyleBackColor = true;
            this.btnCalificar.Click += new System.EventHandler(this.btnCalificar_Click);
            // 
            // lboxCalificado
            // 
            this.lboxCalificado.FormattingEnabled = true;
            this.lboxCalificado.Location = new System.Drawing.Point(12, 19);
            this.lboxCalificado.Name = "lboxCalificado";
            this.lboxCalificado.Size = new System.Drawing.Size(433, 134);
            this.lboxCalificado.TabIndex = 4;
            // 
            // cboxOrden
            // 
            this.cboxOrden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxOrden.FormattingEnabled = true;
            this.cboxOrden.Location = new System.Drawing.Point(12, 227);
            this.cboxOrden.Name = "cboxOrden";
            this.cboxOrden.Size = new System.Drawing.Size(433, 21);
            this.cboxOrden.TabIndex = 5;
            this.cboxOrden.SelectedIndexChanged += new System.EventHandler(this.cboxOrden_SelectedIndexChanged);
            // 
            // gboxAlumnos
            // 
            this.gboxAlumnos.Controls.Add(this.lboxAlumno);
            this.gboxAlumnos.Controls.Add(this.btnAgregar);
            this.gboxAlumnos.Controls.Add(this.cboxOrden);
            this.gboxAlumnos.Controls.Add(this.btnModificar);
            this.gboxAlumnos.Controls.Add(this.btnCalificar);
            this.gboxAlumnos.Location = new System.Drawing.Point(12, 12);
            this.gboxAlumnos.Name = "gboxAlumnos";
            this.gboxAlumnos.Size = new System.Drawing.Size(451, 258);
            this.gboxAlumnos.TabIndex = 6;
            this.gboxAlumnos.TabStop = false;
            this.gboxAlumnos.Text = "Alumnos";
            // 
            // gboxAlucal
            // 
            this.gboxAlucal.Controls.Add(this.lboxCalificado);
            this.gboxAlucal.Location = new System.Drawing.Point(12, 276);
            this.gboxAlucal.Name = "gboxAlucal";
            this.gboxAlucal.Size = new System.Drawing.Size(451, 164);
            this.gboxAlucal.TabIndex = 0;
            this.gboxAlucal.TabStop = false;
            this.gboxAlucal.Text = "Alumnos Calificados";
            // 
            // frmCatedra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 452);
            this.Controls.Add(this.gboxAlucal);
            this.Controls.Add(this.gboxAlumnos);
            this.MaximizeBox = false;
            this.Name = "frmCatedra";
            this.ShowIcon = false;
            this.Text = "Catedra";
            this.Load += new System.EventHandler(this.frmCatedra_Load);
            this.gboxAlumnos.ResumeLayout(false);
            this.gboxAlucal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lboxAlumno;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCalificar;
        private System.Windows.Forms.ListBox lboxCalificado;
        private System.Windows.Forms.ComboBox cboxOrden;
        private System.Windows.Forms.GroupBox gboxAlumnos;
        private System.Windows.Forms.GroupBox gboxAlucal;
    }
}