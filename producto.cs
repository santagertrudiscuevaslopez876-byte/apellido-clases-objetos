using System;
using System.Collections.Generic;
using System.Text;

namespace tienda
{
    internal class producto
    {



        public class Producto
        {
            // Campos privados
            private string codigo;
            private string nombre;
            private decimal precio;
            private int cantidad;

            // Propiedad Codigo
            public string Codigo
            {
                get { return codigo; }
                set { codigo = value; }
            }

            // Propiedad Nombre con validación (no puede estar vacía)
            public string Nombre
            {
                get { return nombre; }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException("El nombre del producto no puede estar vacío.");
                    }
                    nombre = value;
                }
            }

            // Propiedad Precio con validación (mayor que 0)
            public decimal Precio
            {
                get { return precio; }
                set
                {
                    if (value <= 0)
                    {
                        throw new ArgumentException("El precio debe ser mayor que 0.");
                    }
                    precio = value;
                }
            }

            // Propiedad Cantidad con validación (no puede ser negativa)
            public int Cantidad
            {
                get { return cantidad; }
                set
                {
                    if (value < 0)
                    {
                        throw new ArgumentException("La cantidad no puede ser negativa.");
                    }
                    cantidad = value;
                }
            }

            // Propiedad de solo lectura: Valor Total
            public decimal ValorTotal
            {
                get { return precio * cantidad; }
            }

            // Constructor que recibe los datos e inicializa el objeto
            public Producto(string codigo, string nombre, decimal precio, int cantidad)
            {
                Codigo = codigo;
                Nombre = nombre;
                Precio = precio;
                Cantidad = cantidad;
            }

            // Método para mostrar la información del producto
            public void MostrarInfo()
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine($"Código: {Codigo}");
                Console.WriteLine($"Nombre: {Nombre}");
                Console.WriteLine($"Precio: ${Precio:F2}");
                Console.WriteLine($"Cantidad en Existencia: {Cantidad}");
                Console.WriteLine($"Valor Total en Inventario: ${ValorTotal:F2}");
                Console.WriteLine("----------------------------------------");
            }
        }
    }
}

