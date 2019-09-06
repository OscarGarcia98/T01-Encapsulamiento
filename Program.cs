using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    class Program
    {
        static void Main(string[] args)
        {

            //Instanciación de los 5 vehiculos
            Vehiculo carro1 = new Vehiculo();
            carro1.Id = 125;
            carro1.Nombre = "Miata";
            carro1.Marca = "Mazda";
            carro1.Tipo = "Deportivo";
            carro1.Year = 2018;

            Vehiculo carro2 = new Vehiculo();
            carro2.Id = 1002;
            carro2.Nombre = "Focus sr";
            carro2.Marca = "Ford";
            carro2.Tipo = "Deportivo";
            carro2.Year = 2016;
            Vehiculo carro3 = new Vehiculo();
            carro3.Id = 1556;
            carro3.Nombre = "Clase C";
            carro3.Marca = "Mercedes";
            carro3.Tipo = "Deportivo de Lujo";
            carro3.Year = 2012;
            Vehiculo carro4 = new Vehiculo();
            carro4.Id = 1020;
            carro4.Nombre = "Sentra SR";
            carro4.Marca = "Nissan";
            carro4.Tipo = "Sedán";
            carro4.Year = 2014;
            Vehiculo carro5 = new Vehiculo();
            carro5.Id = 1080;
            carro5.Nombre = "Cayman";
            carro5.Marca = "Porshe";
            carro5.Tipo = "Deportivo";
            carro5.Year = 2007;

            Vehiculo[] v  = { carro1,carro2, carro3, carro4,carro5 }; 
          

            //Instanciación de la clase RepoVechiculo
            RepoVehiculo op = new RepoVehiculo();

            op.Mostrar_Vehiculo(carro1);
            op.Listar_Vehiculo(v);
            

           

            Console.ReadKey();

        }
    }
}
