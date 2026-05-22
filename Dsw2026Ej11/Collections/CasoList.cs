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
   
    List<string> alumnos = new List<string>();

    foreach(string alumno in new string[5]{"Pedro" , "Juan", "Jaime", "Ana", "Luis"})
    {
        alumnos.Add(alumno);
    }

}
