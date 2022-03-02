using EntityPersonas2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebWCFPersonas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioPersonas" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioPersonas
    {
        [OperationContract]
        List<EntPersonas> Obtener();


        [OperationContract]
        EntPersonas ObtenerPorId(int Id);


        [OperationContract] 
        void Agregar(EntPersonas x);


        [OperationContract]
        void Editar(EntPersonas x);


        [OperationContract]
        void Eliminar(EntPersonas x);

    }
}
