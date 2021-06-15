using Microsoft.EntityFrameworkCore;

namespace Practica04.Models
{
    public class RegistroContext : DbContext
    {
        
        
         public DbSet<FormularioRegistro> FormularioRegistros{get;set; }

         public DbSet<FormularioIngreso> FormularioIngresos{get;set; }



          public RegistroContext(DbContextOptions dco) : base(dco){

          }
          }
}