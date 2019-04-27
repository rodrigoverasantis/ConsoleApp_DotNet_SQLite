using ConsoleApp_DotNet_SQLite.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace ConsoleApp_DotNet_SQLite.Context {
  public class DataContext:DbContext {

    private const string CONNECTION_STRING = "Data Source=database.sqlite;Version=3;";

    public DbSet<Persona> Personas { get; set; }
    public DbSet<Vehiculo> Preguntas { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder) {
      base.OnModelCreating(modelBuilder);

      var SQLiteConnection = new SQLiteConnection(DataContext.CONNECTION_STRING);
      modelBuilder.Build(SQLiteConnection);
    }
  }
}
