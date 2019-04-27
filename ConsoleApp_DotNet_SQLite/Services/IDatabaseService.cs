using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_DotNet_SQLite.Services {
  internal interface IDatabaseService<T> {

    bool Actualizar(T _entidad);
    bool Agregar(T _entidad);
    bool Eliminar(T _entidad);
    T Obtener(Guid _id);
    IEnumerable<T> ObtenerTodo();
  }
}
