using System;
using System.Collections.Generic;
using System.Text;

namespace Clases_y_metodos_abstract
{
    //Una clase abstracta no puede ser instanciada
    public abstract class Almacen
    {
        public abstract List<Producto> getProducto();
        public abstract void addProducto(Producto producto);
    }
}
