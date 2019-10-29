using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
namespace Clase11.entidades
{
    public class Persona: IXML
    {
        public string nombre, apellido;
        private int edad;
        public int Edad { get { return edad; } set { edad = value; } }

        private List<String> apodos = new List<string>();
        public List<String> Apodos { get { return apodos; } }

        public Persona(string n, string a, int e)
        {
            this.nombre = n;
            this.apellido = a;
            this.edad = e;
        }

        public Persona()
        {
            this.nombre = "";
            this.apellido = "";
            this.edad = 0;
        }

        public override string ToString()
        {
            return this.nombre + " " + this.apellido + " " + this.edad;
        }

        public bool Guardar(string s)
        {
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(Persona));
                XmlTextWriter xmlText = new XmlTextWriter(s, Encoding.UTF8);
                xml.Serialize(xmlText, this);
                xmlText.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool Leer(string s, out object o)
        {
            
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Persona));
                XmlTextReader reader = new XmlTextReader(s);
                o = serializer.Deserialize(reader);
                reader.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
    }
}
