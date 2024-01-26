
namespace Login
{
    partial class FormBg
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelUp = new System.Windows.Forms.Panel();
            this.BtnMaximizar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnEntrar = new System.Windows.Forms.Button();
            this.panelUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            // 
            // panelUp
            // 
            this.panelUp.Controls.Add(this.BtnMaximizar);
            this.panelUp.Controls.Add(this.BtnCerrar);
            this.panelUp.Controls.Add(this.labelLogin);
            this.panelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelUp.Location = new System.Drawing.Point(200, 0);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(552, 40);
            this.panelUp.TabIndex = 1;
            // 
            // BtnMaximizar
            // 
            this.BtnMaximizar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnMaximizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnMaximizar.FlatAppearance.BorderSize = 0;
            this.BtnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMaximizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMaximizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnMaximizar.Location = new System.Drawing.Point(486, 0);
            this.BtnMaximizar.Name = "BtnMaximizar";
            this.BtnMaximizar.Size = new System.Drawing.Size(33, 40);
            this.BtnMaximizar.TabIndex = 2;
            this.BtnMaximizar.Text = "-";
            this.BtnMaximizar.UseVisualStyleBackColor = false;
            this.BtnMaximizar.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCerrar.Location = new System.Drawing.Point(519, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(33, 40);
            this.BtnCerrar.TabIndex = 1;
            this.BtnCerrar.Text = "x";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelLogin.Location = new System.Drawing.Point(0, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(96, 37);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Login";
            this.labelLogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelUsuario.Location = new System.Drawing.Point(261, 77);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(74, 24);
            this.labelUsuario.TabIndex = 2;
            this.labelUsuario.Text = "Usuario";
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContraseña.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelContraseña.Location = new System.Drawing.Point(261, 206);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(106, 24);
            this.labelContraseña.TabIndex = 3;
            this.labelContraseña.Text = "Contraseña";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUsuario.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.TxtUsuario.Location = new System.Drawing.Point(265, 118);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(261, 13);
            this.TxtUsuario.TabIndex = 2;
            this.TxtUsuario.Text = "Ingrese su nombre de usuario";
            this.TxtUsuario.TextChanged += new System.EventHandler(this.UsuarioTxt_TextChanged);
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContraseña.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TxtContraseña.Location = new System.Drawing.Point(265, 245);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.Size = new System.Drawing.Size(261, 15);
            this.TxtContraseña.TabIndex = 1;
            this.TxtContraseña.Text = "********";
            this.TxtContraseña.TextChanged += new System.EventHandler(this.TxtContraseña_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Location = new System.Drawing.Point(265, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 1);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Location = new System.Drawing.Point(265, 266);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(322, 1);
            this.panel3.TabIndex = 5;
            // 
            // BtnEntrar
            // 
            this.BtnEntrar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnEntrar.FlatAppearance.BorderSize = 0;
            this.BtnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEntrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEntrar.Location = new System.Drawing.Point(502, 300);
            this.BtnEntrar.Name = "BtnEntrar";
            this.BtnEntrar.Size = new System.Drawing.Size(85, 37);
            this.BtnEntrar.TabIndex = 6;
            this.BtnEntrar.Text = "Entrar";
            this.BtnEntrar.UseVisualStyleBackColor = false;
            this.BtnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // FormBg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(752, 450);
            this.Controls.Add(this.BtnEntrar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TxtContraseña);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.labelContraseña);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.panelUp);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelUp.ResumeLayout(false);
            this.panelUp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelUp;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Button BtnMaximizar;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnEntrar;
    }
}

