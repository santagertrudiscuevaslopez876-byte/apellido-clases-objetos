# Sistema de Control de Inventario - TecnoPunto

Aplicación de consola desarrollada en C# (.NET) bajo el paradigma de Programación Orientada a Objetos para automatizar el registro, validación y cálculo de existencias en la tienda TecnoPunto.



# Integrantes del Equipo

| Estudiante | Matrícula |
| :--- | :--- |
| Samuel Diaz Cuevas | 2025-3588 |
| Daniel Livari | 2025-3676 |
| Jhorbell Cedeño | 2025-2792 |
| Maestro: Gamalier Reyes del Carmen|



# Descripción del Sistema

Desarrollamos un programa de consola en C# para administrar el inventario de la tienda **TecnoPunto**. Para ello, creamos la clase (Producto), que representa cada artículo y utiliza el encapsulamiento mediante atributos privados y propiedades públicas con validaciones en sus métodos (set). También incorporamos una propiedad de solo lectura que calcula automáticamente el valor total de las unidades disponibles en el inventario.

El sistema divide la lógica de negocio y la interfaz de usuario en dos archivos principales:

*Producto.cs: Define la clase Producto con encapsulamiento estricto. Protege los atributos mediante propiedades con bloques (set)  validados para impedir datos vacíos o valores numéricos fuera de rango, e incluye el cálculo automático del inventario y el método MostrarInfo().
*Program.cs: Controla la interfaz de consola mediante el método RegistrarProducto(int numero) para el ingreso secuencial de 3 artículos. Implementa bucles while (true) y bloques (try-catch) (FormatException y ArgumentException) para evitar cierres inesperados ante errores del usuario.



# Flujo de Datos del Sistema

# 1. Datos de Entrada
El programa solicita por consola los siguientes parámetros para cada uno de los 3 productos:
* Código del producto (string): Identificador alfanumérico obligatorio.
* Nombre del producto (string): Descripción obligatoria del artículo.
* Precio unitario (decimal): Valor monetario mayor a 0.
* Cantidad disponible (int): Número entero mayor o igual a 0.

# 2. Procesamiento y Validaciones
* Integridad de texto: Rechaza cadenas vacías o espacios en blanco mediante string.IsNullOrWhiteSpace().
* Reglas de negocio: Impide el registro de precios menores o iguales a cero (precio <= 0 ) y cantidades negativas (cantidad < 0).
* Cálculo automático: La propiedad de solo lectura (ValorTotal) calcula el monto invertido por producto mediante la fórmula: Precio * Cantidad.

# 3. Datos de Salida
Tras completar el registro de los 3 productos, la consola limpia la pantalla (Console.Clear) y despliega:
* Encabezado principal: === RESUMEN GENERAL DEL INVENTARIO ===.
* Ficha individual por producto generada con MostrarInfo(), detallando:
* Código y Nombre.
* Precio unitario formateado a dos decimales (Precio).
* Cantidad en existencia.
* Valor Total en Inventario** ( ValorTotal ).
* Pausa controlada al finalizar mediante Console.ReadKey().


