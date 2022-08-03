namespace EXPERIENCIA_4
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Navegador = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.txt_URL = new System.Windows.Forms.TextBox();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_Ir = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_forward = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.cbox_favoritos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_visible = new System.Windows.Forms.CheckBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.btn_cerrar_retardo = new System.Windows.Forms.Button();
            this.temporizador_cierre = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.Navegador.SuspendLayout();
            this.SuspendLayout();
            // 
            // Navegador
            // 
            this.Navegador.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Navegador.Controls.Add(this.webBrowser1);
            this.Navegador.Location = new System.Drawing.Point(15, 80);
            this.Navegador.Name = "Navegador";
            this.Navegador.Size = new System.Drawing.Size(962, 376);
            this.Navegador.TabIndex = 0;
            this.Navegador.TabStop = false;
            this.Navegador.Text = "Navegador";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(3, 18);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(935, 334);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.webBrowser1.Resize += new System.EventHandler(this.webBrowser1_Resize);
            // 
            // txt_URL
            // 
            this.txt_URL.Location = new System.Drawing.Point(93, 15);
            this.txt_URL.Name = "txt_URL";
            this.txt_URL.Size = new System.Drawing.Size(569, 22);
            this.txt_URL.TabIndex = 1;
            this.txt_URL.TextChanged += new System.EventHandler(this.txt_URL_TextChanged_1);
            this.txt_URL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_URL_KeyPress);
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(923, 9);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(54, 27);
            this.btn_home.TabIndex = 2;
            this.btn_home.Text = "Inicio";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_Ir
            // 
            this.btn_Ir.Location = new System.Drawing.Point(678, 9);
            this.btn_Ir.Name = "btn_Ir";
            this.btn_Ir.Size = new System.Drawing.Size(72, 27);
            this.btn_Ir.TabIndex = 3;
            this.btn_Ir.Text = "Ir";
            this.btn_Ir.UseVisualStyleBackColor = true;
            this.btn_Ir.Click += new System.EventHandler(this.btn_Ir_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(849, 9);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(57, 27);
            this.btn_back.TabIndex = 4;
            this.btn_back.Text = "Atrás";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_forward
            // 
            this.btn_forward.Location = new System.Drawing.Point(756, 9);
            this.btn_forward.Name = "btn_forward";
            this.btn_forward.Size = new System.Drawing.Size(78, 28);
            this.btn_forward.TabIndex = 5;
            this.btn_forward.Text = "Adelante";
            this.btn_forward.UseVisualStyleBackColor = true;
            this.btn_forward.Click += new System.EventHandler(this.btn_forward_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.Location = new System.Drawing.Point(899, 462);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 6;
            this.btn_close.Text = "Cerrar";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // cbox_favoritos
            // 
            this.cbox_favoritos.FormattingEnabled = true;
            this.cbox_favoritos.Items.AddRange(new object[] {
            "www.google.cl",
            "www.youtube.cl",
            "www.googlemaps.com",
            "www.facebook.com"});
            this.cbox_favoritos.Location = new System.Drawing.Point(93, 47);
            this.cbox_favoritos.Name = "cbox_favoritos";
            this.cbox_favoritos.Size = new System.Drawing.Size(707, 24);
            this.cbox_favoritos.TabIndex = 7;
            this.cbox_favoritos.SelectedIndexChanged += new System.EventHandler(this.cbox_favoritos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Favoritos";
            // 
            // chk_visible
            // 
            this.chk_visible.AutoSize = true;
            this.chk_visible.Checked = true;
            this.chk_visible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_visible.Location = new System.Drawing.Point(823, 49);
            this.chk_visible.Name = "chk_visible";
            this.chk_visible.Size = new System.Drawing.Size(70, 20);
            this.chk_visible.TabIndex = 9;
            this.chk_visible.Text = "Visible";
            this.chk_visible.UseVisualStyleBackColor = true;
            this.chk_visible.CheckedChanged += new System.EventHandler(this.chk_visible_CheckedChanged);
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(899, 49);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(75, 22);
            this.txt_pass.TabIndex = 10;
            this.txt_pass.Visible = false;
            this.txt_pass.TextChanged += new System.EventHandler(this.txt_pass_TextChanged);
            // 
            // btn_cerrar_retardo
            // 
            this.btn_cerrar_retardo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar_retardo.Location = new System.Drawing.Point(747, 462);
            this.btn_cerrar_retardo.Name = "btn_cerrar_retardo";
            this.btn_cerrar_retardo.Size = new System.Drawing.Size(137, 23);
            this.btn_cerrar_retardo.TabIndex = 11;
            this.btn_cerrar_retardo.Text = "Cerrar retardado";
            this.btn_cerrar_retardo.UseVisualStyleBackColor = true;
            this.btn_cerrar_retardo.Click += new System.EventHandler(this.btn_cerrar_retardo_Click);
            // 
            // temporizador_cierre
            // 
            this.temporizador_cierre.Interval = 5000;
            this.temporizador_cierre.Tick += new System.EventHandler(this.temporizador_cierre_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1001, 497);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_cerrar_retardo);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.chk_visible);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbox_favoritos);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_forward);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_Ir);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.txt_URL);
            this.Controls.Add(this.Navegador);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Navegador Web";
            this.Resize += new System.EventHandler(this.webBrowser1_Resize);
            this.Navegador.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Navegador;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox txt_URL;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_Ir;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_forward;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.ComboBox cbox_favoritos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_visible;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Button btn_cerrar_retardo;
        private System.Windows.Forms.Timer temporizador_cierre;
        private System.Windows.Forms.Button button1;
    }
}

