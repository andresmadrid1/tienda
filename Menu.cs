using System;
using System.Collections.Generic;
using System.Text;

namespace Clases_y_metodos_abstract
{
    public class Menu : IMenu
    {
        Almacen g = new Golosinas();
        Almacen f = new Frutas();

        public void tipoProducto()
        {
            Console.WriteLine("Que tipo de producto te gustaria agregar a la tienda? golosinas/frutas");
            string tipProducto = Console.ReadLine();
            if (tipProducto == "golosinas")
            {
                golosinas();
            }
            else
            {
                frutas();
            }
        }
        
        public void golosinas()
        {
            var des = "";
            var valor = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Venta de golosinas");
                if (g.getProducto().Count == 0)
                {
                    Console.WriteLine("No hay golosinas");
                    Console.WriteLine("Desea agregar golosinas? presione la tecla s/n");
                    des = Console.ReadLine();
                    if (des == "s")
                    {
                        Console.WriteLine("Cuantas golosinas va a agregar?");
                        int cant = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < cant; i++)
                        {
                            Console.WriteLine("Nueva golosina");
                            Console.WriteLine("Ingrese la id");
                            var id = Console.ReadLine();
                            Console.WriteLine("Ingrese el nombre");
                            var nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese el precio");
                            var precio =  Convert.ToDouble(Console.ReadLine());
                            g.addProducto(new Producto {ID = id, Nombre = nombre, Precio = precio});    
                        }
                        Console.WriteLine("Desea ir al inicio s/n");
                        des = Console.ReadLine();
                        if (des == "s")
                        {
                            valor = true;
                        }
                        else
                        {
                            valor = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Desea ir al inicio s/n");
                        des = Console.ReadLine();
                        if (des == "s")
                        {
                            Console.Clear();
                            Console.WriteLine("Venta de golosinas");
                        }
                        else
                        {
                            valor = false;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Lista de golosinas");
                    foreach (var item in g.getProducto())
                    {
                        Console.WriteLine($"Codigo {item.ID} Golosina {item.Nombre} Precio {item.Precio}");
                    }
                    Console.WriteLine("Desea realizar ventas de golosinas? s/n");
                    des = Console.ReadLine();
                    if (des == "s")
                    {
                        ventas();
                    }
                    else
                    {

                    }

                }
            } while (valor);
        }

        public void frutas()
        {
            var des = "";
            var valor = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Venta de frutas");
                if (f.getProducto().Count == 0)
                {
                    Console.WriteLine("No hay frutas");
                    Console.WriteLine("Desea agregar frutas? presione la tecla s/n");
                    des = Console.ReadLine();
                    if (des == "s")
                    {
                        Console.WriteLine("Cuantas frutas va a agregar?");
                        int cant = Convert.ToInt32(Console.ReadLine());
                    }
                    else
                    {

                    }
                }
            } while (valor) ;
        }

        public double solicitarPago()
        {
            throw new NotImplementedException();
        }

        public void ventas()
        {
            throw new NotImplementedException();
        }
    }
}
