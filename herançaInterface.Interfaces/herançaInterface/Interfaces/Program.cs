using System;
using herançaInterface.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herançaInterface.Interfaces
{
    
    internal class Program
    {
        
        static void Main(string[] args)
        {

            Carro carro = new Carro("Carro preto", "200", 5); 
            Avião avião = new Avião("Airbus A380", "15.000", 853);      
            Bicicleta bicicleta = new Bicicleta("Caloi amarela", "20", 1);  

            carro.VeiculoName(carro.Name);   
            carro.VeiculoMileage(carro.Mileage); 
            carro.PeopleCapacity(carro.Capacity);

            avião.VeiculoName(avião.Name);
            avião.VeiculoMileage(avião.Mileage); 
            avião.PeopleCapacity(avião.Capacity);

            bicicleta.VeiculoName(bicicleta.Name);
            bicicleta.VeiculoMileage(bicicleta.Mileage);
            bicicleta.PeopleCapacity(bicicleta.Capacity);
            Console.ReadLine();
        }
        
    }
}
