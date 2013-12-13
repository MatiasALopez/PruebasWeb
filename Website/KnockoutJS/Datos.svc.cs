using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using System.Web;

namespace Website.KnockoutJS
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class Datos
    {
        private static List<Task> _tareas =
            new List<Task>
                {
                    new Task { title = "tarea 1", isDone = false },
                    new Task { title = "tarea 2", isDone = false },
                    new Task { title = "tarea 3", isDone = true },
                    new Task { title = "tarea 4", isDone = false }
                };

        [OperationContract]
        [WebGet(ResponseFormat=WebMessageFormat.Json)]
        public List<Status> ObtenerStatusLista()
        {
            var res = new List<Status>();
            for (int i = 1; i <= 10; i++)
            {
                res.Add(new Status { Name = "maq " + i, Value = i % 3 == 0, Timestamp = DateTime.Now });
            }
            return res;
        }

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        public List<Task> ObtenerTareas()
        {
            return _tareas;
        }

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        public void GuardarTareas(Stream data)
        {
            var ser = new System.Runtime.Serialization.Json.DataContractJsonSerializer(typeof(List<Task>));
            _tareas = (List<Task>)ser.ReadObject(data);
        }
    }
}
