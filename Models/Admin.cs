using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro_C_.Models
{
    public class Admin
    {
        // Propiedades específicas de la clase Admin
        public List<Driver> ListDrivers { get; set; }
        public List<Customer> ListCustomers { get; set; }
        public List<Vehicle> ListVehicles { get; set; }

        // Constructor de la clase Admin
        public Admin()
        {
            this.ListDrivers = new List<Driver>();
            this.ListCustomers = new List<Customer>();
            this.ListVehicles = new List<Vehicle>();

            // Lista de 5 Drivers
            this.ListDrivers.Add(new Driver("John", "Doe", "Passport", "A12345678", new DateOnly(1980, 5, 23), "john.doe@example.com", "555-1234", "123 Main St", "D123456", "B1", 10));
            this.ListDrivers.Add(new Driver("Jane", "Smith", "ID Card", "B98765432", new DateOnly(1985, 7, 15), "jane.smith@example.com", "555-5678", "456 Elm St", "D789012", "A2", 8));
            this.ListDrivers.Add(new Driver("Michael", "Johnson", "Driver's License", "C34567890", new DateOnly(1990, 2, 10), "michael.johnson@example.com", "555-9012", "789 Pine St", "D345678", "C1", 12));
            this.ListDrivers.Add(new Driver("Emily", "Davis", "Passport", "D23456789", new DateOnly(1995, 8, 20), "emily.davis@example.com", "555-3456", "101 Oak St", "D567890", "D2", 5));
            this.ListDrivers.Add(new Driver("David", "Wilson", "ID Card", "E45678901", new DateOnly(2000, 12, 5), "david.wilson@example.com", "555-7890", "202 Maple St", "D890123", "A2", 3));

            // Lista de 5 Customers
            this.ListCustomers.Add(new Customer("Alice", "Brown", "Passport", "F12345678", new DateOnly(1978, 11, 30), "alice.brown@example.com", "555-2345", "303 Birch St", "Gold", "Credit Card"));
            this.ListCustomers.Add(new Customer("Robert", "Taylor", "ID Card", "G98765432", new DateOnly(1982, 4, 12), "robert.taylor@example.com", "555-6789", "404 Cedar St", "Silver", "Debit Card"));
            this.ListCustomers.Add(new Customer("Jessica", "Anderson", "Driver's License", "H34567890", new DateOnly(1987, 6, 22), "jessica.anderson@example.com", "555-0123", "505 Spruce St", "Bronze", "PayPal"));
            this.ListCustomers.Add(new Customer("Thomas", "Thomas", "Passport", "I23456789", new DateOnly(1992, 9, 9), "thomas.thomas@example.com", "555-4567", "606 Fir St", "Gold", "Credit Card"));
            this.ListCustomers.Add(new Customer("Sarah", "Moore", "ID Card", "J45678901", new DateOnly(1998, 3, 17), "sarah.moore@example.com", "555-8901", "707 Ash St", "Silver", "Debit Card"));

            // Lista de 5 Vehicles
            this.ListVehicles.Add(new Vehicle(1, "ABC123", "carro", "EN12345", "SN12345", 4) { Owner = ListDrivers[0] });
            this.ListVehicles.Add(new Vehicle(2, "DEF456", "bus", "EN67890", "SN67890", 10) { Owner = ListDrivers[1] });
            this.ListVehicles.Add(new Vehicle(3, "GHI789", "moto", "EN23456", "SN23456", 2) { Owner = ListDrivers[2] });
            this.ListVehicles.Add(new Vehicle(4, "JKL012", "camioneta", "EN34567", "SN34567", 4) { Owner = ListDrivers[3] });
            this.ListVehicles.Add(new Vehicle(5, "MNO345", "carro", "EN45678", "SN45678", 4) { Owner = ListDrivers[4] });
        }

        // Método para agregar un vehículo
        public void AddVehicle(Vehicle vehicle)
        {
            ListVehicles.Add(vehicle);
            Console.WriteLine($"El vehículo {vehicle.Id} con placa {vehicle.Placa} ha sido añadido");
        }

        // Método para agregar un conductor
        public void AddDriver(Driver driver)
        {
            ListDrivers.Add(driver);
            Console.WriteLine($"El conductor {driver.GetName} {driver.GetLastName} ha sido añadido");
        }

        // Método para editar un conductor
        public void EditDriver(Guid id)
        {
            Driver? driverFound = ListDrivers.Find(i => i.GetId() == id);
            if (driverFound != null)
            {
                Console.WriteLine("Ingresa los nuevos datos del conductor");

                Console.Write("Nombre (Deja en blanco para no cambiar): ");
                var input = Console.ReadLine().Trim().ToLower();
                if (!string.IsNullOrEmpty(input)) driverFound.SetName(input);

                Console.Write("Apellido (Deja en blanco para no cambiar): ");
                input = Console.ReadLine().Trim().ToLower();
                if (!string.IsNullOrEmpty(input)) driverFound.SetLastName(input);

                Console.Write("Tipo de Documento (Deja en blanco para no cambiar): ");
                input = Console.ReadLine().Trim().ToLower();
                if (!string.IsNullOrEmpty(input)) driverFound.SetTypeDocument(input);

                Console.Write("Número de Identificación (Deja en blanco para no cambiar): ");
                input = Console.ReadLine().Trim().ToLower();
                if (!string.IsNullOrEmpty(input)) driverFound.SetIdentificationNumber(input);

                Console.Write("Fecha de Nacimiento (dd/MM/yyyy) (Deja en blanco para no cambiar): ");
                input = Console.ReadLine().Trim().ToLower();
                if (!string.IsNullOrEmpty(input)) driverFound.SetBirthDate(DateOnly.ParseExact(input, "dd/MM/yyyy"));

                Console.Write("Email (Deja en blanco para no cambiar): ");
                input = Console.ReadLine().Trim().ToLower();
                if (!string.IsNullOrEmpty(input)) driverFound.SetEmail(input);

                Console.Write("Teléfono (Deja en blanco para no cambiar): ");
                input = Console.ReadLine().Trim().ToLower();
                if (!string.IsNullOrEmpty(input)) driverFound.SetPhoneNumber(input);

                Console.Write("Dirección (Deja en blanco para no cambiar): ");
                input = Console.ReadLine().Trim().ToLower();
                if (!string.IsNullOrEmpty(input)) driverFound.SetAddress(input);

                Console.Write("Número de Licencia (Deja en blanco para no cambiar): ");
                input = Console.ReadLine().Trim().ToLower();
                if (!string.IsNullOrEmpty(input)) driverFound.LicenseNumber = input;

                Console.Write("Categoría de Licencia (Deja en blanco para no cambiar): ");
                input = Console.ReadLine().Trim().ToLower();
                if (!string.IsNullOrEmpty(input)) driverFound.LicenseCategory = input;

                Console.Write("Años de Experiencia (Deja en blanco para no cambiar): ");
                input = Console.ReadLine().Trim().ToLower();
                if (!string.IsNullOrEmpty(input)) driverFound.DrivingExperience = int.Parse(input);

                Console.WriteLine($"El conductor {driverFound.GetId()} con nombre {driverFound.GetName()} ha sido editado");
            }
            else
            {
                Console.WriteLine("Conductor no encontrado.");
            }
        }
        // Método para editar un vehículo
        public void EditVehicle(int id)
        {
            Vehicle? vehicleFound = ListVehicles.Find(i => i.Id == id);
            if (vehicleFound != null)
            {
                Console.WriteLine("Ingresa los nuevos datos del vehículo");

                Console.Write("Placa (Deja en blanco para no cambiar): ");
                var input = Console.ReadLine().Trim().ToLower();
                if (!string.IsNullOrEmpty(input)) vehicleFound.Placa = input;

                Console.Write("Tipo (Deja en blanco para no cambiar): ");
                input = Console.ReadLine().Trim().ToLower();
                if (!string.IsNullOrEmpty(input)) vehicleFound.Tipo = input;

                Console.Write("Número de motor (Deja en blanco para no cambiar): ");
                input = Console.ReadLine().Trim().ToLower();
                if (!string.IsNullOrEmpty(input)) vehicleFound.EngineNumber = input;

                Console.Write("Número de Serial (Deja en blanco para no cambiar): ");
                input = Console.ReadLine().Trim().ToLower();
                if (!string.IsNullOrEmpty(input)) vehicleFound.SerialNumber = input;

                Console.Write("Capacidad de pasajeros (Deja en blanco para no cambiar): ");
                input = Console.ReadLine().Trim().ToLower();
                if (!string.IsNullOrEmpty(input)) vehicleFound.PeopleCapacity = byte.Parse(input);

                Console.WriteLine("Propietario (Deja en blanco para no cambiar):");
                Console.Write("Nombre del propietario: ");
                input = Console.ReadLine().Trim().ToLower();
                if (!string.IsNullOrEmpty(input)) vehicleFound.Owner.SetName(input);

                Console.Write("Apellido del propietario: ");
                input = Console.ReadLine().Trim().ToLower();
                if (!string.IsNullOrEmpty(input)) vehicleFound.Owner.SetLastName(input);

                Console.WriteLine($"El vehículo {vehicleFound.Id} con placa {vehicleFound.Placa} ha sido editado");
            }
            else
            {
                Console.WriteLine("Vehículo no encontrado.");
            }
        }
        // Método para eliminar un vehículo
        public void DeleteVehicle(int id)
        {
            ListVehicles.RemoveAll(i => i.Id == id);
            Console.WriteLine($"El vehículo con ID {id} ha sido eliminado");
        }

        // Método para listar los vehículos
        public void ShowVehicles()
        {
            Console.WriteLine("Listado de vehículos:");
            foreach (var vehicle in ListVehicles)
            {
                Console.WriteLine($"{vehicle.Id} - Placa: {vehicle.Placa}, Tipo: {vehicle.Tipo}, Número de Motor: {vehicle.EngineNumber}, Número de Serial: {vehicle.SerialNumber}, Capacidad de Personas: {vehicle.PeopleCapacity}");
            }
        }

        // Método para eliminar un conductor
        public void DeleteDriver(Guid id)
        {
            ListDrivers.RemoveAll(i => i.GetId() == id);
            Console.WriteLine($"El conductor con ID {id} ha sido eliminado");
        }

        // Método para listar los conductores
        public void ShowDrivers()
        {
            Console.WriteLine("Listado de conductores:");
            foreach (var driver in ListDrivers)
            {
                Console.WriteLine($"{driver.GetId()} - Nombre: {driver.GetName()}, Apellido: {driver.GetLastName()}, Teléfono: {driver.GetPhoneNumber()}");
            }
        }

        // Método para agregar un cliente
        public void AddCustomer(Customer customer)
        {
            ListCustomers.Add(customer);
            Console.WriteLine($"El cliente {customer.GetId()} con nombre {customer.GetName()} ha sido añadido");
        }

        // Método para editar un cliente
        public void EditCustomer(Guid id)
        {
            Customer? customerFound = ListCustomers.Find(i => i.GetId() == id);
            if (customerFound != null)
            {
                Console.WriteLine("Ingresa los nuevos datos del cliente");

                Console.Write("Nombre (Deja en blanco para no cambiar): ");
                var input = Console.ReadLine().Trim().ToLower();
                if (!string.IsNullOrEmpty(input)) customerFound.SetName(input);

                Console.Write("Apellido (Deja en blanco para no cambiar): ");
                input = Console.ReadLine().Trim().ToLower();
                if (!string.IsNullOrEmpty(input)) customerFound.SetLastName(input);

                Console.Write("Tipo de Documento (Deja en blanco para no cambiar): ");
                input = Console.ReadLine().Trim().ToLower();
                if (!string.IsNullOrEmpty(input)) customerFound.SetTypeDocument(input);

                Console.Write("Número de Identificación (Deja en blanco para no cambiar): ");
                input = Console.ReadLine().Trim().ToLower();
                if (!string.IsNullOrEmpty(input)) customerFound.SetIdentificationNumber(input);

                Console.Write("Fecha de Nacimiento (dd/MM/yyyy) (Deja en blanco para no cambiar): ");
                input = Console.ReadLine().Trim().ToLower();
                if (!string.IsNullOrEmpty(input)) customerFound.SetBirthDate(DateOnly.ParseExact(input, "dd/MM/yyyy"));

                Console.Write("Email (Deja en blanco para no cambiar): ");
                input = Console.ReadLine().Trim().ToLower();
                if (!string.IsNullOrEmpty(input)) customerFound.SetEmail(input);

                Console.Write("Teléfono (Deja en blanco para no cambiar): ");
                input = Console.ReadLine().Trim().ToLower();
                if (!string.IsNullOrEmpty(input)) customerFound.SetPhoneNumber(input);

                Console.Write("Dirección (Deja en blanco para no cambiar): ");
                input = Console.ReadLine().Trim().ToLower();
                if (!string.IsNullOrEmpty(input)) customerFound.SetAddress(input);

                Console.Write("Método de Pago Preferido (Deja en blanco para no cambiar): ");
                input = Console.ReadLine().Trim().ToLower();
                if (!string.IsNullOrEmpty(input)) customerFound.PreferredPaymentMethod = input;

                Console.Write("Nivel de Membresía (Deja en blanco para no cambiar): ");
                input = Console.ReadLine().Trim().ToLower();
                if (!string.IsNullOrEmpty(input)) customerFound.MembershipLevel = input;

                Console.WriteLine($"El cliente {customerFound.GetId()} con nombre {customerFound.GetName()} ha sido editado");
            }
            else
            {
                Console.WriteLine("Cliente no encontrado.");
            }
        }


        // Método para eliminar un cliente
        public void DeleteCustomer(Guid id)
        {
            ListCustomers.RemoveAll(i => i.GetId() == id);
            Console.WriteLine($"El cliente con ID {id} ha sido eliminado");
        }

        // Método para listar los clientes
        public void ShowCustomers()
        {
            Console.WriteLine("Listado de clientes:");
            foreach (var customer in ListCustomers)
            {
                Console.WriteLine($"{customer.GetId()} - Nombre: {customer.GetName()}, Apellido: {customer.GetLastName()}, Teléfono: {customer.GetPhoneNumber()}");
            }
        }

        // Método para imprimir un menú
        public static void ImprimirMenu()
        {
            Console.WriteLine(@$"
        ==============================================================================
        |                                TransRIWI                                   |
        ==============================================================================
        |                             0. Salir del Menú                              |
        |                             1. Agregar Cliente                             |
        |                             2. Mostrar Clientes                            |
        |                             3. Editar Cliente                              |
        |                             4. Eliminar Cliente                            |
        |                             5. Agregar Conductor                           |
        |                             6. Mostrar Conductores                         |
        |                             7. Editar Conductor                            |
        |                             8. Eliminar Conductor                          |
        |                             9. Agregar Vehículo                            |
        |                             10. Mostrar Vehículos                          |
        |                             11. Editar Vehículo                            |
        |                             12. Eliminar Vehículo                          |
        |                             13. Consultas LINQ                             |
        ==============================================================================
        ");
            Console.Write("Selecciona una opción: ");
        }

        //Método para pausar el menú
        public static void PausarMenu()
        {
            Console.WriteLine("Presiona una tecla para continuar...");
            Console.ReadKey();
        }

        public void ConsultasLINQ()
        {
            // 1. Listar todos los clientes registrados
            var allCustomers = ListCustomers;
            Console.WriteLine("Todos los clientes registrados:");
            foreach (var customer in allCustomers)
            {
                Console.WriteLine($"{customer.GetId()} - Nombre: {customer.GetName()}, Apellido: {customer.GetLastName()}, Teléfono: {customer.GetPhoneNumber()}");
            }
            Console.WriteLine();

            // 2. Listar todos los conductores registrados
            var allDrivers = ListDrivers;
            Console.WriteLine("Todos los conductores registrados:");
            foreach (var driver in allDrivers)
            {
                Console.WriteLine($"{driver.GetId()} - Nombre: {driver.GetName()}, Apellido: {driver.GetLastName()}, Teléfono: {driver.GetPhoneNumber()}");
            }
            Console.WriteLine();

            // 3. Listar todos los usuarios que tienen más de 30 años de edad
            var driversOver30 = ListDrivers.Where(d => d.CalculateAge() > 30).ToList();
            var customersOver30 = ListCustomers.Where(c => c.CalculateAge() > 30).ToList();

            Console.WriteLine("Usuarios mayores de 30 años:");
            foreach (var driver in driversOver30)
            {
                Console.WriteLine($"{driver.GetId()} - Nombre: {driver.GetName()}, Apellido: {driver.GetLastName()}, Edad: {driver.CalculateAge()}");
            }
            foreach (var customer in customersOver30)
            {
                Console.WriteLine($"{customer.GetId()} - Nombre: {customer.GetName()}, Apellido: {customer.GetLastName()}, Edad: {customer.CalculateAge()}");
            }
            Console.WriteLine();

            // 4. Ordenar los conductores por su experiencia de conducción en orden descendente
            var sortedDriversByExperience = ListDrivers.OrderByDescending(d => d.DrivingExperience).ToList();
            Console.WriteLine("Conductores ordenados por experiencia de conducción (de mayor a menor):");
            foreach (var driver in sortedDriversByExperience)
            {
                Console.WriteLine($"{driver.GetId()} - Nombre: {driver.GetName()}, Experiencia: {driver.DrivingExperience} años");
            }
            Console.WriteLine();

            // 5. Encontrar todos los clientes que prefieren pagar con tarjeta de crédito
            var creditCardCustomers = ListCustomers.Where(c => c.PreferredPaymentMethod == "Credit Card").ToList();
            Console.WriteLine("Clientes que prefieren pagar con tarjeta de crédito:");
            foreach (var customer in creditCardCustomers)
            {
                Console.WriteLine($"{customer.GetId()} - Nombre: {customer.GetName()}, Apellido: {customer.GetLastName()}");
            }
            Console.WriteLine();

            // 6. Listar todos los conductores con Licencia de Categoría 'A2'
            var categoryA2Drivers = ListDrivers.Where(d => d.LicenseCategory == "A2").ToList();
            Console.WriteLine("Conductores con Licencia de Categoría 'A2':");
            foreach (var driver in categoryA2Drivers)
            {
                Console.WriteLine($"{driver.GetId()} - Nombre: {driver.GetName()}, Apellido: {driver.GetLastName()}");
            }
        }
    }
}