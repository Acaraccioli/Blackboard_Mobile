using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XFMenu.Pages
{
    public partial class PageTwo : ContentPage
    {
        public PageTwo()
        {
            InitializeComponent();
        }

         void  Handle_Clicked(object sender, System.EventArgs e)
        {
            String user = this.numCuenta.Text;
            String pass = this.password.Text;
            if(string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
            {
                DisplayAlert("Alerta!", "Porfavor ingresa un usario valido y contraseña valida", "OK");

            }
            else
            {
                Navigation.PushModalAsync(new MainMenu());

            }

        }

        private  void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new LoadUrl());


        }
    }
}
