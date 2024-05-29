using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Xml.Serialization;

namespace Entidades
{
    public class Serializacion
    {

        private string path;

        public string Path 
        {
            get{  return this.path; }
            set {  this.path = value; } 
        }

        public Serializacion(string path) 
        {
            this.path = path;
        
        }

        public List<Usuario> DeserializarJson()
        {
            List<Usuario> listAux = new List<Usuario>();

            using StreamReader sr = new StreamReader(this.path);
            {
                string usuariosJson = sr.ReadToEnd();

                listAux = JsonSerializer.Deserialize<List<Usuario>>(usuariosJson);


            }


            return listAux;
        }

        public void SerializacionXML(List<Laboratorio> listaLaboratorios)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Laboratorio>));

            using (StreamWriter writer = new StreamWriter(this.path))
            {
                serializer.Serialize(writer, listaLaboratorios);
            }
        }

        public List<Laboratorio> DeserializarXML()
        {
            List<Laboratorio> listaLaboratorios = null;
            XmlSerializer serializer = new XmlSerializer(typeof(List<Laboratorio>));

            using (StreamReader reader = new StreamReader(this.path))
            {
                listaLaboratorios = (List<Laboratorio>)serializer.Deserialize(reader);
            }

            return listaLaboratorios;
        }







    }
}
