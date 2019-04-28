using ConsoleApp_DotNet_SQLite.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_DotNet_SQLite.Services {
  public abstract class DatabaseService<T>:IDatabaseService<T> where T : class {
    public bool Actualizar(T _entidad) {
      throw new NotImplementedException();
    }

    public bool Agregar(T _entidad) {
      try {
        using (var context = new DataContext()) {
          context.Set<T>().Add(_entidad);
          var cambios = context.SaveChanges();
          return cambios > 0;
        }
      } catch (Exception e) {
        throw new Exception($"Error al intentar agregar una entidad de tipo {typeof(T)}",e);
      }
    }

    public bool Eliminar(T _entidad) {
      throw new NotImplementedException();
    }

    public T Obtener(Guid _id) {
      throw new NotImplementedException();
    }

    public IEnumerable<T> ObtenerTodo() {
      try {
        using (var context = new DataContext()) {
          var entidades = context.Set<T>().ToList();
          return entidades;
        }
      } catch (Exception e) {
        throw new Exception($"Error al intentar obtener todas las entidadesde tipo {typeof(T)}",e);
      }
    }
  }
}
