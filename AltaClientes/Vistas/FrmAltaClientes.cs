﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using AltaClientes.AcessoDatos;
using AltaClientes.Entidades;
using AltaClientes.Modelos;


namespace AltaClientes
{
    public partial class frmAltaClientes : Form
    {
        private ToolTip toolTip;
        private Regex caracterValido = new Regex(@"[^a-zA-Z0-9]");
        private AltaClientesViewModel altaclientesviewmodel;
        public frmAltaClientes()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }
        private void Limpiar()
        {
            txtCodigo.Clear();
            txtDomicilio.Clear();
            txtNombre.Clear();
            txtNumCasa.Clear();
            txtTelefono.Clear();
            cboEstatus.Text = "";
        }
        private void Limpiar1()
        {

            txtDomicilio.Clear();
            txtNombre.Clear();
            txtNumCasa.Clear();
            txtTelefono.Clear();
            cboEstatus.Text = "";
        }
        private void Salir()
        {
            if (MessageBox.Show("¿Desea salir del formulario?",
                     "Salir",
                     MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
        private void Guardar()
        {
            if (ValidaTodosLosCampos(Controles.TODOS))
            {
                if (MessageBox.Show("¿Desea registrar al usuario?",
                "Guardar",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                int num = int.Parse(txtCodigo.Text);
                string nombre = txtNombre.Text;
                string telefono = Convert.ToString(txtTelefono.Text).Replace("-", string.Empty);
                string fechanac = dtpFechaNacimiento.Value.ToString("yyyy/MM/dd");
                string domicilio = txtDomicilio.Text;
                int numinterior = int.Parse(txtNumCasa.Text);
                string estatus = cboEstatus.SelectedValue.ToString();
                //MessageBox.Show(estatus);

                try
                {
                    if (altaclientesviewmodel.GuardarCliente(num, nombre, telefono, fechanac, domicilio, numinterior, estatus))
                    {
                        MessageBox.Show("Se guardó correctamente el usuario",
                                    "Guardar",
                                    MessageBoxButtons.OK);
                        Limpiar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "No se pudo guardar");

                }
                }
            }
        }
        
        private void frmAltaClientes_Load(object sender, EventArgs e)
        {
            inicio();
            altaclientesviewmodel = new AltaClientesViewModel();
            cboAccion.Items.Add("Guardar");
            cboAccion.Items.Add("Modificar");
            
            cboEstatus.Items.Add("1");
            cboEstatus.Items.Add("0");
            
        }

      
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();

        }
        private Boolean ValidaTodosLosCampos(Controles control)
        {
            Boolean bRegresa = true;

            for (int iControl = 0; iControl < (int)control; iControl++)
            {
                if (!ValidaCampo((Controles)iControl))
                {
                    bRegresa = false;
                    break;
                }
            }

            return bRegresa;
        }

        public Boolean ValidaCampo(Controles control)
        {
            Boolean regresa = true;

            switch (control)
            {
                case Controles.TB_NOMBRE:
                    {
                        if (String.IsNullOrWhiteSpace(txtNombre.Text))
                        {
                            toolTip = new ToolTip();
                            toolTip.ToolTipIcon = ToolTipIcon.Info;
                            toolTip.Show("Ingrese nombre", txtNombre, 1100);
                            txtNombre.Focus();
                            regresa = false;
                            txtNombre.ForeColor = Color.DarkRed;
                            txtNombre.Focus();
                            regresa = false;
                        }
                        else
                        {
                            txtNombre.ForeColor = Color.Green;

                        }
                    }
                    break;




                case Controles.TB_TELEFONO:


                    string tbtelefono = txtTelefono.Text;
                    tbtelefono = tbtelefono.Replace(" ", String.Empty);
                    string telefonoinvalido = "   -   -    ";
                    telefonoinvalido = telefonoinvalido.Replace(" ", String.Empty);


                    if (telefonoinvalido == tbtelefono | tbtelefono.Length < 12)
                    {
                        toolTip = new ToolTip();
                        toolTip.ToolTipIcon = ToolTipIcon.Info;
                        toolTip.Show("Numero telefonico invalido", txtTelefono, 1100);
                        txtTelefono.Focus();
                        txtDomicilio.ForeColor = Color.DarkRed;
                        regresa = false;

                    }
                    else
                    {
                        txtTelefono.ForeColor = Color.Green;

                    }
                    break;

                case Controles.TB_DOMICILIO:
                    {



                        if (String.IsNullOrWhiteSpace(txtDomicilio.Text))
                        {
                            toolTip = new ToolTip();
                            toolTip.ToolTipIcon = ToolTipIcon.Info;
                            toolTip.Show("Ingrese domicilio", txtDomicilio, 1100);
                            txtDomicilio.Focus();
                            txtDomicilio.ForeColor = Color.DarkRed;
                            txtDomicilio.Focus();
                            regresa = false;
                        }
                        else
                        {
                            txtDomicilio.ForeColor = Color.Green;

                        }
                    }
                    break;

                case Controles.DTP_FECHANACIMIENTO:

                    int fecha;
                    int fechaHoy;

                    fecha = Int32.Parse(dtpFechaNacimiento.Value.Date.ToString("yyyy"));
                    fechaHoy = Int32.Parse(DateTime.Now.ToString("yyyy"));

                    if (fecha >= fechaHoy - 18)
                    {
                        toolTip = new ToolTip();
                        toolTip.ToolTipIcon = ToolTipIcon.Info;
                        toolTip.Show("Fecha incorrecta", dtpFechaNacimiento, 1100);
                        dtpFechaNacimiento.Focus();
                        dtpFechaNacimiento.ForeColor = Color.DarkRed;
                        regresa = false;
                    }
                    else
                    {
                        dtpFechaNacimiento.ForeColor = Color.Green;

                    }

                    break;

                case Controles.TB_INTERIOR:
                    {
                        string numerocasa = txtNumCasa.Text;
                        numerocasa = numerocasa.Replace("-", String.Empty);

                        if (String.IsNullOrWhiteSpace(numerocasa.ToString()))
                        {
                            toolTip = new ToolTip();
                            toolTip.ToolTipIcon = ToolTipIcon.Info;
                            toolTip.Show("Ingrese numero de casa", txtNumCasa, 1100);
                            txtNumCasa.Focus();
                            txtNumCasa.ForeColor = Color.DarkRed;
                            regresa = false;
                        }
                        else
                        {
                            txtDomicilio.ForeColor = Color.Green;

                        }
                    }
                    break;

                case Controles.CB_ESTATUS:
                    {
                        if (string.IsNullOrEmpty(cboEstatus.Text))
                        {
                            toolTip = new ToolTip();
                            toolTip.ToolTipIcon = ToolTipIcon.Info;
                            toolTip.Show("Seleccione un estatus", cboEstatus, 1100);
                            cboEstatus.Focus();
                            cboEstatus.ForeColor = Color.DarkRed;
                            regresa = false;
                        }


                    }

                    break;



            }

            return regresa;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea realizar una nueva consulta?",
                "Limpiar",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Limpiar();
                btnGuardar.Enabled = false;
            }
      
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
           
        }

        public void buscar()
        {
            DataTable dtUsuarios;

            dtUsuarios = altaclientesviewmodel.ConsultarUsuarios();

            if (dtUsuarios.Rows.Count > 0)
            {
                FrmBuscar frmBuscar = new FrmBuscar(dtUsuarios);

                var resultado = frmBuscar.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    string cod = frmBuscar.codigo;
                    string nom = frmBuscar.nombre;
                    string dom = frmBuscar.domicili;
                    string tel = frmBuscar.telefon;
                    string num = frmBuscar.numi;
                    string fec = frmBuscar.fech;
                    string opcac = frmBuscar.opc;

                    this.txtCodigo.Text = cod;
                    this.txtNombre.Text = nom;
                    this.txtDomicilio.Text = dom;
                    this.txtTelefono.Text = tel;
                    this.txtNumCasa.Text = num;
                    this.dtpFechaNacimiento.Text = fec;
                    this.cboEstatus.Text = opcac;
                }
            }
            else
            {
                MessageBox.Show("No se encontraron los datos"
                            , "Error"
                            , MessageBoxButtons.OK
                            , MessageBoxIcon.Warning);
            }
        }

        public void inicio()
        {
            txtCodigo.Enabled = false;
            txtNombre.Enabled = false;
            txtNumCasa.Enabled = false;
            txtTelefono.Enabled = false;
            txtDomicilio.Enabled = false;
            txtNumCasa.Enabled = false;
            cboEstatus.Enabled = false;
            dtpFechaNacimiento.Enabled = false;
            btnGuardar.Enabled = false;
            btnBuscar.Enabled = false;
        }
       
        public void CodigoSiguiente() {

            DataTable dtultimoCodigo;
            dtultimoCodigo = altaclientesviewmodel.ultimoCodigo();


            string codigo = dtultimoCodigo.Rows[0]["numeroCliente"].ToString();
            txtCodigo.Text = codigo;         
        }
        private void cboAccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int indice = cboAccion.SelectedIndex;

            if (cboAccion.Text == "Guardar")
            {
                
                CodigoSiguiente();
                Limpiar1();
                txtNombre.Enabled = true;
                txtNumCasa.Enabled = true;
                txtTelefono.Enabled = true;
                txtDomicilio.Enabled = true;
                txtNumCasa.Enabled = true;
                cboEstatus.Enabled = true;
                dtpFechaNacimiento.Enabled = true;
                btnGuardar.Enabled = true;
                txtCodigo.Enabled = false;
                CargarEstatus();
                txtNombre.Focus();

            }
            else
            {
                Limpiar();
                btnBuscar.Enabled = true;
                txtCodigo.Enabled = false;
                txtNombre.Enabled = true;
                txtTelefono.Enabled = true;
                dtpFechaNacimiento.Enabled = true;
                txtDomicilio.Enabled = true;
                txtNumCasa.Enabled = true;
                cboEstatus.Enabled = true;
                btnGuardar.Enabled = true;
                btnBuscar.Focus();
                CargarEstatus();

            }
        }
        private Boolean CargarEstatus()
        {
            Boolean resultado = false;
            DataTable dtEstatus;
            List<ComboBoxAlta> listaEstatus = new List<ComboBoxAlta>();

            dtEstatus = altaclientesviewmodel.cargarEstatus();

            if (dtEstatus != null)
            {

                foreach (DataRow dtRow in dtEstatus.Rows)
                {
                    listaEstatus.Add(new ComboBoxAlta
                    {
                        ID = dtRow[0].ToString().Trim(),
                        Descripcion = dtRow[1].ToString().Trim(),
                    });
                }

                cboEstatus.DataSource = listaEstatus;
                cboEstatus.ValueMember = "ID";
                cboEstatus.DisplayMember = "Descripcion";
                cboEstatus.SelectedIndex = -1;
                resultado = true;
            }

            return resultado;
        }
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Ingrese solo números");
                return;
            }
        }

        private void txtNumCasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Ingrese solo números");
                return;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            //{
            //    e.Handled = true;
            //    MessageBox.Show("Ingrese solo letra");
            //    return;
            //}
        }

        private void cboEstatus_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }
    }
}
