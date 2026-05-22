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
    Dictionary<int, string> alumno = new Dictionary<int, string>();

    // Método para agregar un alumno al diccionario
    public void agregarAlumno(int legajo, string nombre){
        
        alumno.Add(legajo, nombre);

    }

    // Método para buscar un alumno utilizando la clave
    public void buscarAlumno(int legajo) {
        if (alumno.ContainsKey(legajo)) {
        
        Console.WriteLine("El alumno con legajo " + legajo + " es " + alumno[legajo]);
        } 
        else {
            Console.WriteLine("No se encontró un alumno con el legajo " + legajo);
        }
    
    }

    // Método para retornar el diccionario
    public void verAlumnos() {

        Console.WriteLine("Lista de alumnos:");

        foreach (KeyValuePair<int, string> entry in alumno) {
            Console.WriteLine("Legajo: " + entry.Key + ", Alumno: " + entry.Value);
        }
    }

    // Método para eliminar un alumno utilizando la clave
    public void eliminarAlumno(int legajo) {
        if (alumno.ContainsKey(legajo)){

            alumno.Remove(legajo);
            Console.WriteLine("El alumno " + legajo + " fue eliminado");
        }
        else { 
        Console.WriteLine("No se encontró un alumno con el legajo " + legajo);
        }
    
    }
}
