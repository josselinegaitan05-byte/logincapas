namespace Presentacion.Formularios
{
    partial class frmRegistroUsuario
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>Libera los recursos usados.</summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlTarjeta = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmacion = new System.Windows.Forms.Label();
            this.txtConfirmacion = new System.Windows.Forms.TextBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.errValidacion = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlTarjeta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errValidacion)).BeginInit();
            this.SuspendLayout();
            //
            // pnlTarjeta
            //
            this.pnlTarjeta.BackColor = System.Drawing.Color.White;
            this.pnlTarjeta.Controls.Add(this.btnLimpiar);
            this.pnlTarjeta.Controls.Add(this.btnGuardar);
            this.pnlTarjeta.Controls.Add(this.lblMensaje);
            this.pnlTarjeta.Controls.Add(this.txtConfirmacion);
            this.pnlTarjeta.Controls.Add(this.lblConfirmacion);
            this.pnlTarjeta.Controls.Add(this.txtPassword);
            this.pnlTarjeta.Controls.Add(this.lblPassword);
            this.pnlTarjeta.Controls.Add(this.txtUsuario);
            this.pnlTarjeta.Controls.Add(this.lblUsuario);
            this.pnlTarjeta.Controls.Add(this.txtCodigo);
            this.pnlTarjeta.Controls.Add(this.lblCodigo);
            this.pnlTarjeta.Controls.Add(this.lblNota);
            this.pnlTarjeta.Controls.Add(this.lblTitulo);
            this.pnlTarjeta.Location = new System.Drawing.Point(32, 24);
            this.pnlTarjeta.Name = "pnlTarjeta";
            this.pnlTarjeta.Size = new System.Drawing.Size(540, 470);
            this.pnlTarjeta.TabIndex = 0;
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(32, 33, 36);
            this.lblTitulo.Location = new System.Drawing.Point(24, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(150, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Nuevo usuario";
            //
            // lblNota
            //
            this.lblNota.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNota.ForeColor = System.Drawing.Color.FromArgb(95, 99, 104);
            this.lblNota.Location = new System.Drawing.Point(26, 50);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(490, 34);
            this.lblNota.TabIndex = 1;
            this.lblNota.Text = "La contraseña se convierte en hash SHA-512 con IHashService.GenerarHash() en la capa de Negocio; a la base de datos solo llega el hash.";
            //
            // lblCodigo
            //
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(32, 33, 36);
            this.lblCodigo.Location = new System.Drawing.Point(24, 94);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(51, 17);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Código";
            //
            // txtCodigo
            //
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtCodigo.Location = new System.Drawing.Point(27, 116);
            this.txtCodigo.MaxLength = 50;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(150, 27);
            this.txtCodigo.TabIndex = 3;
            //
            // lblUsuario
            //
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(32, 33, 36);
            this.lblUsuario.Location = new System.Drawing.Point(24, 154);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(53, 17);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario";
            //
            // txtUsuario
            //
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtUsuario.Location = new System.Drawing.Point(27, 176);
            this.txtUsuario.MaxLength = 50;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(460, 27);
            this.txtUsuario.TabIndex = 5;
            //
            // lblPassword
            //
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(32, 33, 36);
            this.lblPassword.Location = new System.Drawing.Point(24, 214);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(180, 17);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Contraseña (mínimo 6 caracteres)";
            //
            // txtPassword
            //
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtPassword.Location = new System.Drawing.Point(27, 236);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(460, 27);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.UseSystemPasswordChar = true;
            //
            // lblConfirmacion
            //
            this.lblConfirmacion.AutoSize = true;
            this.lblConfirmacion.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblConfirmacion.ForeColor = System.Drawing.Color.FromArgb(32, 33, 36);
            this.lblConfirmacion.Location = new System.Drawing.Point(24, 274);
            this.lblConfirmacion.Name = "lblConfirmacion";
            this.lblConfirmacion.Size = new System.Drawing.Size(137, 17);
            this.lblConfirmacion.TabIndex = 8;
            this.lblConfirmacion.Text = "Confirmar contraseña";
            //
            // txtConfirmacion
            //
            this.txtConfirmacion.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtConfirmacion.Location = new System.Drawing.Point(27, 296);
            this.txtConfirmacion.MaxLength = 50;
            this.txtConfirmacion.Name = "txtConfirmacion";
            this.txtConfirmacion.Size = new System.Drawing.Size(460, 27);
            this.txtConfirmacion.TabIndex = 9;
            this.txtConfirmacion.UseSystemPasswordChar = true;
            //
            // lblMensaje
            //
            this.lblMensaje.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblMensaje.ForeColor = System.Drawing.Color.FromArgb(196, 43, 28);
            this.lblMensaje.Location = new System.Drawing.Point(24, 336);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(490, 40);
            this.lblMensaje.TabIndex = 10;
            this.lblMensaje.Text = "Mensaje";
            this.lblMensaje.Visible = false;
            //
            // btnGuardar
            //
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(0, 120, 212);
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(27, 392);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(150, 40);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            //
            // btnLimpiar
            //
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 204, 210);
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(32, 33, 36);
            this.btnLimpiar.Location = new System.Drawing.Point(187, 392);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(150, 40);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            //
            // errValidacion
            //
            this.errValidacion.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errValidacion.ContainerControl = this;
            //
            // frmRegistroUsuario
            //
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(243, 246, 250);
            this.ClientSize = new System.Drawing.Size(860, 600);
            this.Controls.Add(this.pnlTarjeta);
            this.Name = "frmRegistroUsuario";
            this.Text = "Registrar usuario";
            this.pnlTarjeta.ResumeLayout(false);
            this.pnlTarjeta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errValidacion)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTarjeta;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblConfirmacion;
        private System.Windows.Forms.TextBox txtConfirmacion;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ErrorProvider errValidacion;
    }
}
