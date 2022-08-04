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
                txt_pass_TextChanged(sender, e); // ejecuta el codigo del txt_pass
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
/*
 *   CONCLUSIONES
 *   
 *   Erik Ramirez: aprendía a usar algunas propiedades de los objetos combobox, checkbox e interactuar con el evento keypress que se
 *   genera cuando se presiona una tecla dentro del cuadro de texto. Esto ultimo me pareció interesante puesto que no
 *   habia notado que se utiliza por defecto el evento de cambio de texto del text_box y que existen muchos más eventos
 *   que se pueden utilizar. También me pareció interesante el objeto timer que se puede ejecutar subrutinas por debajo de lo
 *   que esta ejecutando el usuario. Según lo que investigué, ajustar que todos los componentes de un formulario se ajuste al maximizar
 *   la ventana no es tan trivial, pero la propiedad Anchor ayuda bastante a ordenar el formulario. 
 *   
 *   
 *   Rodrigo Vasquez: a partir de la experiencia 4 se desarrolla una aplicación de navegador web,
 *   en donde se hace uso de herramienta/métodos (GoForward(), GoBack(), Stop (), Refresh(), etc) 
 *   que permiten el control de navegación en internet. En esta experiencia se manejó casi en su totalidad 
 *   las propiedades de un navegador, se consideraron casi todos los botones necesarios que uno utiliza
 *   en un navegador Web. Otra parte es el control de navegación que se asemeja mucho al desarrollo de otras 
 *   aplicaciones como de AD en donde controlan este tipo de navegación, se puede entender 
 *   cómo se realiza el flujo de programación que se utilizan para bloquear o permitir ciertas urls 
 *   en el navegador web. Me parece una experiencia bastante útil para entender algo que se 
 *   usa cotidianamente en el trabajo, estudio, etc.
 *   
 *   Luis Albornoz: Apartir de la experiencia 4 navegador web me permitio aprender 
 *   que apartir del visual studio se puede diseñar un browser  personalizado, 
 *   donde se podrian perfectamente aplicar si no tuvieramos una tipica aplicacion 
 *   como el chrom u otro buscador web.
 * 
 * 
 * 
 * 
 * 
 * 
 */
