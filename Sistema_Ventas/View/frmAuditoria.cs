﻿using Sistema_Ventas.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntodeVenta.View
{
    public partial class frmAuditoria: Form
    {
        public frmAuditoria(Form parent)
        {
            InitializeComponent();
            Formas.InicializarForma(this, parent);
        }
    }
}
