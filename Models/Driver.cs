using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro_C_.Models
{
    public class Driver : User
    {
        // Propiedades específicas de la clase Driver
        public string? LicenseNumber { get; set; }
        public string? LicenseCategory { get; set; }
        public int DrivingExperience { get; set; }

        // Constructor de la clase Driver como herencia de la clase User
        public Driver(string name, string lastName, string typeDocument, string identificationNumber, DateOnly birthDate, string email, string phoneNumber, string address, string licenseNumber, string licenseCategory, int drivingExperience)
            : base(name, lastName, typeDocument, identificationNumber, birthDate, email, phoneNumber, address)
        {
            this.LicenseNumber = licenseNumber ?? throw new ArgumentNullException(nameof(licenseNumber));
            this.LicenseCategory = licenseCategory ?? throw new ArgumentNullException(nameof(licenseCategory));
            this.DrivingExperience = drivingExperience >= 0 ? drivingExperience : throw new ArgumentOutOfRangeException(nameof(drivingExperience), "Driving experience cannot be negative");
        }

        // Método para actualizar la categoría de la licencia
        public void UpdateLicenseCategory(string newLicenseCategory)
        {
            this.LicenseCategory = newLicenseCategory;
        }

        // Método para añadir años de experiencia
        public void AddExperience(int years)
        {
            if (years < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(years), "Years of experience to add cannot be negative");
            }
            this.DrivingExperience += years;
        }

        // Sobrescribir el método ToString para proporcionar una representación de cadena del objeto Driver
        public override string ToString()
        {
            return base.ToString() + @$"
            Número de Licencia: {LicenseNumber}
            Categoría de Licencia: {LicenseCategory}
            Experiencia de Conducción: {DrivingExperience} años";
        }
    }
}