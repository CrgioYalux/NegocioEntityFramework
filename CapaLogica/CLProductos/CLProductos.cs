using CapaLogica.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaLogica.CLProductos
{
    public class CLProductos
    {
        public List<ProductoViewModel> TraerTodosLosProductos()
        {
            List<ProductoViewModel> lst = new List<ProductoViewModel>();
            List<Producto> lstProducto = new List<Producto>();  

            Producto producto = new Producto();

            lstProducto = producto.GetDBAllProducts();

            foreach (Producto oProducto in lstProducto)
            {
                ProductoViewModel oProductoViewModel = new ProductoViewModel();
                oProductoViewModel.Nombre = oProducto.Nombre;
                oProductoViewModel.Precio = oProducto.Precio;
                lst.Add(oProductoViewModel);
            }

            return lst;
        }
    }
}
