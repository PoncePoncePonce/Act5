using System.ComponentModel.DataAnnotations;

namespace Act5
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        int sum;
        int productos;
        private async void button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Info", $"Se agregaron {productos} productos con un total de ${sum} pesos", "Aceptar");
        }

        private void Starwars_Toggled(object sender, ToggledEventArgs e)
        {
            if(e.Value) 
            {
                sum = sum + 6391;
                productos++;
            }

            else
            {
                sum = sum - 6391;
                productos--;
            }
        }
        private void Usb_Toggled(object sender, ToggledEventArgs e)
        {
            if (e.Value)
            {
                sum = sum + 126;
                productos++;
            }

            else
            {
                sum = sum - 126;
                productos--;
            }
        }
        private void Teclado_Toggled(object sender, ToggledEventArgs e)
        {
            if (e.Value)
            {
                sum = sum + 503;
                productos++;
            }

            else
            {
                sum = sum - 503;
                productos--;
            }
        }
        private void Gpu_Toggled(object sender, ToggledEventArgs e)
        {
            if (e.Value)
            {
                sum = sum + 4859;
                productos++;
            }

            else
            {
                sum = sum - 4859;
                productos--;
            }
        }
        private void Monitor_Toggled(object sender, ToggledEventArgs e)
        {
            if (e.Value)
            {
                sum = sum + 2981;
                productos++;
            }

            else
            {
                sum = sum - 2981;
                productos--;
            }
        }
    }

}
