﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocios;

namespace Presentacion
{
    public partial class CambiarPorcentaje : Form
    {
        public CambiarPorcentaje()
        {
            InitializeComponent();
            iniciar();
        }
        private void iniciar()
        {

            CheckForIllegalCrossThreadCalls = false;
            Editorial edi = new Editorial();

            lUEditorial.Properties.DisplayMember = "EDI_EDITORIAL";
            lUEditorial.Properties.ValueMember = "EDI_CODIGO";
            lUEditorial.Properties.DataSource = edi.Tabladedatos_editoriales();
            lUEditorial.Properties.PopulateColumns();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lUEditorial.EditValue) > 0)
            { 
            txtporcentaje.Text = txtporcentaje.Text.Replace(",", ".");
            Productos pro = new Productos();
            pro.Editorial = Convert.ToInt32(lUEditorial.EditValue);
            pro.Ganancia = txtporcentaje.Text;
            int valor = pro.spModificarPorcentajeEdi();
            if (valor == 0)
            {
                MessageBox.Show("Se ha modificado el porcentaje con éxito");
                    this.Dispose();
                    this.Hide();
                }
            else
            {
                MessageBox.Show("Hubo un error");
            }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una editorial");
            }
        }

        private void Elegirpto_Load(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }
    }
}
