using Dsw2026Ej11.Collections;

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
        casoList.agregarAlumnos("Pedro");
        casoList.agregarAlumnos("Juan");
        casoList.agregarAlumnos("Jaime");
        casoList.verAlumnos();
        casoList.buscarAlumno("Pedro");
        casoList.buscarAlumno("Ana");
        casoList.eliminarAlumno("Juan");
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
                casoDictionary.agregarAlumno(123, "Pedro");
                casoDictionary.agregarAlumno(456, "Juan");
                casoDictionary.agregarAlumno(789, "Jaime");
                casoDictionary.verAlumnos();
                casoDictionary.buscarAlumno(123);
                casoDictionary.buscarAlumno(777);
                casoDictionary.eliminarAlumno(456);
                casoDictionary.verAlumnos();
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {

    }
}
