namespace DataBinding
{
    using System;
    using System.ComponentModel;
    public class Persona : Notificable
    {
        #region Atributos
        private string nombre;
        private string pais;
        private decimal saldo;
        private DateTime fechaDeNacimiento;

       


        #endregion

        #region Propiedades
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                if (nombre == value)
                {
                    return;
                }
                nombre = value;
                OnPropertyChanged();
            }
        }
        public string Pais
        {
            get
            {
                return pais;
            }
            set
            {
                if (pais == value)
                {
                    return;
                }
                pais = value;
                OnPropertyChanged();
            }

        }

        public DateTime FechaDeNacimiento
        {
            get
            {
                return fechaDeNacimiento;
            }
            set
            {
                if (fechaDeNacimiento == value)
                {
                    return;
                }
                fechaDeNacimiento = value;
                OnPropertyChanged();
            }
        }

        public decimal Saldo
        {
            get
            { return saldo;
            }
            set {
                if (saldo == value)
                {
                    return;
                }
                saldo = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Metodos
        public override string ToString()
            {
                return $"{Nombre} | {Pais} | {Saldo} | {FechaDeNacimiento}";
            }
        #endregion


    }
}
