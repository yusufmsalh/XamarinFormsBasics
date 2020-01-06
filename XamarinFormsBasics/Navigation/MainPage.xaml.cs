using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinFormsBasics
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //contiue video 8
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            // read user input and show hello + input
           var name = txtName.Text;
            lblName.Text = "Hello " + name;

        }

        private async   void btnNavigate_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1(txtName.Text));
        }
    }
}
