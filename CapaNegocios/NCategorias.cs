using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocios
{
    public class NCategorias
    {
        //Método Insertar que llama al método Insertar de la clase DCategoría
        //de la CapaDatos
        public static string Insertar(string nombre, string descripcion)
        {
            DCategorias Obj = new DCategorias();
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            return Obj.Insertar(Obj);
        }

        //Método Editar que llama al método Editar de la clase DCategoría
        //de la CapaDatos
        public static string Editar(int idcategoria, string nombre, string descripcion)
        {
            DCategorias Obj = new DCategorias();
            Obj.Idcategoria = idcategoria;
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            return Obj.Editar(Obj);
        }

        //Método Eliminar que llama al método Eliminar de la clase DCategoría
        //de la CapaDatos
        public static string Eliminar(int idcategoria)
        {
            DCategorias Obj = new DCategorias();
            Obj.Idcategoria = idcategoria;
            return Obj.Eliminar(Obj);
        }

        //Método Mostrar que llama al método Mostrar de la clase DCategoría
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DCategorias().Mostrar();
        }

        //Método BuscarNombre que llama al método BuscarNombre
        //de la clase DCategoría de la CapaDatos

        public static DataTable BuscarNombre(string textobuscar)
        {
            DCategorias Obj = new DCategorias();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }
        public static string Activar(int Id)
        {
            DCategorias Datos = new DCategorias();
            return Datos.Activar(Id);
        }

        public static string Desactivar(int Id)
        {
            DCategorias Datos = new DCategorias();
            return Datos.Desactivar(Id);
        }
        public static DataTable Listar()
        {
            DCategorias Datos = new DCategorias();
            return Datos.Listar();
        }

    }
}
