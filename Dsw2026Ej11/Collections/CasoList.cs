using Dsw2026Ej11.Domain;
using System;
using System.Collections.Generic;
namespace Dsw2026Ej11.Collections;
//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    // Campo que representa una lista de alumnos
    List<Alumno> alumnos = new List<Alumno>();

    // Método para agregar alumnos a la lista
    public void agregarAlumnos(Alumno nuevoAlumno){

        alumnos.Add(nuevoAlumno);

    }

    // Método para retornar la lista
    public void verAlumnos() {
        foreach (Alumno alumno in alumnos)
        {
            Console.WriteLine("Alumno: " + alumno.Nombre + ", ID: " + alumno.Id + ", Nota: " + alumno.Promedio);
        }
    }

    // Metodo para buscar alumno por nombre
    public Alumno buscarAlumno(string nombre){
        
        foreach (Alumno alumno in alumnos)
        {
            if (alumno.Nombre.ToLower() == nombre.ToLower())
            {
                Console.WriteLine("El alumno " + nombre + " se encuentra en la lista.");
                return alumno;
            }
        }
        Console.WriteLine("El alumno " + nombre + " NO EXISTE.");
        return null;
    }

    // Método para eliminar un alumno (debe recibir un alumno)
    
    public bool EliminarAlumno(Alumno alumnoFalso)
    {
        
        Alumno alumnoReal = alumnos.Find(a => a.Id == alumnoFalso.Id);

       
        if (alumnoReal != null)
        {
           
            alumnos.Remove(alumnoReal);
            return true;
        }

        
        return false;
    }

    //Metodo para eliminar un alumno en una determinada posición de la lista
    public void eliminarPosicion(int posicion){ 
        if(posicion >= 0 && posicion < alumnos.Count)
        {
            Alumno alumno = alumnos[posicion];
            alumnos.RemoveAt(posicion);
            Console.WriteLine("El alumno " + alumno.Nombre + " de la posición " + posicion + " ha sido eliminado de la lista.");
        }
        else
        {
            Console.WriteLine("La posición " + posicion + " no es válida.");
        }
    }
}
