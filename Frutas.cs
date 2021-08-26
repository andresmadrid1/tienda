using System;
using System.Collections.Generic;
using System.Text;

namespace Clases_y_metodos_abstract
{
    public class Frutas : Almacen
    {
        private List<Producto> _frutas;
        public Frutas()
        {
            _frutas = new List<Producto>();
        }
        public override void addProducto(Producto producto)
        {
            _frutas.Add(producto);
        }

        public override List<Producto> getProducto()
        {
            return _frutas;
        }
    }
}
