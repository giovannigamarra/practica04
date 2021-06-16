using System;
using System.ComponentModel.DataAnnotations;

namespace Practica04.Models
{
    public class FormularioRegistro
    {
         public int Id{get;set;}
        
[Required]
          public string titulofoto{get;set;}
           [Required]
         public string urlfoto{get;set;}
  [Required]
          public string comentario{get;set;}
        
[Required]
          public string subidopor{get;set;}
          public DateTime FechaRegistro{get;set; }
         public FormularioIngreso FormularioIngreso{get;set;}
           public int FormularioIngresoId {get;set;}
            
          public FormularioRegistro(){
                FechaRegistro = DateTime.Now;
                }

    }
      
    }