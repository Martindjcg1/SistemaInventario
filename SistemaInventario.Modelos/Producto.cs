using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Modelos
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El numero de serie es requerido")]
        [MaxLength(30, ErrorMessage = "Maximo 30 Caracteres")]
        public string NumeroSerie { get; set; }
        [Required(ErrorMessage = "La descripcion es requerida")]
        [MaxLength(100, ErrorMessage = "Maximo 100 Caracteres")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "El precio es requerido")]
        public double Precio { get; set; }
        [Required(ErrorMessage = "El costo es requerido")]
        public double Costo { get; set; }

        public string ImagenUrl { get; set; }

        [Required(ErrorMessage = "El estado es requerido")]
        public bool Estado { get; set; }


        //Hagamos la relacion con la tabla categoria
        [Required(ErrorMessage = "La categoria es requerida")]
        public int CategoriaId { get; set; }
        [ForeignKey("CategoriaId")]
        public Categoria Categoria { get; set; }


        //Hagamos la relacion con la tabla marca
        [Required(ErrorMessage = "La marca es requerida")]
        public int MarcaId { get; set; }
        [ForeignKey("MarcaId")]
        public Marca Marca { get; set; }

        //Hagamos la Recursividad del padre

        public int? PadreId { get; set; }

        public virtual Producto Padre {get; set;}
    }
}
