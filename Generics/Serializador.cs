using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.IO;


namespace Generics
{
    public class Serializador
    {
        public static void Serializar(object obj)
        {
            StreamWriter stream = new StreamWriter(@"C:\Projetos\Projetos\Cursos\Curso-de-CSharp-Avancado-Arquivos\" + obj.GetType().Name + ".json");

            JavaScriptSerializer serializador = new JavaScriptSerializer();
            string objJSON = serializador.Serialize(obj);

            stream.Write(objJSON);
            stream.Close();
        }

        public static T Deserializar<T>()
        {
            StreamReader stream = new StreamReader(@"C:\Projetos\Projetos\Cursos\Curso-de-CSharp-Avancado-Arquivos\" + typeof(T).Name + ".json");

            string arquivo = stream.ReadToEnd();

            JavaScriptSerializer serializador = new JavaScriptSerializer();

            // return (T)serializador.Deserialize(arquivo, typeof(T));

            return serializador.Deserialize<T>(arquivo);
        }
    }
}
