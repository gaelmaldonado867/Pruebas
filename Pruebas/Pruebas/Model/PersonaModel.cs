using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Pruebas.Droid.Model
{
    public class PersonaModel
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string nombre = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
        }
        private string id;
        private string cardcode;
        private string nombre;
        private string nombreclinica;
        private int edad;
        private int medicostotales;
        private int pacientespromedio;
        private int costoconsulta;
        private float consultasalmes;
        private int piezasxpaciente;
        private float utilidadxpieza;
        private float utilidadpotencial;
        private float cortoplazo;
        private string mensaje;
        private bool isBusy = false;

        public bool Isbusy
        {
            get { return isBusy = false; }
            set { isBusy = value; OnPropertyChanged(); }
        }
        public string Id
        {
            get { return id; }
            set { id = value; OnPropertyChanged(); }
        }
        public string CardCode
        {
            get { return cardcode; }
            set { cardcode = value; OnPropertyChanged(); }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; OnPropertyChanged(); }
        }
        public string Nombreclinica
        {
            get { return nombreclinica; }
            set { nombreclinica = value; OnPropertyChanged(); }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; OnPropertyChanged(); }
        }
        public int Medicostotales
        {
            get { return medicostotales; }
            set { medicostotales = value; OnPropertyChanged(); }
        }
        public int Pacientespromedio
        {
            get { return pacientespromedio; }
            set { pacientespromedio = value; OnPropertyChanged(); }
        }
        public int Costoconsulta
        {
            get { return costoconsulta; }
            set { costoconsulta = value; OnPropertyChanged(); }
        }
        public float Consultasalmes
        {
            get { return consultasalmes; }
            set { consultasalmes = value; OnPropertyChanged(); }
        }
        public int Piezasxpaciente
        {
            get { return piezasxpaciente; }
            set { piezasxpaciente = value; OnPropertyChanged(); }
        }
        public float Utilidadxpieza
        {
            get { return utilidadxpieza; }
            set { utilidadxpieza = value; OnPropertyChanged(); }
        }
        public float Utilidadpotencial
        {
            get { return (Pacientespromedio * Consultasalmes) * (Piezasxpaciente * Utilidadxpieza); }
            set { utilidadpotencial = value; OnPropertyChanged(); }
        }
        public float Cortoplazo
        {
            get { return cortoplazo; }
            set { cortoplazo = value; OnPropertyChanged(); }
        }

        public string Mensaje
        {
            get { return $"Potencial de Utilidad del Cliente {CardCode} al mes: {Utilidadpotencial}"; }
        }
    }
}