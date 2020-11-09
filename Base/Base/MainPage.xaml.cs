
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Xml.Serialization;
using System.Net;
using System.IO;
using System.Globalization;
using System.Threading;

namespace Base
{

    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            btnSuma.Clicked += BtnSuma_Clicked;
            btnResta.Clicked += BtnResta_Clicked;
            btnMultip.Clicked += BtnMultip_Clicked;
            btnDivision.Clicked += BtnDivision_Clicked;
            btnLimpiar.Clicked += BtnLimpiar_Clicked;
        }
        int num1;
        int num2;
        int respuesta;
        string escribe;
        private void BtnLimpiar_Clicked(object sender, EventArgs e)
        {
            entNum1.Text = "";
            entNum2.Text = "";
        }

        private void BtnDivision_Clicked(object sender, EventArgs e)

        {
            try { 
                num1 = Int32.Parse(entNum1.Text);
                num2 = Int32.Parse(entNum2.Text);
                respuesta = num1 / num2;
                if (num1 == 0 || num2 == 0)
                {
                    lblResul.Text = "No se pudo realizar la operación porque digito un 0";
                }
                else
                {
                    lblResul.Text = "" + respuesta.ToString();
                    escribe = num1 + "/" + num2 + "=" + respuesta;
                    Writefile(escribe);
                }
            }
            catch (Exception)
            {
                DisplayAlert("Alert", "You have been alerted", "OK");
            }
        }

        private void BtnMultip_Clicked(object sender, EventArgs e)
        {
            try { 
            num1 = Int32.Parse(entNum1.Text);
            num2 = Int32.Parse(entNum2.Text);
            respuesta = num1 * num2;
            lblResul.Text = "" + respuesta.ToString();
            escribe = num1 + "*" + num2 + "=" + respuesta;
            Writefile(escribe);
            }
            catch (Exception )
            {
                DisplayAlert("Alerta", "No puede dejar los valores vacíos", "OK");
            }
        }

        private void BtnResta_Clicked(object sender, EventArgs e)
        {
            try
            {
                num1 = Int32.Parse(entNum1.Text);
                num2 = Int32.Parse(entNum2.Text);

                respuesta = num1 - num2;
                lblResul.Text = "" + respuesta.ToString();
                escribe = num1 + "-" + num2 + "=" + respuesta;
                Writefile(escribe);
            }
            catch (Exception)
            {
                DisplayAlert("Alerta", "No puede dejar los valores vacíos", "OK");
            }
           
            
        }

        private void BtnSuma_Clicked(object sender, EventArgs e)

        {

            try
            {
                num1 = Int32.Parse(entNum1.Text);
            num2 = Int32.Parse(entNum2.Text);
            respuesta = num1 + num2;
            lblResul.Text = respuesta.ToString();
            escribe = num1 + " + " + num2 + " = " + respuesta;
            Writefile(escribe);
            }
            catch (Exception )
            {
                DisplayAlert("Alerta", "No puede dejar los valores vacíos", "OK");
            }

        }
        void Writefile(string result) {
            String nombreArchivo = "Archivo.txt";
            String ruta = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            String rutaCompleta = Path.Combine(ruta, nombreArchivo);

            // File.Delete(rutaCompleta);
            // FileStream fs = new FileStream(rutaCompleta, FileMode.Create);
            //fs.Dispose();// Sirve para vaciar la data de 
            if (File.Exists(rutaCompleta))
            {
                string appendText = escribe + Environment.NewLine;
                File.AppendAllText(rutaCompleta, appendText);
            }
            else
            {
                using (var escritor = File.CreateText(rutaCompleta))
                {
                    string createText = escribe + Environment.NewLine;
                    File.WriteAllText(rutaCompleta, createText);

                }
            }
            string readText = File.ReadAllText(rutaCompleta, Encoding.Default);
            Console.WriteLine(readText);

        }
        
          
    }
  
}