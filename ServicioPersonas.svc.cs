using DataBussinesPersonas;
using EntityPersonas2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebWCFPersonas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioPersonas" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioPersonas.svc o ServicioPersonas.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioPersonas : IServicioPersonas
    {
        public List<EntPersonas> Obtener()
        {
            DBPersonas datos = new DBPersonas();
            List<EntPersonas> ls = datos.Obtener();
            return ls;
        }

        public EntPersonas ObtenerPorId(int Id)
        {
            DBPersonas datos = new DBPersonas();
            EntPersonas persona = datos.Obtener(Id);
            return persona;
        }

        public void Agregar(EntPersonas x)
        {
            DBPersonas datos = new DBPersonas();
            datos.Agregar(x);
        }

        public void Editar(EntPersonas x)
        {
            DBPersonas datos = new DBPersonas();
            datos.Editar(x);
        }

        public void Eliminar(EntPersonas x)
        {
            DBPersonas datos = new DBPersonas();
            datos.Eliminar(x);
        }

    }

}

