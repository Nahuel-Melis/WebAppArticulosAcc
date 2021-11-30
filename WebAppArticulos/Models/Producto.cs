using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppArticulos.Models {
    public class Producto {

        public long id { get; set; } // prop + tabx2

        public string Nombre { get; set; } // primer tab selecciona todo el tipo, seg el nombre

        public string Descripcion { get; set; }

        public DateTime? FechaCreacion { get; set; } // ? permite nulo

        public DateTime? FechaModificacion { get; set; }

        public int PrecioUnitario { get; set; }

        public int Eliminado { get; set; }

        //Relacion

        public long CategoryId { get; set; } //nombre de llave externa por reglas nomenclatura

        public Categoria Categoria { get; set; } // por relga tiene que incluir la clase que esta implementando
    }
}