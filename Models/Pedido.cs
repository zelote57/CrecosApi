﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrecosApi.Models
{
    public class Pedido
    {
        //Clave Primaria
        [Key]
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        //Clave Foranea
        [ForeignKey(nameof(Cliente))]
        public int ClienteId { get; set; }        

        public Cliente Cliente { get; set; }
    }
}
