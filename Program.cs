using Simulacro_C_.Models;

Console.Clear();
var bandera = true;
Admin admin = new Admin();

while (bandera)
{
    Admin.ImprimirMenu();
    var opcion = Convert.ToInt32(Console.ReadLine());
    switch (opcion)
    {
        case 0:
            // Salir del Programa
            Console.WriteLine("Hasta luego, vuelva pronto!");
            bandera = false;
            break;
        case 1:
            // Agregar Cliente
            var newCustomer = CreateCustomer();
            admin.AddCustomer(newCustomer);
            Admin.PausarMenu();
            break;
        case 2:
            // Mostrar Clientes
            admin.ShowCustomers();
            Admin.PausarMenu();
            break;
        case 3:
            // Editar Cliente
            Console.WriteLine("Ingresa el ID del cliente a editar: ");
            var editId = Guid.Parse(Console.ReadLine());
            admin.EditCustomer(editId);
            Admin.PausarMenu();
            break;
        case 4:
            // Eliminar Cliente
            Console.WriteLine("Ingresa el ID del cliente a eliminar: ");
            var deleteId = Guid.Parse(Console.ReadLine());
            admin.DeleteCustomer(deleteId);
            Admin.PausarMenu();
            break;
        case 5:
            // Agregar un Conductor
            var newDriver = CreateDriver();
            admin.AddDriver(newDriver);
            Admin.PausarMenu();
            break;
        case 6:
            // Mostrar Conductores
            admin.ShowDrivers();
            Admin.PausarMenu();
            break;
        case 7:
            // Editar Conductor
            Console.WriteLine("Ingresa el ID del conductor a editar: ");
            var editIdDriver = Guid.Parse(Console.ReadLine());
            admin.EditDriver(editIdDriver);
            Admin.PausarMenu();
            break;
        case 8:
            // Eliminar Conductor
            Console.WriteLine("Ingresa el ID del cliente a eliminar: ");
            var deleteIdDriver = Guid.Parse(Console.ReadLine());
            admin.DeleteDriver(deleteIdDriver);
            Admin.PausarMenu();
            break;
        case 9:
            // Agregar Vehículo
            var newVehicle = CreateVehicle();
            if (newVehicle != null)
            {
                admin.AddVehicle(newVehicle);
            }
            else
            {
                Console.WriteLine("No se pudo añadir el vehículo. Tipo de vehículo no válido.");
            }
            Admin.PausarMenu();
            break;
        case 10:
            // Mostrar Vehículo
            admin.ShowVehicles();
            Admin.PausarMenu();
            break;
        case 11:
            //Editar Vehículo
            Console.WriteLine("Ingresa el ID del vehículo a editar: ");
            var editIdVehicle = int.Parse(Console.ReadLine());
            admin.EditVehicle(editIdVehicle);
            Admin.PausarMenu();
            break;
        case 12:
            // Eliminar Vehículo
            Console.WriteLine("Ingresa el ID del vehículo a eliminar: ");
            var deleteIdVehicle = int.Parse(Console.ReadLine());
            admin.DeleteVehicle(deleteIdVehicle);
            Admin.PausarMenu();
            break;
        case 13:
            // Consultas LINQ
            Console.WriteLine("Aquí tienes las consultas LINQ: ");
            admin.ConsultasLINQ();
            Admin.PausarMenu();
            break;
        default:
            // Opción no válida
            Console.WriteLine("Opción inválida, intente nuevamente.");
            Admin.PausarMenu();
            break;
    }
}

static Customer CreateCustomer()
{
    Console.Write("Nombre: ");
    var name = Console.ReadLine();
    Console.Write("Apellido: ");
    var lastName = Console.ReadLine();
    Console.Write("Tipo de Documento: ");
    var typeDocument = Console.ReadLine();
    Console.Write("Número de Identificación: ");
    var identificationNumber = Console.ReadLine();
    Console.Write("Fecha de Nacimiento (dd/MM/yyyy): ");
    var birthDate = DateOnly.ParseExact(Console.ReadLine(), "dd/MM/yyyy");
    Console.Write("Email: ");
    var email = Console.ReadLine();
    Console.Write("Teléfono: ");
    var phoneNumber = Console.ReadLine();
    Console.Write("Dirección: ");
    var address = Console.ReadLine();
    Console.Write("Nivel de Membresía: ");
    var membershipLevel = Console.ReadLine();
    Console.Write("Método de Pago Preferido: ");
    var preferredPaymentMethod = Console.ReadLine();

    return new Customer(name, lastName, typeDocument, identificationNumber, birthDate, email, phoneNumber, address, membershipLevel, preferredPaymentMethod);
}

static Driver CreateDriver()
{
    Console.Write("Nombre: ");
    var name = Console.ReadLine();
    Console.Write("Apellido: ");
    var lastName = Console.ReadLine();
    Console.Write("Tipo de Documento: ");
    var typeDocument = Console.ReadLine();
    Console.Write("Número de Identificación: ");
    var identificationNumber = Console.ReadLine();
    Console.Write("Fecha de Nacimiento (dd/MM/yyyy): ");
    var birthDate = DateOnly.ParseExact(Console.ReadLine(), "dd/MM/yyyy");
    Console.Write("Email: ");
    var email = Console.ReadLine();
    Console.Write("Teléfono: ");
    var phoneNumber = Console.ReadLine();
    Console.Write("Dirección: ");
    var address = Console.ReadLine();
    Console.Write("Número de Licencia: ");
    var licenseNumber = Console.ReadLine();
    Console.Write("Categoría de Licencia: ");
    var licenseCategory = Console.ReadLine();
    Console.Write("Años de Experiencia: ");
    var drivingExperience = int.Parse(Console.ReadLine());

    return new Driver(name, lastName, typeDocument, identificationNumber, birthDate, email, phoneNumber, address, licenseNumber, licenseCategory, drivingExperience);
}

static Vehicle? CreateVehicle()
{
    Console.Write("Id: ");
    var idVehicle = int.Parse(Console.ReadLine());
    Console.Write("Placa: ");
    var placa = Console.ReadLine();
    Console.Write("Tipo (carro, bus, moto, camioneta): ");
    var type = Console.ReadLine();
    Console.Write("Número de motor: ");
    var engineNumber = Console.ReadLine();
    Console.Write("Número de Serial: ");
    var serialNumber = Console.ReadLine();
    Console.Write("Capacidad de pasajeros: ");
    var peopleCapacity = byte.Parse(Console.ReadLine());

    if ((type == "camioneta" && peopleCapacity <= 4) || (type == "bus" && peopleCapacity <= 10) || (type == "carro" && peopleCapacity <= 4) || (type == "moto" && peopleCapacity <= 2))
    {
        Console.WriteLine("");
        Console.WriteLine("Vehículo añadido con éxito!");
        Console.WriteLine("");
        return new Vehicle(idVehicle, placa, type, engineNumber, serialNumber, peopleCapacity);
    }
    else
    {
        Console.WriteLine("El tipo del vehículo no es válido");
        return null;
    }
}