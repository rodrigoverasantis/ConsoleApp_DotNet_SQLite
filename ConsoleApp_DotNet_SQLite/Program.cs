using ConsoleApp_DotNet_SQLite.Domain;
using ConsoleApp_DotNet_SQLite.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_DotNet_SQLite {
  class Program {
    static void Main(string[] args) {
      var personaService = new PersonaService();
      //var check = personaService.Agregar(new Persona { Nombre = "Jaun",ApellidoPaterno = "Perez",ApellidoMaterno = "",FechaNacimiento = DateTime.Now });
      var personas = personaService.ObtenerTodo();
      Console.WriteLine(personas.Count());
    }
  }
}
