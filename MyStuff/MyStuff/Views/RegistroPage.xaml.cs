using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using MyStuff.ViewModels;

namespace MyStuff.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistroPage : ContentPage
    {

        UserViewModel UsuarioVM;

        public RegistroPage()
        {
            InitializeComponent();

            BindingContext = UsuarioVM = new UserViewModel();

        }

        private async void BtnCancelar_Clicked(object sender, EventArgs e)
        {
           await Navigation.PopAsync();
        }

        private async void BtnAceptar_Clicked(object sender, EventArgs e)
        {
            bool R = await UsuarioVM.GuardarUsuario(TxtUsuario.Text.Trim(), TxtNombreUsuario.Text.Trim(),
                           TxtPassword.Text.Trim(), TxtTelefono.Text.Trim(), TxtBackUpEmail.Text.Trim());

            if (R)
            {
                await DisplayAlert("Aviso", "Usuario agregado correctamente", "OK");
                await Navigation.PopAsync();
            }
            else
            {
                await DisplayAlert("Aviso", "Algo salió mal y el usuario no se agregó", "OK");
            }

        }
    }
}