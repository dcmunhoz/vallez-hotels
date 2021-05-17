﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VallezHotels.Source.Core;

namespace VallezHotels
{
    public partial class FrmListagemHospedes : Form
    {

        public FrmListagemHospedes()
        {
            InitializeComponent();
        }

        private void btnNovoHospede_Click(object sender, EventArgs e)
        {

            FrmHospede hospede = new FrmHospede();
            Helper.StartForm(hospede, null);
        }
    }
}