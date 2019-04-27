using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_DotNet_SQLite.Domain {
  public class Vehiculo {

    public Guid Id { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public DateTime FechaFabricacion { get; set; }
  }
}
