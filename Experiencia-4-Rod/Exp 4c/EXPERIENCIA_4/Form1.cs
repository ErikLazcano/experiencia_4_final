using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXPERIENCIA_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.usach.cl/");
        }

        private void btn_Ir_Click(object sender, EventArgs e)
        {
            string URL; // creamos la variable donde se guardará la direccion donde quiero ir
            URL = txt_URL.Text; // se guardará el conetenido del cuadro de texto donde el usuario escribe hacia donde 
                                //quiere navegar
            if (URL.Contains("facebook") || URL.Contains("instagram") || URL.Contains("twiter") || URL.Contains("tiktok") || URL.Contains("netflix"))
            {
                MessageBox.Show("No puedes ingresar a este sitio");
                webBrowser1.Stop(); // Se detiende la navegacion
            }
            else
            {
                webBrowser1.Navigate(URL); // vamos hacia la direccion
            }  
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack(); // vamos a ir a atras
        }

        private void btn_forward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward(); // vamos a ir adelante
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close(); // cerraremos todo el formulario
        }

        private void cbox_favoritos_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_URL.Text = cbox_favoritos.Text; // copia el contenido de combo box en el text box URL
            btn_Ir_Click(sender, e); // ejecuta el botón Ir.
        }

        private void chk_visible_CheckedChanged(object sender, EventArgs e)
        {
            if (!chk_visible.Checked)
            {
                Navegador.Visible = false; // oculta el navegador
                txt_pass_TextChanged(sender, e);
            }
            txt_pass.Visible = !chk_visible.Checked;
        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {
            string pass = txt_pass.Text;
            if (pass == "visualstudio")
            {
                Navegador.Visible = true;
                chk_visible.Checked = true;
            }
            else
            {
                Navegador.Visible = false;
                
            }
        }

        private void btn_cerrar_retardo_Click(object sender, EventArgs e)
        {
            temporizador_cierre.Enabled = true;
        }

        private void temporizador_cierre_Tick(object sender, EventArgs e)
        {
            this.Close(); // el temporizador cierra el formulario
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void txt_URL_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_URL_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txt_URL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                btn_Ir_Click(sender, e);// 
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
    
        }

        private void webBrowser1_Resize(object sender, EventArgs e)
        {

        }
    }
}
