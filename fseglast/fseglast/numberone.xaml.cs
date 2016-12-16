using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace fseglast
{
    public partial class numberone : ContentPage
    {
        public numberone()
        {
            InitializeComponent();
            im2.RotateTo(360, 2800, Easing.SinInOut);
            
        }


        private async void Button_OnClicked(object sender, EventArgs e)
        {
            //DisplayAlert("Login", "welcome", "ok");
            /*var answer = await DisplayAlert("Question?", "Would you like to go to page 2", "Yes", "No");
            if (answer == true)
            {
                await this.Navigation.PushAsync(new page2());
            }

            else
            {
                await DisplayAlert("thankyou", "see you again", "ok");
                lab1.TextColor = Color.Maroon;
            }*/

            if (e1.Text != "0000" && e2.Text != "0000")
            {

                DisplayAlert("Alert", "Wrrong password ", "ok");
                wrong.TextColor=Color.Red;
                await Task.Delay(2000);
                wrong.TextColor = Color.White;


            }
            else
            {
                await Navigation.PushAsync(new page2());
                wrong.TextColor = Color.White;
            }

        }
    }
}
