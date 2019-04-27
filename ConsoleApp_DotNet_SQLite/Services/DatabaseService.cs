using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_DotNet_SQLite.Services {
  public abstract class DatabaseService<T>:IDatabaseService<T> {
    public bool Actualizar(T _entidad) {
      throw new NotImplementedException();
    }

    public bool Agregar(T _entidad) {
      throw new NotImplementedException();
    }

    public bool Eliminar(T _entidad) {
      throw new NotImplementedException();
    }

    public T Obtener(Guid _id) {
      throw new NotImplementedException();
    }

    public IEnumerable<T> ObtenerTodo() {
      throw new NotImplementedException();
    }
  }
}
