using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana8.DAO
{
    public class CrudProductos
    {
        public void AgregarProducto(Producto ParametroProducto)
        {
            using (AlmacenContext db = new AlmacenContext())
            {
                Producto Pro = new Producto();

                Pro.Nombre = ParametroProducto.Nombre;
                Pro.Descripcion = ParametroProducto.Descripcion;
                Pro.Precio = ParametroProducto.Precio;
                Pro.Stock = ParametroProducto.Stock;
                db.Add(Pro);
                db.SaveChanges();
            }
        }
    }
}
