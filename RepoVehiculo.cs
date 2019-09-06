using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    class RepoVehiculo
    {

        public void Mostrar_Vehiculo(Vehiculo carro)
        {
            Console.WriteLine("No. de auto: {0}\nNombre: {1}\nMarca: {2}\nTipo: {3}\nAño: {4}", carro.Id, carro.Nombre, carro.Marca, carro.Tipo, carro.Year);

        }

        public void Listar_Vehiculo(Vehiculo[] v) //ARREGLO PARA LA LISTA DE VEHICULOS
        {

         foreach(Vehiculo carro in v)
         {
                Console.WriteLine("///////////////////////////////////////////////////////////");
                Console.WriteLine("No. de auto: {0}\nNombre: {1}\nMarca: {2}\nTipo: {3}\nAño: {4}", carro.Id, carro.Nombre, carro.Marca, carro.Tipo, carro.Year);



         }

            

        }



    }
}
