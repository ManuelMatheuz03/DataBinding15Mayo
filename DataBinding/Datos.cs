namespace DataBinding
{
    using System;
    using System.Collections.ObjectModel;
    public  class Datos:Notificable
    {


        #region Atributos
             private ObservableCollection<Persona> personas;
             private Persona personaSeleccionada;
        #endregion



       

        #region Propiedades

        public ObservableCollection<Persona> Personas
            {
                get
                {
                    return personas;
                }
                set
                {
                    if (personas == value)
                    {
                        return;
                    }
                    personas = value;
                    OnPropertyChanged();
                }
            }

        public Persona PersonaSeleccionada
        {
            get
            {
                return personaSeleccionada;
            }
            set
            {
                if (personaSeleccionada == value)
                {
                    return;
                }
                personaSeleccionada = value;
                OnPropertyChanged();
            }
        }


        #endregion

        #region Construtores
        public Datos()
        {
            var aleatorio = new Random();
            Personas = new ObservableCollection<Persona>();
            for (int i = 0; i < 5; i++)
            {
                Personas.Add(new Persona()
                {
                    Nombre = $"Persona {i}",
                    Pais = $"Pais {i}",
                    FechaDeNacimiento = new DateTime(1980 + i, i + 1, 1),
                    Saldo = (decimal)(aleatorio.Next(100, 5000) * 3.1416)
                });
            }


        }





        #endregion


    }
}
