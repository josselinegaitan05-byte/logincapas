namespace Presentacion.Formularios
{
    partial class frmInicio
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
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lblIndicacion = new System.Windows.Forms.Label();
            this.pnlCodigo = new System.Windows.Forms.Panel();
            this.lblCodigoValor = new System.Windows.Forms.Label();
            this.lblCodigoTitulo = new System.Windows.Forms.Label();
            this.pnlCreacion = new System.Windows.Forms.Panel();
            this.lblCreacionValor = new System.Windows.Forms.Label();
            this.lblCreacionTitulo = new System.Windows.Forms.Label();
            this.pnlSesion = new System.Windows.Forms.Panel();
            this.lblSesionValor = new System.Windows.Forms.Label();
            this.lblSesionTitulo = new System.Windows.Forms.Label();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblInfoTexto = new System.Windows.Forms.Label();
            this.lblInfoTitulo = new System.Windows.Forms.Label();
            this.pnlCodigo.SuspendLayout();
            this.pnlCreacion.SuspendLayout();
            this.pnlSesion.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.SuspendLayout();
            //
            // lblBienvenida
            //
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe UI Semibold", 22F);
            this.lblBienvenida.ForeColor = System.Drawing.Color.FromArgb(32, 33, 36);
            this.lblBienvenida.Location = new System.Drawing.Point(28, 26);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(200, 41);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "¡Bienvenido!";
            //
            // lblIndicacion
            //
            this.lblIndicacion.AutoSize = true;
            this.lblIndicacion.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblIndicacion.ForeColor = System.Drawing.Color.FromArgb(95, 99, 104);
            this.lblIndicacion.Location = new System.Drawing.Point(32, 72);
            this.lblIndicacion.Name = "lblIndicacion";
            this.lblIndicacion.Size = new System.Drawing.Size(420, 19);
            this.lblIndicacion.TabIndex = 1;
            this.lblIndicacion.Text = "Use el menú de la izquierda para registrar usuarios o jugar Craps.";
            //
            // pnlCodigo
            //
            this.pnlCodigo.BackColor = System.Drawing.Color.White;
            this.pnlCodigo.Controls.Add(this.lblCodigoValor);
            this.pnlCodigo.Controls.Add(this.lblCodigoTitulo);
            this.pnlCodigo.Location = new System.Drawing.Point(32, 116);
            this.pnlCodigo.Name = "pnlCodigo";
            this.pnlCodigo.Size = new System.Drawing.Size(240, 100);
            this.pnlCodigo.TabIndex = 2;
            //
            // lblCodigoTitulo
            //
            this.lblCodigoTitulo.AutoSize = true;
            this.lblCodigoTitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblCodigoTitulo.ForeColor = System.Drawing.Color.FromArgb(95, 99, 104);
            this.lblCodigoTitulo.Location = new System.Drawing.Point(18, 16);
            this.lblCodigoTitulo.Name = "lblCodigoTitulo";
            this.lblCodigoTitulo.Size = new System.Drawing.Size(117, 17);
            this.lblCodigoTitulo.TabIndex = 0;
            this.lblCodigoTitulo.Text = "Código de usuario";
            //
            // lblCodigoValor
            //
            this.lblCodigoValor.AutoSize = true;
            this.lblCodigoValor.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblCodigoValor.ForeColor = System.Drawing.Color.FromArgb(0, 120, 212);
            this.lblCodigoValor.Location = new System.Drawing.Point(15, 42);
            this.lblCodigoValor.Name = "lblCodigoValor";
            this.lblCodigoValor.Size = new System.Drawing.Size(30, 37);
            this.lblCodigoValor.TabIndex = 1;
            this.lblCodigoValor.Text = "—";
            //
            // pnlCreacion
            //
            this.pnlCreacion.BackColor = System.Drawing.Color.White;
            this.pnlCreacion.Controls.Add(this.lblCreacionValor);
            this.pnlCreacion.Controls.Add(this.lblCreacionTitulo);
            this.pnlCreacion.Location = new System.Drawing.Point(290, 116);
            this.pnlCreacion.Name = "pnlCreacion";
            this.pnlCreacion.Size = new System.Drawing.Size(240, 100);
            this.pnlCreacion.TabIndex = 3;
            //
            // lblCreacionTitulo
            //
            this.lblCreacionTitulo.AutoSize = true;
            this.lblCreacionTitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblCreacionTitulo.ForeColor = System.Drawing.Color.FromArgb(95, 99, 104);
            this.lblCreacionTitulo.Location = new System.Drawing.Point(18, 16);
            this.lblCreacionTitulo.Name = "lblCreacionTitulo";
            this.lblCreacionTitulo.Size = new System.Drawing.Size(113, 17);
            this.lblCreacionTitulo.TabIndex = 0;
            this.lblCreacionTitulo.Text = "Usuario creado el";
            //
            // lblCreacionValor
            //
            this.lblCreacionValor.AutoSize = true;
            this.lblCreacionValor.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblCreacionValor.ForeColor = System.Drawing.Color.FromArgb(0, 120, 212);
            this.lblCreacionValor.Location = new System.Drawing.Point(15, 42);
            this.lblCreacionValor.Name = "lblCreacionValor";
            this.lblCreacionValor.Size = new System.Drawing.Size(30, 37);
            this.lblCreacionValor.TabIndex = 1;
            this.lblCreacionValor.Text = "—";
            //
            // pnlSesion
            //
            this.pnlSesion.BackColor = System.Drawing.Color.White;
            this.pnlSesion.Controls.Add(this.lblSesionValor);
            this.pnlSesion.Controls.Add(this.lblSesionTitulo);
            this.pnlSesion.Location = new System.Drawing.Point(548, 116);
            this.pnlSesion.Name = "pnlSesion";
            this.pnlSesion.Size = new System.Drawing.Size(240, 100);
            this.pnlSesion.TabIndex = 4;
            //
            // lblSesionTitulo
            //
            this.lblSesionTitulo.AutoSize = true;
            this.lblSesionTitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblSesionTitulo.ForeColor = System.Drawing.Color.FromArgb(95, 99, 104);
            this.lblSesionTitulo.Location = new System.Drawing.Point(18, 16);
            this.lblSesionTitulo.Name = "lblSesionTitulo";
            this.lblSesionTitulo.Size = new System.Drawing.Size(137, 17);
            this.lblSesionTitulo.TabIndex = 0;
            this.lblSesionTitulo.Text = "Sesión iniciada a las";
            //
            // lblSesionValor
            //
            this.lblSesionValor.AutoSize = true;
            this.lblSesionValor.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblSesionValor.ForeColor = System.Drawing.Color.FromArgb(0, 120, 212);
            this.lblSesionValor.Location = new System.Drawing.Point(15, 42);
            this.lblSesionValor.Name = "lblSesionValor";
            this.lblSesionValor.Size = new System.Drawing.Size(30, 37);
            this.lblSesionValor.TabIndex = 1;
            this.lblSesionValor.Text = "—";
            //
            // pnlInfo
            //
            this.pnlInfo.BackColor = System.Drawing.Color.White;
            this.pnlInfo.Controls.Add(this.lblInfoTexto);
            this.pnlInfo.Controls.Add(this.lblInfoTitulo);
            this.pnlInfo.Location = new System.Drawing.Point(32, 236);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(756, 150);
            this.pnlInfo.TabIndex = 5;
            //
            // lblInfoTitulo
            //
            this.lblInfoTitulo.AutoSize = true;
            this.lblInfoTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.lblInfoTitulo.ForeColor = System.Drawing.Color.FromArgb(32, 33, 36);
            this.lblInfoTitulo.Location = new System.Drawing.Point(18, 16);
            this.lblInfoTitulo.Name = "lblInfoTitulo";
            this.lblInfoTitulo.Size = new System.Drawing.Size(180, 20);
            this.lblInfoTitulo.TabIndex = 0;
            this.lblInfoTitulo.Text = "Cómo está construido";
            //
            // lblInfoTexto
            //
            this.lblInfoTexto.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblInfoTexto.ForeColor = System.Drawing.Color.FromArgb(95, 99, 104);
            this.lblInfoTexto.Location = new System.Drawing.Point(18, 44);
            this.lblInfoTexto.Name = "lblInfoTexto";
            this.lblInfoTexto.Size = new System.Drawing.Size(720, 96);
            this.lblInfoTexto.TabIndex = 1;
            this.lblInfoTexto.Text = "• Patrón MVP: cada formulario es una Vista (interfaz) y su Presentador decide qué mostrar.\r\n• Capa de Negocio con dos contratos: IHashService (generar hash) e IVerificarHashService (verificar).\r\n• Capa de Datos con procedimientos almacenados y un usuario de MySQL con privilegios mínimos.\r\n• Contraseñas guardadas como hash SHA-512 (VARBINARY(64)), nunca en texto plano.";
            //
            // frmInicio
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(243, 246, 250);
            this.ClientSize = new System.Drawing.Size(860, 600);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.pnlSesion);
            this.Controls.Add(this.pnlCreacion);
            this.Controls.Add(this.pnlCodigo);
            this.Controls.Add(this.lblIndicacion);
            this.Controls.Add(this.lblBienvenida);
            this.Name = "frmInicio";
            this.Text = "Inicio";
            this.pnlCodigo.ResumeLayout(false);
            this.pnlCodigo.PerformLayout();
            this.pnlCreacion.ResumeLayout(false);
            this.pnlCreacion.PerformLayout();
            this.pnlSesion.ResumeLayout(false);
            this.pnlSesion.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Label lblIndicacion;
        private System.Windows.Forms.Panel pnlCodigo;
        private System.Windows.Forms.Label lblCodigoTitulo;
        private System.Windows.Forms.Label lblCodigoValor;
        private System.Windows.Forms.Panel pnlCreacion;
        private System.Windows.Forms.Label lblCreacionTitulo;
        private System.Windows.Forms.Label lblCreacionValor;
        private System.Windows.Forms.Panel pnlSesion;
        private System.Windows.Forms.Label lblSesionTitulo;
        private System.Windows.Forms.Label lblSesionValor;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblInfoTitulo;
        private System.Windows.Forms.Label lblInfoTexto;
    }
}
