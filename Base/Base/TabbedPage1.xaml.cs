using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Base
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPage1 : TabbedPage
    {
        public TabbedPage1()
        {
            InitializeComponent();
            btn1.Clicked += Btn1_Clicked;
        }

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            tb2.Focus();
        }
    }
}