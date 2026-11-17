using System;
using static tienda.producto;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== SISTEMA DE CONTROL DE INVENTARIO - TECNOPUNTO ===");

        Producto producto1 = RegistrarProducto(1);
        Producto producto2 = RegistrarProducto(2);
        Producto producto3 = RegistrarProducto(3);

        Console.Clear();
        Console.WriteLine("=== RESUMEN GENERAL DEL INVENTARIO ===");
        producto1.MostrarInfo();
        producto2.MostrarInfo();
        producto3.MostrarInfo();

        Console.WriteLine("\nPresione cualquier tecla para salir del programa...");
        Console.ReadKey();
    }

    static Producto RegistrarProducto(int numero)
    {
        string codigo = "";
        string nombre = "";
        decimal precio = 0;
        int cantidad = 0;

        // Validar Código
        while (true)
        {
            Console.WriteLine($"\n--- Registro del Producto #{numero} ---");
            Console.Write("Ingrese el código: ");
            codigo = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(codigo)) break;
            Console.WriteLine("[Error] El código no puede estar vacío.");
        }

        // Validar Nombre (Aquí capturas el error de nombre vacío)
        while (true)
        {
            try
            {
                Console.Write("Ingrese el nombre: ");
                nombre = Console.ReadLine();
                // Probamos asignarlo temporalmente para disparar la validación de la clase
                if (string.IsNullOrWhiteSpace(nombre))
                    throw new ArgumentException("El nombre del producto no puede estar vacío.");
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Error de validación] {ex.Message}");
            }
        }

        // Validar Precio (Aquí capturas el error de precio menor o igual a 0)
        while (true)
        {
            try
            {
                Console.Write("Ingrese el precio: ");
                precio = decimal.Parse(Console.ReadLine());
                if (precio <= 0)
                    throw new ArgumentException("El precio debe ser mayor que 0.");
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("[Error] Debe ingresar un número válido para el precio.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Error de validación] {ex.Message}");
            }
        }

        // Validar Cantidad (Aquí capturas el error de cantidad negativa)
        while (true)
        {
            try
            {
                Console.Write("Ingrese la cantidad: ");
                cantidad = int.Parse(Console.ReadLine());
                if (cantidad < 0)
                    throw new ArgumentException("La cantidad no puede ser negativa.");
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("[Error] Debe ingresar un número entero válido para la cantidad.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Error de validación] {ex.Message}");
            }
        }

        // Crear el producto definitivo
        Producto nuevoProducto = new Producto(codigo, nombre, precio, cantidad);
        Console.WriteLine("¡Producto registrado exitosamente!");
        return nuevoProducto;
    }
}