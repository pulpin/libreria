﻿namespace Presentacion
{
    partial class ConsultaGenero
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
            this.gConsulta = new DevExpress.XtraGrid.GridControl();
            this.gridViewPintarFilas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GEN_IDE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GEN_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GEN_TIPO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaltacliente = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.txttitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rBlibreria = new System.Windows.Forms.RadioButton();
            this.rBlibros = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gConsulta
            // 
            this.gConsulta.Location = new System.Drawing.Point(60, 71);
            this.gConsulta.MainView = this.gridViewPintarFilas;
            this.gConsulta.Name = "gConsulta";
            this.gConsulta.Size = new System.Drawing.Size(466, 292);
            this.gConsulta.TabIndex = 1;
            this.gConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPintarFilas});
            this.gConsulta.DoubleClick += new System.EventHandler(this.gConsulta_DoubleClick);
            // 
            // gridViewPintarFilas
            // 
            this.gridViewPintarFilas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GEN_IDE,
            this.GEN_DESC,
            this.GEN_TIPO});
            this.gridViewPintarFilas.GridControl = this.gConsulta;
            this.gridViewPintarFilas.Name = "gridViewPintarFilas";
            this.gridViewPintarFilas.OptionsBehavior.Editable = false;
            this.gridViewPintarFilas.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridViewPintarFilas.OptionsView.ShowFooter = true;
            // 
            // GEN_IDE
            // 
            this.GEN_IDE.Caption = "Código";
            this.GEN_IDE.FieldName = "GEN_IDE";
            this.GEN_IDE.Name = "GEN_IDE";
            this.GEN_IDE.Visible = true;
            this.GEN_IDE.VisibleIndex = 0;
            this.GEN_IDE.Width = 59;
            // 
            // GEN_DESC
            // 
            this.GEN_DESC.Caption = "Género";
            this.GEN_DESC.FieldName = "GEN_DESC";
            this.GEN_DESC.Name = "GEN_DESC";
            this.GEN_DESC.Visible = true;
            this.GEN_DESC.VisibleIndex = 1;
            this.GEN_DESC.Width = 200;
            // 
            // GEN_TIPO
            // 
            this.GEN_TIPO.Caption = "GEN_TIPO";
            this.GEN_TIPO.FieldName = "GEN_TIPO";
            this.GEN_TIPO.Name = "GEN_TIPO";
            // 
            // btncancelar
            // 
            this.btncancelar.Image = global::Presentacion.Properties.Resources.cancelar32;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncancelar.Location = new System.Drawing.Point(405, 369);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(73, 59);
            this.btncancelar.TabIndex = 12;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnaltacliente
            // 
            this.btnaltacliente.Enabled = false;
            this.btnaltacliente.Image = global::Presentacion.Properties.Resources.add32;
            this.btnaltacliente.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnaltacliente.Location = new System.Drawing.Point(18, 8);
            this.btnaltacliente.Name = "btnaltacliente";
            this.btnaltacliente.Size = new System.Drawing.Size(58, 57);
            this.btnaltacliente.TabIndex = 193;
            this.btnaltacliente.Text = "Nuevo";
            this.btnaltacliente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnaltacliente.UseVisualStyleBackColor = true;
            this.btnaltacliente.Click += new System.EventHandler(this.btnaltacliente_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Enabled = false;
            this.btnmodificar.Image = global::Presentacion.Properties.Resources.editar321;
            this.btnmodificar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnmodificar.Location = new System.Drawing.Point(97, 8);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(58, 57);
            this.btnmodificar.TabIndex = 196;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // txttitulo
            // 
            this.txttitulo.Location = new System.Drawing.Point(322, 43);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(178, 20);
            this.txttitulo.TabIndex = 197;
            this.txttitulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttitulo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 198;
            this.label1.Text = "Género:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rBlibreria);
            this.groupBox2.Controls.Add(this.rBlibros);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(285, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 33);
            this.groupBox2.TabIndex = 258;
            this.groupBox2.TabStop = false;
            // 
            // rBlibreria
            // 
            this.rBlibreria.AutoSize = true;
            this.rBlibreria.ForeColor = System.Drawing.Color.Maroon;
            this.rBlibreria.Location = new System.Drawing.Point(87, 8);
            this.rBlibreria.Name = "rBlibreria";
            this.rBlibreria.Size = new System.Drawing.Size(87, 18);
            this.rBlibreria.TabIndex = 200;
            this.rBlibreria.Text = "Art. librería";
            this.rBlibreria.UseVisualStyleBackColor = true;
            this.rBlibreria.CheckedChanged += new System.EventHandler(this.rBlibreria_CheckedChanged);
            // 
            // rBlibros
            // 
            this.rBlibros.AutoSize = true;
            this.rBlibros.Checked = true;
            this.rBlibros.ForeColor = System.Drawing.Color.Maroon;
            this.rBlibros.Location = new System.Drawing.Point(19, 8);
            this.rBlibros.Name = "rBlibros";
            this.rBlibros.Size = new System.Drawing.Size(61, 18);
            this.rBlibros.TabIndex = 199;
            this.rBlibros.TabStop = true;
            this.rBlibros.Text = "Libros";
            this.rBlibros.UseVisualStyleBackColor = true;
            this.rBlibros.CheckedChanged += new System.EventHandler(this.rBlibros_CheckedChanged);
            // 
            // ConsultaGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 434);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txttitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnaltacliente);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.gConsulta);
            this.Name = "ConsultaGenero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Géneros";
            this.Load += new System.EventHandler(this.ConsultaInteres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPintarFilas;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnaltacliente;
        private DevExpress.XtraGrid.Columns.GridColumn GEN_IDE;
        private System.Windows.Forms.Button btnmodificar;
        private DevExpress.XtraGrid.Columns.GridColumn GEN_DESC;
        private System.Windows.Forms.TextBox txttitulo;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn GEN_TIPO;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rBlibreria;
        private System.Windows.Forms.RadioButton rBlibros;
    }
}