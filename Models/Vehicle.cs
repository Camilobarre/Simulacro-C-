using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro_C_.Models
{
    // Propiedades de la clase Vehículo
    public class Vehicle
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public string Tipo { get; set; }
        public string EngineNumber { get; set; }
        public string SerialNumber { get; set; }
        public byte PeopleCapacity { get; set; }
        public Driver? Owner { get; set; }

        // Constructor para la clase Vehicle
        public Vehicle(int id, string placa, string tipo, string engineNumber, string serialNumber, byte peopleCapacity)
        {
            this.Id = id;
            this.Placa = placa ?? throw new ArgumentNullException(nameof(placa));
            this.Tipo = tipo ?? throw new ArgumentNullException(nameof(tipo));
            this.EngineNumber = engineNumber ?? throw new ArgumentNullException(nameof(engineNumber));
            this.SerialNumber = serialNumber ?? throw new ArgumentNullException(nameof(serialNumber));
            this.PeopleCapacity = peopleCapacity;
            this.Owner = null; // Inicialmente el vehículo no tiene dueño
        }

        // Método para asignar un propietario
        public void AssignOwner(Driver owner)
        {
            this.Owner = owner ?? throw new ArgumentNullException(nameof(owner));
        }

        // Sobrescribir el método ToString para proporcionar una representación de cadena del objeto Vehicle
        public override string ToString()
        {
            return @$"
            ID: {Id}
            Placa: {Placa}
            Tipo: {Tipo}
            Número de Motor: {EngineNumber}
            Número de Serie: {SerialNumber}
            Capacidad de Personas: {PeopleCapacity}
            Propietario: {(Owner != null ? Owner.GetName() + " " + Owner.GetLastName() : "No asignado")}";
        }
    }
}