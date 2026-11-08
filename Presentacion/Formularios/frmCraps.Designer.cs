namespace Presentacion.Formularios
{
    partial class frmCraps
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
            this.pnlMesa = new System.Windows.Forms.Panel();
            this.lblMarcador = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnLanzar = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.dado2Control = new Presentacion.Controles.DadoControl();
            this.dado1Control = new Presentacion.Controles.DadoControl();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.lblLanzamientosValor = new System.Windows.Forms.Label();
            this.lblLanzamientosTitulo = new System.Windows.Forms.Label();
            this.lblPuntoValor = new System.Windows.Forms.Label();
            this.lblPuntoTitulo = new System.Windows.Forms.Label();
            this.lblSumaValor = new System.Windows.Forms.Label();
            this.lblSumaTitulo = new System.Windows.Forms.Label();
            this.lblReglas = new System.Windows.Forms.Label();
            this.pnlMesa.SuspendLayout();
            this.pnlDatos.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlMesa
            //
            this.pnlMesa.BackColor = System.Drawing.Color.White;
            this.pnlMesa.Controls.Add(this.lblMarcador);
            this.pnlMesa.Controls.Add(this.btnNuevo);
            this.pnlMesa.Controls.Add(this.btnLanzar);
            this.pnlMesa.Controls.Add(this.lblMensaje);
            this.pnlMesa.Controls.Add(this.dado2Control);
            this.pnlMesa.Controls.Add(this.dado1Control);
            this.pnlMesa.Controls.Add(this.lblTitulo);
            this.pnlMesa.Location = new System.Drawing.Point(32, 24);
            this.pnlMesa.Name = "pnlMesa";
            this.pnlMesa.Size = new System.Drawing.Size(500, 420);
            this.pnlMesa.TabIndex = 0;
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(32, 33, 36);
            this.lblTitulo.Location = new System.Drawing.Point(24, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(70, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Mesa de juego";
            //
            // dado1Control
            //
            this.dado1Control.Location = new System.Drawing.Point(100, 70);
            this.dado1Control.Name = "dado1Control";
            this.dado1Control.Size = new System.Drawing.Size(130, 130);
            this.dado1Control.TabIndex = 1;
            //
            // dado2Control
            //
            this.dado2Control.Location = new System.Drawing.Point(270, 70);
            this.dado2Control.Name = "dado2Control";
            this.dado2Control.Size = new System.Drawing.Size(130, 130);
            this.dado2Control.TabIndex = 2;
            //
            // lblMensaje
            //
            this.lblMensaje.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.lblMensaje.ForeColor = System.Drawing.Color.FromArgb(95, 99, 104);
            this.lblMensaje.Location = new System.Drawing.Point(24, 220);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(452, 60);
            this.lblMensaje.TabIndex = 3;
            this.lblMensaje.Text = "Mensaje";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // btnLanzar
            //
            this.btnLanzar.BackColor = System.Drawing.Color.FromArgb(0, 120, 212);
            this.btnLanzar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLanzar.FlatAppearance.BorderSize = 0;
            this.btnLanzar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLanzar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.btnLanzar.ForeColor = System.Drawing.Color.White;
            this.btnLanzar.Location = new System.Drawing.Point(90, 296);
            this.btnLanzar.Name = "btnLanzar";
            this.btnLanzar.Size = new System.Drawing.Size(160, 44);
            this.btnLanzar.TabIndex = 4;
            this.btnLanzar.Text = "Lanzar dados";
            this.btnLanzar.UseVisualStyleBackColor = false;
            this.btnLanzar.Click += new System.EventHandler(this.btnLanzar_Click);
            //
            // btnNuevo
            //
            this.btnNuevo.BackColor = System.Drawing.Color.White;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 204, 210);
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnNuevo.ForeColor = System.Drawing.Color.FromArgb(32, 33, 36);
            this.btnNuevo.Location = new System.Drawing.Point(260, 296);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(160, 44);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.Text = "Nuevo juego";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            //
            // lblMarcador
            //
            this.lblMarcador.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblMarcador.ForeColor = System.Drawing.Color.FromArgb(95, 99, 104);
            this.lblMarcador.Location = new System.Drawing.Point(24, 360);
            this.lblMarcador.Name = "lblMarcador";
            this.lblMarcador.Size = new System.Drawing.Size(452, 24);
            this.lblMarcador.TabIndex = 6;
            this.lblMarcador.Text = "Ganadas 0 · Perdidas 0";
            this.lblMarcador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // pnlDatos
            //
            this.pnlDatos.BackColor = System.Drawing.Color.White;
            this.pnlDatos.Controls.Add(this.lblReglas);
            this.pnlDatos.Controls.Add(this.lblLanzamientosValor);
            this.pnlDatos.Controls.Add(this.lblLanzamientosTitulo);
            this.pnlDatos.Controls.Add(this.lblPuntoValor);
            this.pnlDatos.Controls.Add(this.lblPuntoTitulo);
            this.pnlDatos.Controls.Add(this.lblSumaValor);
            this.pnlDatos.Controls.Add(this.lblSumaTitulo);
            this.pnlDatos.Location = new System.Drawing.Point(550, 24);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(270, 420);
            this.pnlDatos.TabIndex = 1;
            //
            // lblSumaTitulo
            //
            this.lblSumaTitulo.AutoSize = true;
            this.lblSumaTitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblSumaTitulo.ForeColor = System.Drawing.Color.FromArgb(95, 99, 104);
            this.lblSumaTitulo.Location = new System.Drawing.Point(20, 20);
            this.lblSumaTitulo.Name = "lblSumaTitulo";
            this.lblSumaTitulo.Size = new System.Drawing.Size(40, 17);
            this.lblSumaTitulo.TabIndex = 0;
            this.lblSumaTitulo.Text = "Suma";
            //
            // lblSumaValor
            //
            this.lblSumaValor.AutoSize = true;
            this.lblSumaValor.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblSumaValor.ForeColor = System.Drawing.Color.FromArgb(32, 33, 36);
            this.lblSumaValor.Location = new System.Drawing.Point(16, 38);
            this.lblSumaValor.Name = "lblSumaValor";
            this.lblSumaValor.Size = new System.Drawing.Size(40, 45);
            this.lblSumaValor.TabIndex = 1;
            this.lblSumaValor.Text = "—";
            //
            // lblPuntoTitulo
            //
            this.lblPuntoTitulo.AutoSize = true;
            this.lblPuntoTitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblPuntoTitulo.ForeColor = System.Drawing.Color.FromArgb(95, 99, 104);
            this.lblPuntoTitulo.Location = new System.Drawing.Point(140, 20);
            this.lblPuntoTitulo.Name = "lblPuntoTitulo";
            this.lblPuntoTitulo.Size = new System.Drawing.Size(43, 17);
            this.lblPuntoTitulo.TabIndex = 2;
            this.lblPuntoTitulo.Text = "Punto";
            //
            // lblPuntoValor
            //
            this.lblPuntoValor.AutoSize = true;
            this.lblPuntoValor.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblPuntoValor.ForeColor = System.Drawing.Color.FromArgb(0, 120, 212);
            this.lblPuntoValor.Location = new System.Drawing.Point(136, 38);
            this.lblPuntoValor.Name = "lblPuntoValor";
            this.lblPuntoValor.Size = new System.Drawing.Size(40, 45);
            this.lblPuntoValor.TabIndex = 3;
            this.lblPuntoValor.Text = "—";
            //
            // lblLanzamientosTitulo
            //
            this.lblLanzamientosTitulo.AutoSize = true;
            this.lblLanzamientosTitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblLanzamientosTitulo.ForeColor = System.Drawing.Color.FromArgb(95, 99, 104);
            this.lblLanzamientosTitulo.Location = new System.Drawing.Point(20, 96);
            this.lblLanzamientosTitulo.Name = "lblLanzamientosTitulo";
            this.lblLanzamientosTitulo.Size = new System.Drawing.Size(89, 17);
            this.lblLanzamientosTitulo.TabIndex = 4;
            this.lblLanzamientosTitulo.Text = "Lanzamientos";
            //
            // lblLanzamientosValor
            //
            this.lblLanzamientosValor.AutoSize = true;
            this.lblLanzamientosValor.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblLanzamientosValor.ForeColor = System.Drawing.Color.FromArgb(32, 33, 36);
            this.lblLanzamientosValor.Location = new System.Drawing.Point(16, 114);
            this.lblLanzamientosValor.Name = "lblLanzamientosValor";
            this.lblLanzamientosValor.Size = new System.Drawing.Size(38, 45);
            this.lblLanzamientosValor.TabIndex = 5;
            this.lblLanzamientosValor.Text = "0";
            //
            // lblReglas
            //
            this.lblReglas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblReglas.ForeColor = System.Drawing.Color.FromArgb(95, 99, 104);
            this.lblReglas.Location = new System.Drawing.Point(20, 180);
            this.lblReglas.Name = "lblReglas";
            this.lblReglas.Size = new System.Drawing.Size(235, 220);
            this.lblReglas.TabIndex = 6;
            this.lblReglas.Text = "REGLAS\r\n\r\nPrimer lanzamiento:\r\n• 7 u 11: gana.\r\n• 2, 3 o 12 (craps): pierde.\r\n• Otro valor: se convierte en el punto.\r\n\r\nSiguientes lanzamientos:\r\n• Sacar el punto otra vez: gana.\r\n• Sacar 7: pierde.";
            //
            // frmCraps
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(243, 246, 250);
            this.ClientSize = new System.Drawing.Size(860, 600);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.pnlMesa);
            this.Name = "frmCraps";
            this.Text = "Juego de Craps";
            this.pnlMesa.ResumeLayout(false);
            this.pnlMesa.PerformLayout();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlMesa;
        private System.Windows.Forms.Label lblTitulo;
        private Presentacion.Controles.DadoControl dado1Control;
        private Presentacion.Controles.DadoControl dado2Control;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnLanzar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblMarcador;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Label lblSumaTitulo;
        private System.Windows.Forms.Label lblSumaValor;
        private System.Windows.Forms.Label lblPuntoTitulo;
        private System.Windows.Forms.Label lblPuntoValor;
        private System.Windows.Forms.Label lblLanzamientosTitulo;
        private System.Windows.Forms.Label lblLanzamientosValor;
        private System.Windows.Forms.Label lblReglas;
    }
}
