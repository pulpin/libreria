﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LogicaNegocios;
using System.IO;

namespace Presentacion
{
    public partial class ConsultaProductosAgregaC : Form
    {
        Editorial edi = new Editorial();
        Productos pro = new Productos();
        Genero gen = new Genero();
        ToolTip tol = new ToolTip();
        public ConsultaProductosAgregaC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btBuscar_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txttitulo.Text == string.Empty && txtautor.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar el texto a buscar");

            }
            else
            {
                this.busquedaavanzada();
            }
        }

        private void busquedasimple()
        {
            pro.Tipo = 1;
            pro.Barra = txtbarra.Text;
            pro.Codigo = txtcodigo.Text;
            pro.Isbn = txtisbn.Text;
            gConsulta.DataSource = pro.Mostrar_productosconsigna();
            txtbarra.Text = string.Empty;
            txtcodigo.Text = string.Empty;
            txtisbn.Text = string.Empty;
        }

        private void busquedaavanzada()
        {
            pro.Tipo = 0;
            pro.Titulo = txttitulo.Text;
            pro.Editorial = Convert.ToInt32(cBEeditorial.EditValue);
            pro.Genero = Convert.ToInt32(lUEgenero.EditValue);
            if (chbpalabra.Checked == true)
            {
                pro.Contengapalabra = 1;
            }
            else
            {
                pro.Contengapalabra = 0;
            }
            pro.Autor = txtautor.Text;

            gConsulta.DataSource = pro.Mostrar_productosconsigna();
            this.limpiartextos();
        }
        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }



        private void limpiartextos()
        {
            txttitulo.Text = string.Empty;
            txtautor.Text = string.Empty;
            chbpalabra.Checked = false;
        }
        private void blimpiar_Click(object sender, EventArgs e)
        {
            this.limpiartextos();
            this.cBEeditorial.EditValue = null;
            this.lUEgenero.EditValue = null;

            this.cargarcombos();

        }

        private void cargarcombos()
        {

            cBEeditorial.Properties.DisplayMember = "EDI_EDITORIAL";
            cBEeditorial.Properties.ValueMember = "EDI_CODIGO";
            cBEeditorial.Properties.DataSource = edi.Tabladedatos_editoriales();
            cBEeditorial.Properties.PopulateColumns();
            cBEeditorial.Properties.Columns[0].Visible = false;
            // cBEeditorial.Properties.Columns[1].Visible = false;

            lUEgenero.Properties.DataSource = gen.Tabladedatos_genero();
            lUEgenero.Properties.DisplayMember = "GEN_DESC";
            lUEgenero.Properties.ValueMember = "GEN_IDE";
            lUEgenero.Properties.PopulateColumns();
            lUEgenero.Properties.Columns[0].Visible = false;
        }
        private void ConsultaProductos_Load(object sender, EventArgs e)
        {
            this.cargarcombos();
            tol.SetToolTip(this.bbuscar, "Buscar");
            tol.SetToolTip(this.blimpiar, "Limpiar todos los textos");
            tol.SetToolTip(this.btnzoom, "Ver imagen en tamaño completo");
            txtbarra.Focus();
        }

        private void textBox2_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {

        }

        private void txtbarra_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //buscar acá
                busquedasimple();
                txtbarra.Text = "";
            }
        }



        private void activartexbox(TextBox texboxentrada)
        {
            texboxentrada.BackColor = SystemColors.InactiveBorder;
        }
        private void desactivartexbox(TextBox texboxentrada)
        {
            texboxentrada.BackColor = Color.White;
        }

        private void txttitulo_Enter(object sender, EventArgs e)
        {
            this.activartexbox(txttitulo);
        }

        private void txttitulo_Leave(object sender, EventArgs e)
        {
            this.desactivartexbox(txttitulo);
        }
        private void txtautor_Enter(object sender, EventArgs e)
        {
            this.activartexbox(txtautor);
        }

        private void txtautor_Leave(object sender, EventArgs e)
        {
            this.desactivartexbox(txtautor);
        }

        private void txtbarra_Enter(object sender, EventArgs e)
        {
            this.activartexbox(txtbarra);
        }

        private void txtbarra_Leave(object sender, EventArgs e)
        {
            this.desactivartexbox(txtbarra);
        }

        private void txtisbn_Enter(object sender, EventArgs e)
        {
            this.activartexbox(txtisbn);
        }

        private void txtisbn_Leave(object sender, EventArgs e)
        {
            this.desactivartexbox(txtisbn);
        }

        private void txtcodigo_Enter(object sender, EventArgs e)
        {
            this.activartexbox(txtcodigo);
        }

        private void txtcodigo_Leave(object sender, EventArgs e)
        {
            this.desactivartexbox(txtcodigo);
        }

        private void txttitulo_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //buscar acá
                this.busquedaavanzada();

            }
        }

        private void txtautor_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //buscar acá
                this.busquedaavanzada();

            }
        }

        private void cargardatos()
        {
            lbtitulo.Text = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_DESC"]));
            lbprecio.Text = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_PRECIO"]));
            int stock = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_STOCK"]));
            if (stock > 0 && stock < 5)
            {
                pbcirculo.Image = Presentacion.Properties.Resources.circuloamarillo30;
            }
            else if (stock < 1)
            {
                pbcirculo.Image = Presentacion.Properties.Resources.circulorojo30;
            }
            else
            {
                pbcirculo.Image = Presentacion.Properties.Resources.circuloverde30;
            }
            lbstock.Text = Convert.ToString(stock);
            string imagen = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_IMAGEN"]));
            string path = Directory.GetCurrentDirectory();
            if (imagen != string.Empty)
            {

                string fullpath = System.IO.Path.Combine(path, string.Format("libros\\{0}", imagen));
                pbimagen.Image = new System.Drawing.Bitmap(fullpath);

            }
            else
            {
                pbimagen.Image = Presentacion.Properties.Resources.no_disponible;
            }
            lbbarra.Text = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_BARRA"]));
            lbisbn.Text = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_ISBN"]));
            lbcodinterno.Text = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_CODIGO"]));
            lbcuerpo.Text = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_CUERPO"]));
            lbestante.Text = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_ESTANTE"]));
            lbeditorial.Text = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["EDI_EDITORIAL"]));
            lbgenero.Text = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["GEN_DESC"]));

            if (Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_FECHAPRE"])) != "")
            {
                DateTime fechaactu = Convert.ToDateTime(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_FECHAPRE"]));
                lbultimaap.Text = fechaactu.ToShortDateString();
            }

        }

        private void cargardatos11()
        {
            lbtitulo.Text = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_DESC"]));
            lbprecio.Text = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_PRECIO"]));
            int stock = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_STOCK"]));
            if (stock > 0 && stock < 5)
            {
                pbcirculo.Image = Presentacion.Properties.Resources.circuloamarillo30;
            }
            else if (stock < 1)
            {
                pbcirculo.Image = Presentacion.Properties.Resources.circulorojo30;
            }
            else
            {
                pbcirculo.Image = Presentacion.Properties.Resources.circuloverde30;
            }
            lbstock.Text = Convert.ToString(stock);
            string imagen = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_IMAGEN"]));
            string path = Directory.GetCurrentDirectory();
            if (imagen != string.Empty)
            {

                string fullpath = System.IO.Path.Combine(path, string.Format("libros\\{0}", imagen));
                pbimagen.Image = new System.Drawing.Bitmap(fullpath);

            }
            else
            {
                pbimagen.Image = Presentacion.Properties.Resources.no_disponible;
            }
            lbbarra.Text = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_BARRA"]));
            lbisbn.Text = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_ISBN"]));
            lbcodinterno.Text = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_CODIGO"]));
            lbcuerpo.Text = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_CUERPO"]));
            lbestante.Text = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_ESTANTE"]));
            lbeditorial.Text = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["EDI_EDITORIAL"]));
            lbgenero.Text = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["GEN_DESC"]));
            lbultimaap.Text = "";
            if (Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_FECHAPRE"])) != "")
            {
                DateTime fechaactu = Convert.ToDateTime(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_FECHAPRE"]));
                lbultimaap.Text = fechaactu.ToShortDateString();
            }

        }

        private void gridViewPintarFilas_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.cargardatos();
        }

        private void btnzoom_Click(object sender, EventArgs e)
        {
            try
            {
                ImagenCompleta ic = new ImagenCompleta();
                //ic.PonerImagen(System.Drawing.Bitmap.FromStream(this.ms));

                ic.PonerImagen(pbimagen.Image);
                ic.ShowDialog();
            }
            catch
            {
                MessageBox.Show("No hay imágenes para mostrar");
            }
        }

        private void btngoogle_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com.ar/search?q= " + lbbarra.Text + " &source=lnms&tbm=isch&sa=X&ved=0ahUKEwinis2r9oDPAhXBIJAKHSdLBeYQ_AUICCgB&biw=1024&bih=662");
        }

        private void txtisbn_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //buscar acá
                this.busquedasimple();

            }
        }

        private void txtcodigo_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //buscar acá
                this.busquedasimple();

            }
        }

        public void cambiarfondo()
        {
            this.BackColor = Globales.colorfondo;
            panel1.BackColor = Globales.colorfondo;

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            AltaProducto ap = new AltaProducto();
            ap.Alta = 1;
            if (ap.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gConsulta.DataSource = pro.Mostrar_productos();
            }

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Productos pro = new Productos();
            pro.productoide = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_IDE"]));
            pro.Codigo = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_CODIGO"]));
            pro.Titulo = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_DESC"]));
            pro.Autor = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_AUTOR"]));
            pro.Editorial = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_EDI_CODIGO"]));
            pro.Genero = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_GEN_IDE"]));
            pro.Precio = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_PRECIO"]));

            int tipopro = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_TIPOPRO"]));
            pro.Tipo = tipopro;
            if (tipopro > 0)
            {
                pro.Costo = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_COSTO"]));
                pro.Iva = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_PORC_IVA"]));
                pro.Ganancia = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_PORC_GANAN"]));
            }
            pro.Isbn = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_ISBN"]));
            pro.Barra = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_BARRA"]));
            pro.Imagen = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_IMAGEN"]));
            pro.Cuerpo = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_CUERPO"]));
            pro.Estante = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_ESTANTE"]));

            AltaProducto ap = new AltaProducto();
            ap.Alta = 0;
            ap.colocardatos(pro);
            if (ap.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gConsulta.DataSource = pro.Mostrar_productos();
            }

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar éste producto?", "Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {


                Productos pro = new Productos();
                pro.productoide = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_IDE"]));
                int retorno = pro.spEliminarProducto();
                if (retorno == 0)
                {
                    gConsulta.DataSource = null;
                    MessageBox.Show("Se ha eliminado el producto con éxito!");
                }
                else
                {
                    MessageBox.Show("Hubo un error en la eliminación del producto!");
                }

            }
        }

        private void gConsulta_DoubleClick(object sender, EventArgs e)
        {
            

            
        }

        private void gridViewPintarFilas_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.cargardatos();
        }

        private void gConsulta_DoubleClick_1(object sender, EventArgs e)
        {
            string tituloi, precioi, autori, codigointernoedii, existenciai, isbni, codproide;
            tituloi = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_DESC"]));
            precioi = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_PRECIO"]));
            autori = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_AUTOR"]));
            codigointernoedii = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_CODIGOPROVEE"]));
            existenciai = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_STOCK"]));
            isbni = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_ISBN"]));
            codproide = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_CODIGO"]));

            IproductoConsigna formdeInterface1 = this.Owner as IproductoConsigna;
                if (formdeInterface1 != null)
                {
                formdeInterface1.AgregaProductoC(tituloi, precioi, autori, codigointernoedii, existenciai, isbni, codproide);
                }

            this.Dispose();
            this.Hide();

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            ConsultaMoviVtas cmv = new ConsultaMoviVtas();
            cmv.Codigo = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["LI_CODIGO"]));
            cmv.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}


