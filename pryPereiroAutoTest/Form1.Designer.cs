namespace pryPereiroAutoTest
{
    partial class frmAutoTest
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpResgistro = new GroupBox();
            lblTitular = new Label();
            lblAñoFabricacion = new Label();
            lblDominio = new Label();
            lblNroTurno = new Label();
            txtTitular = new TextBox();
            txtNroTurno = new TextBox();
            txtDominio = new TextBox();
            nudAñoFabricacion = new NumericUpDown();
            lblRegistro = new Label();
            grpConsulta = new GroupBox();
            lblCantDominio6Caracteres = new Label();
            lblAñoMasAntiguo = new Label();
            lblCantTurnos = new Label();
            txtDominio6Caracteres = new TextBox();
            txtAñoMasAntiguo = new TextBox();
            txtCantidadTurnos = new TextBox();
            lblEstadisticas = new Label();
            btnRegistrar = new Button();
            btnSalir = new Button();
            btnConsultar = new Button();
            grpResgistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAñoFabricacion).BeginInit();
            grpConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // grpResgistro
            // 
            grpResgistro.BackColor = SystemColors.ActiveBorder;
            grpResgistro.Controls.Add(lblTitular);
            grpResgistro.Controls.Add(lblAñoFabricacion);
            grpResgistro.Controls.Add(lblDominio);
            grpResgistro.Controls.Add(lblNroTurno);
            grpResgistro.Controls.Add(txtTitular);
            grpResgistro.Controls.Add(txtNroTurno);
            grpResgistro.Controls.Add(txtDominio);
            grpResgistro.Controls.Add(nudAñoFabricacion);
            grpResgistro.Location = new Point(12, 40);
            grpResgistro.Name = "grpResgistro";
            grpResgistro.Size = new Size(538, 267);
            grpResgistro.TabIndex = 0;
            grpResgistro.TabStop = false;
            // 
            // lblTitular
            // 
            lblTitular.AutoSize = true;
            lblTitular.Location = new Point(15, 203);
            lblTitular.Name = "lblTitular";
            lblTitular.Size = new Size(60, 25);
            lblTitular.TabIndex = 7;
            lblTitular.Text = "Titular";
            // 
            // lblAñoFabricacion
            // 
            lblAñoFabricacion.AutoSize = true;
            lblAñoFabricacion.Location = new Point(15, 147);
            lblAñoFabricacion.Name = "lblAñoFabricacion";
            lblAñoFabricacion.Size = new Size(163, 25);
            lblAñoFabricacion.TabIndex = 6;
            lblAñoFabricacion.Text = "Año de Fabricación";
            // 
            // lblDominio
            // 
            lblDominio.AutoSize = true;
            lblDominio.Location = new Point(15, 88);
            lblDominio.Name = "lblDominio";
            lblDominio.Size = new Size(81, 25);
            lblDominio.TabIndex = 5;
            lblDominio.Text = "Dominio";
            // 
            // lblNroTurno
            // 
            lblNroTurno.AutoSize = true;
            lblNroTurno.Location = new Point(15, 27);
            lblNroTurno.Name = "lblNroTurno";
            lblNroTurno.Size = new Size(153, 25);
            lblNroTurno.TabIndex = 4;
            lblNroTurno.Text = "Número de Turno";
            // 
            // txtTitular
            // 
            txtTitular.Location = new Point(197, 200);
            txtTitular.MaxLength = 30;
            txtTitular.Name = "txtTitular";
            txtTitular.Size = new Size(314, 31);
            txtTitular.TabIndex = 3;
            txtTitular.TextChanged += txtTitular_TextChanged;
            // 
            // txtNroTurno
            // 
            txtNroTurno.Location = new Point(197, 24);
            txtNroTurno.MaxLength = 5;
            txtNroTurno.Name = "txtNroTurno";
            txtNroTurno.Size = new Size(83, 31);
            txtNroTurno.TabIndex = 2;
            txtNroTurno.TextChanged += txtNroTurno_TextChanged;
            // 
            // txtDominio
            // 
            txtDominio.Location = new Point(197, 85);
            txtDominio.MaxLength = 7;
            txtDominio.Name = "txtDominio";
            txtDominio.Size = new Size(150, 31);
            txtDominio.TabIndex = 1;
            txtDominio.TextChanged += txtDominio_TextChanged;
            // 
            // nudAñoFabricacion
            // 
            nudAñoFabricacion.Location = new Point(197, 145);
            nudAñoFabricacion.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            nudAñoFabricacion.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            nudAñoFabricacion.Name = "nudAñoFabricacion";
            nudAñoFabricacion.Size = new Size(99, 31);
            nudAñoFabricacion.TabIndex = 0;
            nudAñoFabricacion.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            nudAñoFabricacion.ValueChanged += nudAñoFabricacion_ValueChanged;
            // 
            // lblRegistro
            // 
            lblRegistro.AutoSize = true;
            lblRegistro.Location = new Point(12, 12);
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Size = new Size(153, 25);
            lblRegistro.TabIndex = 4;
            lblRegistro.Text = "Registro de Turno";
            // 
            // grpConsulta
            // 
            grpConsulta.BackColor = SystemColors.ActiveBorder;
            grpConsulta.Controls.Add(lblCantDominio6Caracteres);
            grpConsulta.Controls.Add(lblAñoMasAntiguo);
            grpConsulta.Controls.Add(lblCantTurnos);
            grpConsulta.Controls.Add(txtDominio6Caracteres);
            grpConsulta.Controls.Add(txtAñoMasAntiguo);
            grpConsulta.Controls.Add(txtCantidadTurnos);
            grpConsulta.Location = new Point(12, 338);
            grpConsulta.Name = "grpConsulta";
            grpConsulta.Size = new Size(549, 221);
            grpConsulta.TabIndex = 5;
            grpConsulta.TabStop = false;
            // 
            // lblCantDominio6Caracteres
            // 
            lblCantDominio6Caracteres.AutoSize = true;
            lblCantDominio6Caracteres.Location = new Point(6, 143);
            lblCantDominio6Caracteres.Name = "lblCantDominio6Caracteres";
            lblCantDominio6Caracteres.Size = new Size(322, 25);
            lblCantDominio6Caracteres.TabIndex = 5;
            lblCantDominio6Caracteres.Text = "Cantidad con Dominio de 6 Caracteres ";
            // 
            // lblAñoMasAntiguo
            // 
            lblAñoMasAntiguo.AutoSize = true;
            lblAñoMasAntiguo.Location = new Point(6, 89);
            lblAñoMasAntiguo.Name = "lblAñoMasAntiguo";
            lblAñoMasAntiguo.Size = new Size(181, 25);
            lblAñoMasAntiguo.TabIndex = 4;
            lblAñoMasAntiguo.Text = "Año del más Antiguo";
            // 
            // lblCantTurnos
            // 
            lblCantTurnos.AutoSize = true;
            lblCantTurnos.Location = new Point(11, 30);
            lblCantTurnos.Name = "lblCantTurnos";
            lblCantTurnos.Size = new Size(167, 25);
            lblCantTurnos.TabIndex = 3;
            lblCantTurnos.Text = "Cantidad de Turnos";
            // 
            // txtDominio6Caracteres
            // 
            txtDominio6Caracteres.Location = new Point(383, 143);
            txtDominio6Caracteres.MaxLength = 6;
            txtDominio6Caracteres.Name = "txtDominio6Caracteres";
            txtDominio6Caracteres.ReadOnly = true;
            txtDominio6Caracteres.Size = new Size(84, 31);
            txtDominio6Caracteres.TabIndex = 2;
            // 
            // txtAñoMasAntiguo
            // 
            txtAñoMasAntiguo.Location = new Point(383, 83);
            txtAñoMasAntiguo.Name = "txtAñoMasAntiguo";
            txtAñoMasAntiguo.ReadOnly = true;
            txtAñoMasAntiguo.Size = new Size(84, 31);
            txtAñoMasAntiguo.TabIndex = 1;
            // 
            // txtCantidadTurnos
            // 
            txtCantidadTurnos.Location = new Point(383, 27);
            txtCantidadTurnos.Name = "txtCantidadTurnos";
            txtCantidadTurnos.ReadOnly = true;
            txtCantidadTurnos.Size = new Size(84, 31);
            txtCantidadTurnos.TabIndex = 0;
            // 
            // lblEstadisticas
            // 
            lblEstadisticas.AutoSize = true;
            lblEstadisticas.Location = new Point(12, 310);
            lblEstadisticas.Name = "lblEstadisticas";
            lblEstadisticas.Size = new Size(102, 25);
            lblEstadisticas.TabIndex = 6;
            lblEstadisticas.Text = "Estadisticas";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Enabled = false;
            btnRegistrar.Location = new Point(566, 40);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(112, 34);
            btnRegistrar.TabIndex = 7;
            btnRegistrar.Text = "&Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(566, 119);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 34);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "&Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(566, 338);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(112, 34);
            btnConsultar.TabIndex = 9;
            btnConsultar.Text = "&Consular";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // frmAutoTest
            // 
            AcceptButton = btnRegistrar;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            CancelButton = btnSalir;
            ClientSize = new Size(696, 576);
            ControlBox = false;
            Controls.Add(btnConsultar);
            Controls.Add(btnSalir);
            Controls.Add(btnRegistrar);
            Controls.Add(lblEstadisticas);
            Controls.Add(grpConsulta);
            Controls.Add(lblRegistro);
            Controls.Add(grpResgistro);
            ForeColor = SystemColors.ControlText;
            Name = "frmAutoTest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Auto Test";
            grpResgistro.ResumeLayout(false);
            grpResgistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAñoFabricacion).EndInit();
            grpConsulta.ResumeLayout(false);
            grpConsulta.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpResgistro;
        private TextBox txtTitular;
        private TextBox txtNroTurno;
        private TextBox txtDominio;
        private NumericUpDown nudAñoFabricacion;
        private Label lblTitular;
        private Label lblAñoFabricacion;
        private Label lblDominio;
        private Label lblNroTurno;
        private Label lblRegistro;
        private GroupBox grpConsulta;
        private Label lblAñoMasAntiguo;
        private Label lblCantTurnos;
        private TextBox txtDominio6Caracteres;
        private TextBox txtAñoMasAntiguo;
        private TextBox txtCantidadTurnos;
        private Label lblEstadisticas;
        private Label lblCantDominio6Caracteres;
        private Button btnRegistrar;
        private Button btnSalir;
        private Button btnConsultar;
    }
}
