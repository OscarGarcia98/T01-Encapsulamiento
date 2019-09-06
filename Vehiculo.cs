using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    class Vehiculo
    {
        private int id;
        private string nombre;
        private string tipo;
        private string marca;
        private int year;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }

       


    }
}
