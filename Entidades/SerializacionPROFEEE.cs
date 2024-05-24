using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Text.Json;

namespace Entidades
{
    public class SerializacionPROFEEE
    {
        public string path;

        public SerializacionPROFEEE(string path) 
        {

            this.path=Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            this.path += "/Objetos serializados";



            if (!Directory.Exists(this.path))
            Directory.CreateDirectory(this.path);

          
            this.path+="/"+path;

        }


        public void SerializarPersonasXML(List<Persona> personas)
        {
            using(XmlTextWriter w=new XmlTextWriter(this.path+".xml",Encoding.UTF8))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Persona>));

                ser.Serialize(w, personas);
            }
        }

        public List<Persona> DeserializarPersonasXML()
        {
            List<Persona> auxPersonas = new List<Persona>();

            using (XmlTextReader r = new XmlTextReader(this.path + ".xml"))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Persona>));

                auxPersonas = (List<Persona>)ser.Deserialize(r);
                
             
            }

            return auxPersonas;
        }



        public void SerializarPersonasJSON(List<Persona> personas)
        {
            JsonSerializerOptions opciones = new JsonSerializerOptions();
            opciones.WriteIndented = true;

            using (StreamWriter streamWriter = new StreamWriter(this.path + ".json"))
            {
               string objJson= JsonSerializer.Serialize(personas, opciones);

                streamWriter.WriteLine(objJson);
            }
        }

        public List<Persona> DeserializarPersonasJSON()
        {
            List<Persona> listaAux = new List<Persona>();

            using (StreamReader streamReader= new StreamReader(this.path + ".json"))
            {
                string jsonPersonas = streamReader.ReadToEnd();

                listaAux = JsonSerializer.Deserialize<List<Persona>>(jsonPersonas);
      
            }

            return listaAux;
        }

    }

}
