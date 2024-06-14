using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herançaInterface.Interfaces
{
    using Interfaces;

    class Bicicleta : IVeículo
    {
        public string Name { get; set; }
        public string Mileage { get; set; }
        public int Capacity { get; set; }

        //variaveis para exibir os valores
        public Bicicleta(string name, string mileage, int peopleCapacity)
        {
            Name = name;
            Mileage = mileage;
            Capacity = peopleCapacity;
        }

        public void VeiculoName(string name)
        {
            Console.WriteLine($"Veiculo name: {name} ");
        }

        public void VeiculoMileage(string Mileage)
        {
            Console.WriteLine($"Veiculo Mileage: {Mileage} ");
        }

        public void PeopleCapacity(int capacity)
        {
            Console.WriteLine($"People Capacity: {capacity} ");
        }
    }
}
    
   
