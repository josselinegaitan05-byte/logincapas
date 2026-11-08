namespace Presentacion.Formularios
{
    partial class frmPrincipal
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnCraps = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.pnlSesion = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.lblDetalleSesion = new System.Windows.Forms.Label();
            this.lblUsuarioSesion = new System.Windows.Forms.Label();
            this.avatar = new Presentacion.Controles.AvatarControl();
            this.lblSesionTitulo = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblLogoSub = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlBarra = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblSeccion = new System.Windows.Forms.Label();
            this.tmrReloj = new System.Windows.Forms.Timer(this.components);
            this.pnlMenu.SuspendLayout();
            this.pnlSesion.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlBarra.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlMenu
            //
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(20, 39, 78);
            this.pnlMenu.Controls.Add(this.pnlSesion);
            this.pnlMenu.Controls.Add(this.btnCraps);
            this.pnlMenu.Controls.Add(this.btnUsuarios);
            this.pnlMenu.Controls.Add(this.btnInicio);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(230, 680);
            this.pnlMenu.TabIndex = 0;
            //
            // pnlLogo
            //
            this.pnlLogo.Controls.Add(this.lblLogoSub);
            this.pnlLogo.Controls.Add(this.lblLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(230, 96);
            this.pnlLogo.TabIndex = 0;
            //
            // lblLogo
            //
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(18, 24);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(136, 31);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "LOGIN MVP";
            //
            // lblLogoSub
            //
            this.lblLogoSub.AutoSize = true;
            this.lblLogoSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLogoSub.ForeColor = System.Drawing.Color.FromArgb(214, 224, 240);
            this.lblLogoSub.Location = new System.Drawing.Point(21, 58);
            this.lblLogoSub.Name = "lblLogoSub";
            this.lblLogoSub.Size = new System.Drawing.Size(130, 15);
            this.lblLogoSub.TabIndex = 1;
            this.lblLogoSub.Text = "Capas · C# · MySQL";
            //
            // btnInicio
            //
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(20, 39, 78);
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(33, 58, 110);
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnInicio.ForeColor = System.Drawing.Color.FromArgb(214, 224, 240);
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(0, 96);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnInicio.Size = new System.Drawing.Size(230, 50);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "   Inicio";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            //
            // btnUsuarios
            //
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(20, 39, 78);
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(33, 58, 110);
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnUsuarios.ForeColor = System.Drawing.Color.FromArgb(214, 224, 240);
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 146);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnUsuarios.Size = new System.Drawing.Size(230, 50);
            this.btnUsuarios.TabIndex = 2;
            this.btnUsuarios.Text = "   Registrar usuario";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            //
            // btnCraps
            //
            this.btnCraps.BackColor = System.Drawing.Color.FromArgb(20, 39, 78);
            this.btnCraps.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCraps.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCraps.FlatAppearance.BorderSize = 0;
            this.btnCraps.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(33, 58, 110);
            this.btnCraps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCraps.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnCraps.ForeColor = System.Drawing.Color.FromArgb(214, 224, 240);
            this.btnCraps.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCraps.Location = new System.Drawing.Point(0, 196);
            this.btnCraps.Name = "btnCraps";
            this.btnCraps.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnCraps.Size = new System.Drawing.Size(230, 50);
            this.btnCraps.TabIndex = 3;
            this.btnCraps.Text = "   Juego de Craps";
            this.btnCraps.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCraps.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCraps.UseVisualStyleBackColor = false;
            this.btnCraps.Click += new System.EventHandler(this.btnCraps_Click);
            //
            // pnlSesion
            //
            this.pnlSesion.BackColor = System.Drawing.Color.FromArgb(15, 30, 61);
            this.pnlSesion.Controls.Add(this.btnCerrarSesion);
            this.pnlSesion.Controls.Add(this.lblDetalleSesion);
            this.pnlSesion.Controls.Add(this.lblUsuarioSesion);
            this.pnlSesion.Controls.Add(this.avatar);
            this.pnlSesion.Controls.Add(this.lblSesionTitulo);
            this.pnlSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSesion.Location = new System.Drawing.Point(0, 540);
            this.pnlSesion.Name = "pnlSesion";
            this.pnlSesion.Size = new System.Drawing.Size(230, 140);
            this.pnlSesion.TabIndex = 4;
            //
            // lblSesionTitulo
            //
            this.lblSesionTitulo.AutoSize = true;
            this.lblSesionTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
            this.lblSesionTitulo.ForeColor = System.Drawing.Color.FromArgb(140, 160, 195);
            this.lblSesionTitulo.Location = new System.Drawing.Point(18, 12);
            this.lblSesionTitulo.Name = "lblSesionTitulo";
            this.lblSesionTitulo.Size = new System.Drawing.Size(84, 13);
            this.lblSesionTitulo.TabIndex = 0;
            this.lblSesionTitulo.Text = "SESIÓN ACTIVA";
            //
            // avatar
            //
            this.avatar.Location = new System.Drawing.Point(18, 34);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(44, 44);
            this.avatar.TabIndex = 1;
            //
            // lblUsuarioSesion
            //
            this.lblUsuarioSesion.AutoEllipsis = true;
            this.lblUsuarioSesion.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.lblUsuarioSesion.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioSesion.Location = new System.Drawing.Point(70, 34);
            this.lblUsuarioSesion.Name = "lblUsuarioSesion";
            this.lblUsuarioSesion.Size = new System.Drawing.Size(150, 22);
            this.lblUsuarioSesion.TabIndex = 2;
            this.lblUsuarioSesion.Text = "usuario";
            //
            // lblDetalleSesion
            //
            this.lblDetalleSesion.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblDetalleSesion.ForeColor = System.Drawing.Color.FromArgb(180, 195, 220);
            this.lblDetalleSesion.Location = new System.Drawing.Point(71, 56);
            this.lblDetalleSesion.Name = "lblDetalleSesion";
            this.lblDetalleSesion.Size = new System.Drawing.Size(155, 30);
            this.lblDetalleSesion.TabIndex = 3;
            this.lblDetalleSesion.Text = "detalle";
            //
            // btnCerrarSesion
            //
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(15, 30, 61);
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 85, 135);
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(33, 58, 110);
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(214, 224, 240);
            this.btnCerrarSesion.Location = new System.Drawing.Point(18, 94);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(194, 32);
            this.btnCerrarSesion.TabIndex = 4;
            this.btnCerrarSesion.Text = " Cerrar sesión";
            this.btnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            //
            // pnlBarra
            //
            this.pnlBarra.BackColor = System.Drawing.Color.White;
            this.pnlBarra.Controls.Add(this.lblFecha);
            this.pnlBarra.Controls.Add(this.lblHora);
            this.pnlBarra.Controls.Add(this.lblSeccion);
            this.pnlBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarra.Location = new System.Drawing.Point(230, 0);
            this.pnlBarra.Name = "pnlBarra";
            this.pnlBarra.Size = new System.Drawing.Size(870, 72);
            this.pnlBarra.TabIndex = 1;
            //
            // lblSeccion
            //
            this.lblSeccion.AutoSize = true;
            this.lblSeccion.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F);
            this.lblSeccion.ForeColor = System.Drawing.Color.FromArgb(32, 33, 36);
            this.lblSeccion.Location = new System.Drawing.Point(28, 20);
            this.lblSeccion.Name = "lblSeccion";
            this.lblSeccion.Size = new System.Drawing.Size(64, 30);
            this.lblSeccion.TabIndex = 0;
            this.lblSeccion.Text = "Inicio";
            //
            // lblHora
            //
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(0, 120, 212);
            this.lblHora.Location = new System.Drawing.Point(500, 6);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(345, 36);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "00:00:00";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // lblFecha
            //
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(95, 99, 104);
            this.lblFecha.Location = new System.Drawing.Point(500, 42);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(345, 20);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "fecha";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // tmrReloj
            //
            this.tmrReloj.Enabled = true;
            this.tmrReloj.Interval = 1000;
            this.tmrReloj.Tick += new System.EventHandler(this.tmrReloj_Tick);
            //
            // frmPrincipal
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1100, 680);
            this.Controls.Add(this.pnlBarra);
            this.Controls.Add(this.pnlMenu);
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlSesion.ResumeLayout(false);
            this.pnlSesion.PerformLayout();
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.pnlBarra.ResumeLayout(false);
            this.pnlBarra.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblLogoSub;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnCraps;
        private System.Windows.Forms.Panel pnlSesion;
        private System.Windows.Forms.Label lblSesionTitulo;
        private Presentacion.Controles.AvatarControl avatar;
        private System.Windows.Forms.Label lblUsuarioSesion;
        private System.Windows.Forms.Label lblDetalleSesion;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Panel pnlBarra;
        private System.Windows.Forms.Label lblSeccion;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer tmrReloj;
    }
}
