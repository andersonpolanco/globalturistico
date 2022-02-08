using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entidades
{
    public class Lugar
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double GastoAproximado { get; set; }
        public string ImagenUrl { get; set; }
        public int PaisId { get; set; }
        [ForeignKey("PaisId")]
        public Pais Pais { get; set; }
        public int CategoriaID { get; set; }
        [ForeignKey("CategoriaID")]
        public Categoria Categoria { get; set; }
    }
}