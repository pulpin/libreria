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
    public partial class AltaPedido : Form
    {
        private int _alta, _situacion, _clienteide, _tipo, _usuide,_numero, _ide, _cantidad, _pedidos;
        private string _producto, _cuit, _razonsocial, _domicilio, _telefono, _codigoviejo;
        private string _nombre, _nombrecompleto, _contra, _contravta;
        string _titulo, _calle, _localidad, _provincia, _cliente,_precio;
        public AltaPedido()
        {
            InitializeComponent();
            this.inicio();
        }

        public void inicio()
        {
          /*  Clientes cli = new Clientes();

            lookUpEdit1.Properties.DisplayMember = "TIPI_DESC";
            lookUpEdit1.Properties.ValueMember = "TIPI_IDE";
            lookUpEdit1.Properties.DataSource = cli.Tabladedatos_situacion();
            lookUpEdit1.Properties.PopulateColumns();
            */
            
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (this.Alta == 1)
            {
                
                this.Altapedido();
            }
            else
            {
                this.Modificarpedido();
            }
        }


        public void colocarnombre()
        {
            lbtitulo.Text = this.Producto;
        }
        public void colocarcantidad()
        {
            txtprecio.Text = Convert.ToString(this.Cantidad);
        }
        private void Altapedido()
        {
            Productos pro = new Productos();
            //ta. = txtprecio.Text;
            pro.Cantidad = Convert.ToInt32(txtprecio.Text);
            pro.productoide = this.Ide;
            pro.Codigo = this.CodigoViejo;
            pro.pedidos = this.Pedidos;
            pro.Alta = 1;
            int resultado = pro.spInsertarPedido();
            if (resultado == 0)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                MessageBox.Show("Se ha agregado al pedido!");
            }
            else
            {
                MessageBox.Show("Se ha producido un error!");
            }
        }

        private void Modificarpedido()
        {
            Productos pro = new Productos();
            //ta. = txtprecio.Text;
            pro.Cantidad = Convert.ToInt32(txtprecio.Text);
            pro.productoide = this.Ide;
            pro.Codigo = this.CodigoViejo;
            pro.pedidos = this.Pedidos;
            pro.Alta = 0;
            int resultado = pro.spInsertarPedido();
            if (resultado == 0)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                MessageBox.Show("Se ha guardado el pedido!");
            }
            else
            {
                MessageBox.Show("Se ha producido un error!");
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
           
            //dateEnvio.EditValue = DateTime.Today;
        }

        private void txttitulo_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
            }
        }

        private void txtautor_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
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

        private void txtbarra_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
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

        public int Usuide
        {
            get { return this._usuide; }
            set { this._usuide = value; }
        }

        public int Alta
        {
            get { return this._alta; }
            set { this._alta = value; }
        }

        public string Producto
        {
            get { return this._producto; }
            set { this._producto = value; }
        }

        public string Cuit
        {
            get { return this._cuit; }
            set { this._cuit = value; }
        }
        public string Razonsocial
        {
            get { return this._razonsocial; }
            set { this._razonsocial = value; }
        }
        public string Domicilio
        {
            get { return this._domicilio; }
            set { this._domicilio = value; }
        }
        public string Telefono
        {
            get { return this._telefono; }
            set { this._telefono = value; }
        }
        public int Situacion
        {
            get { return this._situacion; }
            set { this._situacion = value; }
        }
        public int Clienteide
        {
            get { return this._clienteide; }
            set { this._clienteide = value; }
        }
        
        private void btnsubir_Click(object sender, EventArgs e)
        { }

        public string CodigoViejo
        {
            get { return this._codigoviejo; }
            set { this._codigoviejo = value; }
        }

        public int Ide
        {
            get { return this._ide; }
            set { this._ide = value; }
        }

        public int Cantidad
        {
            get { return this._cantidad; }
            set { this._cantidad = value; }
        }

        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

        public string NombreCompleto
        {
            get { return this._nombrecompleto; }
            set { this._nombrecompleto = value; }
        }

        public string Contrase
        {
            get { return this._contra; }
            set { this._contra = value; }
        }

        public string Contrasevta
        {
            get { return this._contravta; }
            set { this._contravta = value; }
        }
        public int Tipo
        {
            get { return this._tipo; }
            set { this._tipo = value; }
        }

        public string Titulo
        {
            get { return this._titulo; }
            set { this._titulo = value; }
        }
        public string Calle
        {
            get { return this._calle; }
            set { this._calle = value; }
        }
        public int Numero
        {
            get { return this._numero; }
            set { this._numero = value; }
        }
        public int Pedidos
        {
            get { return this._pedidos; }
            set { this._pedidos = value; }
        }

        public string Localidad
        {
            get { return this._localidad; }
            set { this._localidad = value; }
        }
        public string Provincia
        {
            get { return this._provincia; }
            set { this._provincia = value; }
        }

        public string Cliente
        {
            get { return this._cliente; }
            set { this._cliente = value; }
        }
        public string Precio
        {
            get { return this._precio; }
            set { this._precio = value; }
        }
    }
}
