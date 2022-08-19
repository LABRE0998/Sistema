using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class NVentas
    {
        //Método Insertar que llama al método Insertar de la clase DVenta
        //de la CapaDatos
        public static string Insertar(int idcliente, int idtrabajador, DateTime fecha,
            string tipo_comprobante, string serie, string correlativo, decimal igv,
            DataTable dtDetalles)
        {
            DVentas Obj = new DVentas();
            Obj.Idcliente = idcliente;
            Obj.Idtrabajador = idtrabajador;
            Obj.Fecha = fecha;
            Obj.Tipo_Comprobante = tipo_comprobante;
            Obj.Serie = serie;
            Obj.Correlativo = correlativo;
            Obj.Igv = igv;
            List<DDetalle_Ventas> detalles = new List<DDetalle_Ventas>();
            foreach (DataRow row in dtDetalles.Rows)
            {
                DDetalle_Ventas detalle = new DDetalle_Ventas();
                detalle.Iddetalle_ingreso = Convert.ToInt32(row["iddetalle_ingreso"].ToString());
                detalle.Cantidad = Convert.ToInt32(row["cantidad"].ToString());
                detalle.Precio_Venta = Convert.ToDecimal(row["precio_venta"].ToString());
                detalle.Descuento = Convert.ToDecimal(row["descuento"].ToString());
                detalles.Add(detalle);

            }


            return Obj.Insertar(Obj, detalles);
        }

        //Método Anular que llama al método Anular de la clase DVenta
        //de la CapaDatos
        public static string Eliminar(int idventa)
        {
            DVentas Obj = new DVentas();
            Obj.Idventa = idventa;
            return Obj.Eliminar(Obj);
        }

        //Método Mostrar que llama al método Mostrar de la clase DVenta
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DVentas().Mostrar();
        }

        //Método BuscarFechas que llama al método BuscarFechas
        //de la clase DVenta de la CapaDatos
        public static DataTable BuscarFechas(string textobuscar, string textobuscar2)
        {
            DVentas Obj = new DVentas();
            return Obj.BuscarFechas(textobuscar, textobuscar2);
        }
        public static DataTable MostrarDetalle(string textobuscar)
        {
            DVentas Obj = new DVentas();
            return Obj.MostrarDetalle(textobuscar);
        }
        public static DataTable MostrarArticulo_Venta_Nombre(string textobuscar)
        {
            DVentas Obj = new DVentas();
            return Obj.MostrarProducto_Venta_Nombre(textobuscar);
        }
        public static DataTable MostrarArticulo_Venta_Codigo(string textobuscar)
        {
            DVentas Obj = new DVentas();
            return Obj.MostrarProducto_Venta_codigo(textobuscar);
        }
    }
}
