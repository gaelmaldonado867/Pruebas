using Pruebas.Droid.Model;
using Pruebas.Servicio;
using Pruebas.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pruebas.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonaPage : ContentPage
    {
        PersonaViewModel contexto = new PersonaViewModel();
        public PersonaPage()
        {
            InitializeComponent();
            BindingContext = contexto;
            LvPersonas.ItemSelected += LvPersonas_ItemSelected;
        }

        private void LvPersonas_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                PersonaModel modelo = (PersonaModel)e.SelectedItem;
                contexto.CardCode = modelo.CardCode;
                contexto.Nombre = modelo.Nombre;
                contexto.Edad = modelo.Edad;
                contexto.Nombreclinica = modelo.Nombreclinica;
                contexto.Pacientespromedio = modelo.Pacientespromedio;
                contexto.Costoconsulta = modelo.Costoconsulta;
                contexto.Consultasalmes = modelo.Consultasalmes;
                contexto.Piezasxpaciente = modelo.Piezasxpaciente;
                contexto.Utilidadxpieza = modelo.Utilidadxpieza;
                contexto.Utilidadpotencial = modelo.Utilidadpotencial;
                contexto.Id = modelo.Id;
            }
        }

        public async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page());
        }
    }
}