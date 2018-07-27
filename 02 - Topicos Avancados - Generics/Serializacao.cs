using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.IO;

namespace _02___Topicos_Avancados___Generics
{
    public class Serializacao
    {
        //Sem uso de GENERICS, apenas uma passagem de parametro por OBJECT
        public static void Serializar(object obj)
        {
            StreamWriter writer = new StreamWriter(@"C:\Telecon_Sistemas\03_" + obj.GetType().Name + ".txt");

            JavaScriptSerializer serializer = new JavaScriptSerializer();

            string objSerializado = serializer.Serialize(obj);

            writer.Write(objSerializado);
            writer.Close();
        }

        //Com uso de GENERICS. GENERICS poderá ser utilizado em qualquer lugar, classe, método...<>
        public static T Deserializar<T>()
        {
            StreamReader reader = new StreamReader(@"C:\Telecon_Sistemas\03_" + typeof(T).Name + ".txt");

            string conteudo = reader.ReadToEnd();

            JavaScriptSerializer javaScript = new JavaScriptSerializer();

            T obj = (T) javaScript.Deserialize(conteudo, typeof(T));

            return obj; 
        }
    }
}
