﻿namespace AltaClientes
{
    partial class frmAltaClientes
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtNumCasa = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cboAccion = new System.Windows.Forms.ComboBox();
            this.cboEstatus = new System.Windows.Forms.ComboBox();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Teléfono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de Nacimiento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Domicilio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "N. Interior:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(124, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 20);
            this.label9.TabIndex = 8;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(198, 318);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(107, 40);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(197, 54);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(123, 26);
            this.txtCodigo.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(197, 91);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(224, 26);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(198, 200);
            this.txtDomicilio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(250, 26);
            this.txtDomicilio.TabIndex = 6;
            // 
            // txtNumCasa
            // 
            this.txtNumCasa.Location = new System.Drawing.Point(197, 232);
            this.txtNumCasa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumCasa.Name = "txtNumCasa";
            this.txtNumCasa.Size = new System.Drawing.Size(100, 26);
            this.txtNumCasa.TabIndex = 7;
            this.txtNumCasa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumCasa_KeyPress);
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(198, 161);
            this.dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(144, 26);
            this.dtpFechaNacimiento.TabIndex = 5;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Location = new System.Drawing.Point(112, 271);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(79, 29);
            this.lblMensaje.TabIndex = 21;
            this.lblMensaje.Text = "Estatus:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(310, 318);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(86, 40);
            this.btnLimpiar.TabIndex = 23;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(403, 318);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 40);
            this.btnSalir.TabIndex = 25;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(429, 92);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(32, 26);
            this.btnBuscar.TabIndex = 27;
            this.btnBuscar.Text = "🔍";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(130, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Acción:";
            // 
            // cboAccion
            // 
            this.cboAccion.FormattingEnabled = true;
            this.cboAccion.Location = new System.Drawing.Point(197, 15);
            this.cboAccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboAccion.Name = "cboAccion";
            this.cboAccion.Size = new System.Drawing.Size(121, 28);
            this.cboAccion.TabIndex = 1;
            this.cboAccion.SelectedIndexChanged += new System.EventHandler(this.cboAccion_SelectedIndexChanged);
            // 
            // cboEstatus
            // 
            this.cboEstatus.FormattingEnabled = true;
            this.cboEstatus.Location = new System.Drawing.Point(197, 265);
            this.cboEstatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboEstatus.Name = "cboEstatus";
            this.cboEstatus.Size = new System.Drawing.Size(121, 28);
            this.cboEstatus.TabIndex = 8;
            this.cboEstatus.SelectedIndexChanged += new System.EventHandler(this.cboEstatus_SelectedIndexChanged_1);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(197, 126);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelefono.Mask = "000-000-0000";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(121, 26);
            this.txtTelefono.TabIndex = 4;
            // 
            // frmAltaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 379);
            this.ControlBox = false;
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.cboEstatus);
            this.Controls.Add(this.cboAccion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.txtNumCasa);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAltaClientes";
            this.Text = "Alta Clientes";
            this.Load += new System.EventHandler(this.frmAltaClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.TextBox txtNumCasa;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboAccion;
        private System.Windows.Forms.ComboBox cboEstatus;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
    }
}

