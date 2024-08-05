using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro_C_.Models
{
    public class Customer : User
    {
        // Se crean las propiedades específicas de la clase Customer
        public string MembershipLevel { get; set; }
        public string PreferredPaymentMethod { get; set; }

        // Constructor como herencia de la clase User
        public Customer(string name, string lastName, string typeDocument, string identificationNumber, DateOnly birthDate, string email, string phoneNumber, string address, string membershipLevel, string preferredPaymentMethod)
            : base(name, lastName, typeDocument, identificationNumber, birthDate, email, phoneNumber, address)
        {
            this.MembershipLevel = membershipLevel;
            this.PreferredPaymentMethod = preferredPaymentMethod;
        }

        // Método para actualizar la membresía del cliente
        public void UpdateMembershipLevel(string newMembershipLevel)
        {
            this.MembershipLevel = newMembershipLevel;
        }

        // Sobrescribir el método ToString para proporcionar una representación de cadena del objeto Customer
        public override string ToString()
        {
            return base.ToString() + @$"
            Nivel de Membresía: {MembershipLevel}
            Método de Pago Preferido: {PreferredPaymentMethod}";
        }
    }
}