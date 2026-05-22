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
    List<string> alumnos = new List<string>();

    // Método para agregar alumnos a la lista
    public void agregarAlumnos(string nombre){

        alumnos.Add(nombre);

    }

    // Método para retornar la lista
    public void verAlumnos(){
       Console.WriteLine("Lista de alumnos:");
        foreach (string alumno in alumnos) { 
        
            Console.WriteLine(alumno);

        }
    }

    // Metodo para buscar alumno por nombre
    public void buscarAlumno(string nombre){
        
        if (alumnos.Contains(nombre)) { 
        
            Console.WriteLine("El alumno " + nombre + " se encuentra en la lista.");
        } else {
            Console.WriteLine("El alumno " + nombre + " NO EXISTE.");
        }
    }

    // Método para eliminar un alumno (debe recibir un alumno)
    public void eliminarAlumno(string nombre){
        if (alumnos.Contains(nombre))
        {
            alumnos.Remove(nombre);
            Console.WriteLine("El alumno " + nombre + " ha sido eliminado de la lista.");
        }
        else 
        { 
           Console.WriteLine("El alumno " + nombre + " no se encuentra en la lista.");
        }
    }

    //Metodo para eliminar un alumno en una determinada posición de la lista
    public void eliminarPosicion(int posicion){ 
        if(posicion >= 0 && posicion < alumnos.Count)
        {
            string alumno = alumnos[posicion];
            alumnos.RemoveAt(posicion);
            Console.WriteLine("El alumno " + alumno + " de la posición " + posicion + " ha sido eliminado de la lista.");
        }
        else
        {
            Console.WriteLine("La posición " + posicion + " no es válida.");
        }
    }
}
