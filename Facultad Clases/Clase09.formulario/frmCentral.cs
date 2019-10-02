﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaPolimorfismo;

namespace Clase09.formulario
{
    public partial class frmCentral : Form
    {
        Centralita centralita;
        public frmCentral()
        {
            InitializeComponent();
            centralita = new Centralita();
        }



        private void actualizarLista()
        {
            lboxLlamadas.Items.Clear();
            foreach (Llamada llamada in this.centralita.Llamadas)
            {
                lboxLlamadas.Items.Add(llamada);
            }
        }
    }
}
