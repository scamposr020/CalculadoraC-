using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Base
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            btn.Clicked += Btn_Clicked;
            ss.Maximum = 360;    
        }

        private void Btn_Clicked(object sender, EventArgs e)
        {
            lbl1.Text = dtp.Date.ToString()+ " " + ss.Value.ToString() + "" + txt1.Text;
            txt1.IsEnabled = false;
        }
    }
}
