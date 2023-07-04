using Pruebas.Droid.Model;
using Pruebas.Servicio;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Pruebas.ViewModel
{
    public class PersonaViewModel:PersonaModel
    {
        public ObservableCollection<PersonaModel> Personas { get; set; }
        PersonasServicio servicio = new PersonasServicio();
        PersonaModel modelo;
        public PersonaViewModel()
        {
            Personas = servicio.Consultar();
            GuardarCommand = new Command(async () => await Guardar(), () => !Isbusy);
            ModificarCommand = new Command(async () => await Modificar(), () => !Isbusy);
            EliminarCommand = new Command(async () => await Eliminar(), () => !Isbusy);
            LimpiarCommand = new Command(Limpiar, () => !Isbusy);
        }
        public Command GuardarCommand { get; set; }
        public Command ModificarCommand { get; set; }
        public Command EliminarCommand { get; set; }
        public Command LimpiarCommand { get; set; }

        private async Task Guardar()
        {
            Isbusy = true;
            Guid idPersona = Guid.NewGuid();
            modelo = new PersonaModel()
            {
                CardCode = CardCode,
                Nombre = Nombre,
                Nombreclinica = Nombreclinica,
                Edad = Edad,
                Medicostotales = Medicostotales,
                Pacientespromedio = Pacientespromedio,
                Costoconsulta = Costoconsulta,
                Consultasalmes = Consultasalmes,
                Piezasxpaciente = Piezasxpaciente,
                Utilidadxpieza = Utilidadxpieza,
                Utilidadpotencial = Utilidadpotencial,
                Id=idPersona.ToString()
            };
            servicio.Guardar(modelo);
            await Task.Delay(2000);
            Isbusy = false;
        }
        private async Task Modificar()
        {
            Isbusy = true;
            modelo = new PersonaModel()
            {
                CardCode = CardCode,
                Nombre = Nombre,
                Nombreclinica = Nombreclinica,
                Edad = Edad,
                Medicostotales = Medicostotales,
                Pacientespromedio = Pacientespromedio,
                Costoconsulta = Costoconsulta,
                Consultasalmes = Consultasalmes,
                Piezasxpaciente = Piezasxpaciente,
                Utilidadxpieza = Utilidadxpieza,
                Utilidadpotencial = Utilidadpotencial,
                Id = Id
            };
            servicio.Modificar(modelo);
            await Task.Delay(2000);
            Isbusy = false;
        }
        private async Task Eliminar()
        {
            Isbusy = true;
            servicio.Eliminar(Id);
            await Task.Delay(2000);
            Isbusy = false;
        }
        private void Limpiar()
        {
            CardCode = "";
            Nombre = "";
            Edad = 0;
            Nombreclinica = "";
            Medicostotales = 0;
            Pacientespromedio = 0;
            Costoconsulta = 0;
            Consultasalmes = 0;
            Piezasxpaciente = 0;
            Utilidadxpieza = 0;
            Utilidadpotencial = 0;
            Id = "";
        }
    }
}
