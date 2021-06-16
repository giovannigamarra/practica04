using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Practica04.Models
{
    public class FormularioIngreso
    {
         public int Id{get;set;}
         [Required]

         public string NombreUsuario{get;set;}
        
          public ICollection<FormularioRegistro> FormularioRegistros{get;set;}
    }
}
