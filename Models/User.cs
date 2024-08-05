using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro_C_.Models
{
    public class User
    {
        // Se crean las propiedades de la clase User
        protected Guid Id { get; set; }
        protected string Name { get; set; }
        protected string LastName { get; set; }
        protected string TypeDocument { get; set; }
        protected string IdentificationNumber { get; set; }
        protected DateOnly BirthDate { get; set; }
        protected string Email { get; set; }
        protected string PhoneNumber { get; set; }
        protected string Address { get; set; }

        // Constructor de la clase User
        protected User(string name, string lastName, string typeDocument, string identificationNumber, DateOnly birthDate, string email, string phoneNumber, string address)
        {
            this.Id = Guid.NewGuid();
            this.Name = name;
            this.LastName = lastName;
            this.TypeDocument = typeDocument;
            this.IdentificationNumber = identificationNumber;
            this.BirthDate = birthDate;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            this.Address = address;
        }

        // Método para mostrar los datos del usuario
        protected void ShowDetails()
        {
            Console.WriteLine(@$"
            Id: {Id}
            Nombre: {Name} {LastName} 
            Documento: {TypeDocument} {IdentificationNumber} 
            Fecha de Nacimiento: {BirthDate.ToString("dd/MM/yyyy")} 
            Email: {Email}
            Teléfono: {PhoneNumber}
            Dirección: {Address}");
        }

        // Método para calcular la edad
        public int CalculateAge()
        {
            var today = DateTime.Today;
            var birthDateTime = BirthDate.ToDateTime(TimeOnly.MinValue);
            var age = today.Year - birthDateTime.Year;
            if (birthDateTime > today.AddYears(-age)) age--;
            return age;
        }

        // Método para mostrar la edad
        protected void ShowAge()
        {
            Console.WriteLine($"Edad: {CalculateAge()} años");
        }

        // Métodos para obtener los valores
        public Guid GetId() => Id;
        public string GetName() => Name;
        public string GetLastName() => LastName;
        public string GetTypeDocument() => TypeDocument;
        public string GetIdentificationNumber() => IdentificationNumber;
        public DateOnly GetBirthDate() => BirthDate;
        public string GetEmail() => Email;
        public string GetPhoneNumber() => PhoneNumber;
        public string GetAddress() => Address;

        // Métodos para establecer los valores
        public void SetName(string value) => Name = value;
        public void SetLastName(string value) => LastName = value;
        public void SetTypeDocument(string value) => TypeDocument = value;
        public void SetIdentificationNumber(string value) => IdentificationNumber = value;
        public void SetBirthDate(DateOnly value) => BirthDate = value;
        public void SetEmail(string value) => Email = value;
        public void SetPhoneNumber(string value) => PhoneNumber = value;
        public void SetAddress(string value) => Address = value;

        // Sobrescribir el método ToString para proporcionar una representación de cadena del objeto User
        public override string ToString()
        {
            return @$"
            Id: {Id}
            Nombre: {Name} {LastName} 
            Documento: {TypeDocument} {IdentificationNumber} 
            Fecha de Nacimiento: {BirthDate.ToString("dd/MM/yyyy")} 
            Email: {Email}
            Teléfono: {PhoneNumber}
            Dirección: {Address}
            Edad: {CalculateAge()} años";
        }
    }
}