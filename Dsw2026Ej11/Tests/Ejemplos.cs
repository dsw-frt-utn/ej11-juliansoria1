using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList casoList = new CasoList();
        casoList.agregarAlumnos(new Alumno(123,"Pedro",7.5));
        casoList.agregarAlumnos(new Alumno(456,"Juan",8.0));
        casoList.agregarAlumnos(new Alumno(789,"Jaime",6.5));
        casoList.verAlumnos();
        casoList.buscarAlumno("Pedro");
        casoList.buscarAlumno("Ana");
        casoList.EliminarAlumno(new Alumno(456,"Juan",8.0));
        casoList.verAlumnos();
        casoList.eliminarPosicion(0);
        casoList.verAlumnos();
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary casoDictionary = new CasoDictionary();
        casoDictionary.agregarAlumno(123, new Alumno(123,"Pedro",7.5));
        casoDictionary.agregarAlumno(456, new Alumno(456,"Juan",8.0));
        casoDictionary.agregarAlumno(789, new Alumno(789,"Jaime",6.5));
        casoDictionary.obtenerAlumnos();
        casoDictionary.buscarAlumno(123);
        casoDictionary.buscarAlumno(999);
        casoDictionary.eliminarAlumno(456);
        casoDictionary.obtenerAlumnos();

    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        CasoLinq casoLinq = new CasoLinq();

        // 1. Obtener el primer libro (Devuelve un objeto Libro)
        Console.WriteLine("1. Primer Libro:");
        Libro primero = casoLinq.GetPrimero();
        Console.WriteLine($"- {primero.Titulo} (Id: {primero.Id}, Precio: {primero.Precio:C})\n");

        // 2. Obtener el último libro (Devuelve un objeto Libro)
        Console.WriteLine("2. Último Libro:");
        Libro ultimo = casoLinq.GetUltimo();
        Console.WriteLine($"- {ultimo.Titulo} (Id: {ultimo.Id}, Precio: {ultimo.Precio:C})\n");

        // 3. Obtener la suma de precios (Devuelve un decimal)
        Console.WriteLine("3. Suma total de precios:");
        decimal total = casoLinq.GetTotalPrecios();
        Console.WriteLine($"- Total: {total:C}\n");

        // 4. Obtener el promedio de precios (Devuelve un decimal)
        Console.WriteLine("4. Promedio de precios:");
        decimal promedio = casoLinq.GetPromedioPrecios();
        Console.WriteLine($"- Promedio: {promedio:C}\n");

        // 5. Libros con Id mayor a 15 (Devuelve List<Libro>)
        Console.WriteLine("5. Libros con Id > 15:");
        List<Libro> librosIdMayor15 = casoLinq.GetListById();
        foreach (Libro lib in librosIdMayor15)
        {
            Console.WriteLine($"   [{lib.Id}] {lib.Titulo}");
        }
        Console.WriteLine();

        // 6. Lista de strings (Título y Precio) (Devuelve List<string>)
        Console.WriteLine("6. Título y Precio (Lista de Strings):");
        List<string> listaCadenas = casoLinq.GetLibros();
        foreach (string cadena in listaCadenas)
        {
            Console.WriteLine($"   {cadena}");
        }
        Console.WriteLine();

        // 7. Libro más caro (Devuelve un objeto Libro)
        Console.WriteLine("7. Libro más caro:");
        Libro masCaro = casoLinq.GetMayorPrecio();
        Console.WriteLine($"- {masCaro.Titulo} ({masCaro.Precio:C})\n");

        // 8. Libro más barato (Devuelve un objeto Libro)
        Console.WriteLine("8. Libro más barato:");
        Libro masBarato = casoLinq.GetMenorPrecio();
        Console.WriteLine($"- {masBarato.Titulo} ({masBarato.Precio:C})\n");

        // 9. Libros con precio mayor al promedio (Devuelve List<Libro>)
        Console.WriteLine("9. Libros por encima del promedio:");
        List<Libro> librosCaros = casoLinq.GetMayorPromedio();
        foreach (Libro lib in librosCaros)
        {
            Console.WriteLine($"   - {lib.Titulo} ({lib.Precio:C})");
        }
        Console.WriteLine();

        // 10. Libros ordenados descendentemente (Devuelve List<Libro>)
        Console.WriteLine("10. Libros ordenados Z-A:");
        List<Libro> ordenados = casoLinq.GetLibrosOrdenadosDesc();
        foreach (Libro lib in ordenados)
        {
            Console.WriteLine($"   - {lib.Titulo}");
        }
        Console.WriteLine();
    }
}
