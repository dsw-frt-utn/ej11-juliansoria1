using Dsw2026Ej11.Domain;
using System;
using System.Collections.Generic;
namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    private Dictionary<int, Alumno> alumnos = new Dictionary<int, Alumno>();

    // Método para agregar un alumno al diccionario
    public bool agregarAlumno(int legajo, Alumno nuevoAlumno)
    {
        
        if (!alumnos.ContainsKey(legajo))
        {
            alumnos.Add(legajo, nuevoAlumno);
            return true; 
        }
        return false; 
    }

    // Método para buscar un alumno utilizando la clave
    public void buscarAlumno(int legajo)
    {
        if (alumnos.ContainsKey(legajo))
        {
            Console.WriteLine($"El legajo {legajo} pertenece a: {alumnos[legajo].ToString()}");
        }
        else
        {
            Console.WriteLine($"No se encontró ningún alumno con el legajo {legajo}.");
        }
    }

    // Método para retornar el diccionario
    public Dictionary<int, Alumno> obtenerAlumnos()
    {
        Console.WriteLine("Lista de alumnos en el diccionario:");
        if (alumnos.Count == 0)
        {
            Console.WriteLine("El diccionario está vacío.");
        }
        else
        {
            foreach (var par in alumnos)
            {
                Console.WriteLine($"Legajo: {par.Key} -> Datos: {par.Value.ToString()}");
            }
        }
        
        return alumnos;
    }

    // Método para eliminar un alumno utilizando la clave
    public void eliminarAlumno(int legajo)
    {
        if (alumnos.ContainsKey(legajo))
        {
            alumnos.Remove(legajo);
            Console.WriteLine($"El legajo {legajo} fue eliminado correctamente.");
        }
        else
        {
            Console.WriteLine($"El legajo: {legajo} NO existe.");
        }
    }
}
