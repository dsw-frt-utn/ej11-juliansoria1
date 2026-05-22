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

    }
}
