using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCTP1
{
    public class Archivo
    {
        public int Id { get; set; }
        [DisplayName("Código")]
        public string Codigo { get; set; }
        [DisplayName("Nombre")]
        public string Nombre { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        [DisplayName("Url Imágen")]
        public string ImagenUrl { get; set; }
        public Marcas Marca { get; set; }
        [DisplayName("Categoría")]
        public Categorias Categoria { get; set; }
        public decimal Precio { get; set; }
    }
}
