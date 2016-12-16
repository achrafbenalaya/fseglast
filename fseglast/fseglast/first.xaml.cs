using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fseglast.masterdetailedpage;
using Xamarin.Forms;

namespace fseglast
{
    public partial class first : ContentPage
    {
        public first()
        {
            InitializeComponent();
            //im1.TranslateTo(0, 20, 2000, Easing.BounceIn);
            // im1.ScaleTo(1, 2000, Easing.CubicIn);
            im1.RotateTo(360, 2500, Easing.SinInOut);
            // im1.ScaleTo(1, 2000, Easing.CubicOut);
            //     im1.TranslateTo(0, -200, 2000, Easing.BounceOut);
        }



        private async void ButtonLogin_OnClicked(object sender, EventArgs e)
        {
            if (pl1.Text != "0000" && pl2.Text != "0000")
            {
                DisplayAlert("Hello", "Wrong Password", "ok");

            }
            else
            {
                // await this.Navigation.PushAsync(new MainPage());
                App.Current.MainPage = new MainPage();
            }
        }
    }
}