﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LogicaNegocios;
using System.Globalization;
using System.Xml;
namespace Presentacion
{
    public partial class AltaReserva : Form,IClienteRe
    {
        private int _liide, _cliide, _alta;
        string _codigo, _titulo, _autor, _editorial,_precio, _barra;
        public AltaReserva()
        {
            InitializeComponent();
            this.inicio();
        }

        public void inicio()
        {

           // lookUpEdit1.Properties.Columns[0].Visible = false;
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (Alta == 1)
            {
                if (this.Cliide == 0)
                {
                    MessageBox.Show("Debe seleccionar un cliente!");
                }
                else
                {
                    this.altaReserva();
                }

           }


        }

        private void altaReserva()
        {
            Reservas re = new Reservas();
            re.Cliide = this.Cliide;
            re.Clitelefono = txttelefono.Text;
            re.Codigolibro = txtcodigo.Text;
            re.Desc = txttitulo.Text;
            re.Autor = txtautor.Text;
            re.Editorial = txteditorial.Text;
            txtprecio.Text = txtprecio.Text.Replace(",", ".");
            re.Precio = txtprecio.Text;
            re.Cantidad = Convert.ToInt32(txtcantidad.Text);

            int retorno = re.spInsertarReserva1();
            //int retorno = pro.spInsertarProducto();
            
            if (retorno == 0)
            {

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                MessageBox.Show("Se ha dado de alta con éxito!");
            }
            else
            {
                MessageBox.Show("Hubo un problema, por favor intentelo de nuevo.");
            }
        }


        

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }
           
       

        private void rbartesco_CheckedChanged(object sender, EventArgs e)
        {
      
        }

        private void rbmarro_CheckedChanged(object sender, EventArgs e)
        {
       

        }

        private void rbdida_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void AltaProducto_Load(object sender, EventArgs e)
        {

        }

        private void txttitulo_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txteditorial.Focus();
            }
        }

        private void txtautor_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
        }

        private void txtprecio_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
          
        }

        private void txtcantidad_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
           
        }

        private void txtfactura_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
           
        }

        private void txtisbn_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {

        }

        private void txtcuerpo_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {

        }

        private void txtestante_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {

        }

        

        private void txtcosto_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            
        }

        private void txtiva_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
           
        }

        private void txtporcentaje_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
           
        }

        

        private void lUporcentaje_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
          
        }

        private void lUporcentaje_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void rblibro_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        public int Alta
        {
            get { return this._alta; }
            set { this._alta = value; }
        }

        public int Liide
        {
            get { return this._liide; }
            set { this._liide = value; }
        }

        public int Cliide
        {
            get { return this._cliide; }
            set { this._cliide = value; }
        }

        public String Codigo
        {
            get { return this._codigo; }
            set { this._codigo = value; }
        }

        public String Titulo
        {
            get { return this._titulo; }
            set { this._titulo = value; }
        }

        public String Autor
        {
            get { return this._autor; }
            set { this._autor = value; }
        }

        public String Editorial
        {
            get { return this._editorial; }
            set { this._editorial = value; }
        }

        public String Barra
        {
            get { return this._barra; }
            set { this._barra = value; }
        }

        private void btnnoaparececatalogo_Click(object sender, EventArgs e)
        {

            txtbarra.Text = string.Empty;
            txtbarra.Enabled = true;
            txtcodigo.Text = string.Empty;
           // txtcodigo.Enabled = true;
            txttitulo.Text = string.Empty;
            txttitulo.Enabled = true;
            txtautor.Text = string.Empty;
            txtautor.Enabled = true;
            txteditorial.Text = string.Empty;
            txteditorial.Enabled = true;
            txtprecio.Text = string.Empty;
            txtprecio.Enabled = true;
        }

        public String Precio
        {
            get { return this._precio; }
            set { this._precio = value; }
        }

        public void colocarDatos()
        {

            txtcodigo.Text = this.Codigo;
            txttitulo.Text = this.Titulo;
            txtautor.Text = this.Autor;
            txteditorial.Text = this.Editorial;
            txtprecio.Text = this.Precio;
            txtbarra.Text = this.Barra;

        }
        private void btnbuscacli_Click(object sender, EventArgs e)
        {

        }

        private void txtcliente_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ConsultaClienteLi ccl = new ConsultaClienteLi();
                ccl.Nombre = txtcliente.Text;
                ccl.Entranombre = 1;
                ccl.inicio();
                ccl.ShowDialog(this); 
            }
        }

        private void txttelefono_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ConsultaClienteLi ccl = new ConsultaClienteLi();
                ccl.Telefono = txttelefono.Text;
                ccl.Entranombre = 0;
                ccl.inicio();
                ccl.ShowDialog(this);
            }
        }

        private void txttitulo_DoubleClick(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ConsultaProductosAgregaRe cpa = new ConsultaProductosAgregaRe();
                cpa.Show();
            }
        }

        public void agregacliente(int cliide, string clinombre, string clitelefono)
        {
            this.Cliide = cliide;
            this.txtcliente.Text = clinombre;
            this.txttelefono.Text = clitelefono;

        }
    }
}
