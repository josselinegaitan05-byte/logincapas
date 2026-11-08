namespace Presentacion.Formularios
{
    partial class frmLogin
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
            this.pnlBanner = new System.Windows.Forms.Panel();
            this.lblBannerTexto = new System.Windows.Forms.Label();
            this.lblBannerTitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkMostrar = new System.Windows.Forms.CheckBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.errValidacion = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlBanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errValidacion)).BeginInit();
            this.SuspendLayout();
            //
            // pnlBanner
            //
            this.pnlBanner.BackColor = System.Drawing.Color.FromArgb(20, 39, 78);
            this.pnlBanner.Controls.Add(this.lblBannerTexto);
            this.pnlBanner.Controls.Add(this.lblBannerTitulo);
            this.pnlBanner.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBanner.Location = new System.Drawing.Point(0, 0);
            this.pnlBanner.Name = "pnlBanner";
            this.pnlBanner.Size = new System.Drawing.Size(250, 400);
            this.pnlBanner.TabIndex = 0;
            //
            // lblBannerTitulo
            //
            this.lblBannerTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 20F);
            this.lblBannerTitulo.ForeColor = System.Drawing.Color.White;
            this.lblBannerTitulo.Location = new System.Drawing.Point(24, 120);
            this.lblBannerTitulo.Name = "lblBannerTitulo";
            this.lblBannerTitulo.Size = new System.Drawing.Size(210, 80);
            this.lblBannerTitulo.TabIndex = 0;
            this.lblBannerTitulo.Text = "Sistema\r\nLogin MVP";
            //
            // lblBannerTexto
            //
            this.lblBannerTexto.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblBannerTexto.ForeColor = System.Drawing.Color.FromArgb(214, 224, 240);
            this.lblBannerTexto.Location = new System.Drawing.Point(26, 205);
            this.lblBannerTexto.Name = "lblBannerTexto";
            this.lblBannerTexto.Size = new System.Drawing.Size(205, 80);
            this.lblBannerTexto.TabIndex = 1;
            this.lblBannerTexto.Text = "Programación en capas con C#, Windows Forms y MySQL. Contraseñas protegidas con SHA-512.";
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(32, 33, 36);
            this.lblTitulo.Location = new System.Drawing.Point(290, 34);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(155, 32);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Iniciar sesión";
            //
            // lblSubtitulo
            //
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(95, 99, 104);
            this.lblSubtitulo.Location = new System.Drawing.Point(292, 70);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(230, 17);
            this.lblSubtitulo.TabIndex = 2;
            this.lblSubtitulo.Text = "Ingrese sus credenciales para continuar";
            //
            // lblUsuario
            //
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(32, 33, 36);
            this.lblUsuario.Location = new System.Drawing.Point(292, 110);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(53, 17);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario";
            //
            // txtUsuario
            //
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtUsuario.Location = new System.Drawing.Point(295, 132);
            this.txtUsuario.MaxLength = 50;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(330, 27);
            this.txtUsuario.TabIndex = 4;
            //
            // lblPassword
            //
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(32, 33, 36);
            this.lblPassword.Location = new System.Drawing.Point(292, 172);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(76, 17);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Contraseña";
            //
            // txtPassword
            //
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtPassword.Location = new System.Drawing.Point(295, 194);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(330, 27);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UseSystemPasswordChar = true;
            //
            // chkMostrar
            //
            this.chkMostrar.AutoSize = true;
            this.chkMostrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkMostrar.ForeColor = System.Drawing.Color.FromArgb(95, 99, 104);
            this.chkMostrar.Location = new System.Drawing.Point(295, 228);
            this.chkMostrar.Name = "chkMostrar";
            this.chkMostrar.Size = new System.Drawing.Size(131, 19);
            this.chkMostrar.TabIndex = 7;
            this.chkMostrar.Text = "Mostrar contraseña";
            this.chkMostrar.UseVisualStyleBackColor = true;
            this.chkMostrar.CheckedChanged += new System.EventHandler(this.chkMostrar_CheckedChanged);
            //
            // lblMensaje
            //
            this.lblMensaje.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblMensaje.ForeColor = System.Drawing.Color.FromArgb(196, 43, 28);
            this.lblMensaje.Location = new System.Drawing.Point(292, 255);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(340, 40);
            this.lblMensaje.TabIndex = 8;
            this.lblMensaje.Text = "Mensaje de validación";
            this.lblMensaje.Visible = false;
            //
            // btnIngresar
            //
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(0, 120, 212);
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F);
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(295, 302);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(160, 40);
            this.btnIngresar.TabIndex = 9;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            //
            // btnSalir
            //
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 204, 210);
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(32, 33, 36);
            this.btnSalir.Location = new System.Drawing.Point(465, 302);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(160, 40);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            //
            // errValidacion
            //
            this.errValidacion.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errValidacion.ContainerControl = this;
            //
            // frmLogin
            //
            this.AcceptButton = this.btnIngresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(670, 400);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.chkMostrar);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlBanner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login de Usuario";
            this.pnlBanner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errValidacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlBanner;
        private System.Windows.Forms.Label lblBannerTitulo;
        private System.Windows.Forms.Label lblBannerTexto;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkMostrar;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ErrorProvider errValidacion;
    }
}
